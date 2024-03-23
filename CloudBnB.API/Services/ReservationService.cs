using CloudBnB.API.Data;
using CloudBnB.API.Dtos;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILocationRepository _locationRepository;
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(ICustomerRepository customerRepository, 
            IReservationRepository reservationRepository, ILocationRepository locationRepository)
        {
            this._reservationRepository = reservationRepository;
            this._customerRepository = customerRepository;
            this._locationRepository = locationRepository;
        }

        public async Task<Reservation> Reserve(ReservationCreationDto reservationCreationDto)
        {
            // Step 1: Find or Create a customer
            var customer = await this._customerRepository.FetchOrCreate(
                email: reservationCreationDto.Email,
                firstName: reservationCreationDto.FirstName,
                lastName: reservationCreationDto.LastName);

            // Step 2: Create the reservation
            return await this._reservationRepository.Create(new Reservation
            {
                CustomerId = customer.Id,
                LocationId = reservationCreationDto.LocationId,
                StartDate = reservationCreationDto.StartDate,
                EndDate = reservationCreationDto.EndDate,
                Discount = reservationCreationDto.Discount ?? 0,
            });
        }

        public async Task<ReservationSuccessfullCreationDto> GetCreationInfo(Reservation reservation)
        {
            var location = await this._locationRepository.GetById(reservation.LocationId);
            var customer = await this._customerRepository.GetById(reservation.CustomerId);

            var totalDays = (reservation.EndDate - reservation.StartDate).Days;

            return new ReservationSuccessfullCreationDto
            {
                CustomerName = $"{customer?.FirstName} {customer?.LastName}",
                LocationName = location?.Title ?? string.Empty,
                Price = totalDays * location?.PricePerDay ?? 0,
                Discount = reservation.Discount,
            };
        }

        public async Task<bool> PeriodOfTimeFree(int locationId, DateTime startDate, DateTime endDate)
        {
            var reservations = await this._reservationRepository.GetByLocation(locationId);
            foreach (var reservation in reservations)
            {
                // If the reservation starts in the range of the requested period.
                if ((reservation.StartDate >= startDate && reservation.StartDate <= endDate) ||
                    (reservation.EndDate >= startDate && reservation.EndDate <= endDate))
                {
                    return false;
                }

                // If the requested period completely falls into the period of the reservation
                if (startDate >= reservation.StartDate && endDate <= reservation.EndDate)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

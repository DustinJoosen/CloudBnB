using CloudBnB.API.Dtos;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace CloudBnB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly ILocationRepository _locationRepository;

        public ReservationsController(IReservationService reservationService, ILocationRepository locationRepository)
        {
            this._reservationService = reservationService;
            this._locationRepository = locationRepository;
        }

        /// <summary>
        /// Creates a reservation.
        /// </summary>
        /// <param name="reservationCreation">Reservation to create</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Reserve([FromBody]ReservationCreationDto reservationCreation, CancellationToken cancellationToken)
        {
            // Ensure the locationId provided is valid.
            var locationValid = await this._locationRepository.Exists(reservationCreation.LocationId, cancellationToken);
            if (!locationValid)
                return NotFound("LocationId is not found");

            // Ensure the endDate is after the startDate.
            if (reservationCreation.StartDate > reservationCreation.EndDate)
                return Conflict("The startdate has to be before the enddate");

            // Ensure the email is valid.
            if (!this.IsValidEmail(reservationCreation.Email))
                return Conflict("Email is invalid");

            // Ensure the period of time is free.
            if (!await this._reservationService.PeriodOfTimeFree(
                locationId: reservationCreation.LocationId, 
                startDate: reservationCreation.StartDate, 
                endDate: reservationCreation.EndDate,
                cancellationToken: cancellationToken))
            {
                return Conflict("This location is already reserved for this period");
            }

            var creationInfo = await this._reservationService.Reserve(reservationCreation, cancellationToken);
            return Ok(creationInfo);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}

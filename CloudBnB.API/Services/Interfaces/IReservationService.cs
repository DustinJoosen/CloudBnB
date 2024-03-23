using CloudBnB.API.Dtos;
using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface IReservationService
    {
        public Task<Reservation> Reserve(ReservationCreationDto reservationCreationDto);
        public Task<ReservationSuccessfullCreationDto> GetCreationInfo(Reservation reservation);
        public Task<bool> PeriodOfTimeFree(int locationId, DateTime startDate, DateTime endDate);
    }
}
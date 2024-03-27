using CloudBnB.API.Dtos;
using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface IReservationService
    {
        /// <summary>
        /// Reserves a location for a period.
        /// </summary>
        /// <param name="reservationCreationDto">Reservation data</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Reservation object that got created</returns>
        public Task<ReservationSuccessfullCreationDto> Reserve(ReservationCreationDto reservationCreationDto, CancellationToken cancellationToken);

        /// <summary>
        /// Checks wether a location is free in a period of time.
        /// </summary>
        /// <param name="locationId">Id of the location to check</param>
        /// <param name="startDate">Starting date to check</param>
        /// <param name="endDate">End date to check</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns></returns>
        public Task<bool> PeriodOfTimeFree(int locationId, DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
    }
}
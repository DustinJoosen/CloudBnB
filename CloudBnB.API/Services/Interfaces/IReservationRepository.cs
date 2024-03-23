using CloudBnB.API.Dtos;
using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface IReservationRepository : ICrudRepository<Reservation>
    {
        /// <summary>
        /// Returns all reservations that match a specific location.
        /// </summary>
        /// <param name="locationId">LocationId to check</param>
        /// <returns>List of reservations</returns>
        public Task<List<Reservation>> GetByLocation(int locationId);
    }
}
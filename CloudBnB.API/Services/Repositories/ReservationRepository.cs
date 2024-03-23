using CloudBnB.API.Data;
using CloudBnB.API.Dtos;
using CloudBnB.API.Models;
using CloudBnB.API.Repositories;
using CloudBnB.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;

namespace CloudBnB.API.Services.Repositories
{
    public class ReservationRepository : CrudRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Reservation>> GetByLocation(int locationId)
        {
            return await this._context.Reservations
                .Where(reservation => reservation.LocationId == locationId)
                .ToListAsync();
        }
    }
}

using CloudBnB.API.Data;
using CloudBnB.API.Dtos;
using CloudBnB.API.Models;
using CloudBnB.API.Repositories;
using CloudBnB.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Services.Repositories
{
    public class LocationRepository : CrudRepository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<List<Location>> GetAll()
        {
            return await this._context.Locations
                .Include(location => location.Landlord)
                    .ThenInclude(landlord => landlord.Avatar)
                .Include(location => location.LocationImages)
                    .ThenInclude(locationImage => locationImage.Image)
                .ToListAsync();
        }

        public virtual async Task<double> GetMaxPrice() =>
            await this._context.Locations.MaxAsync(location => location.PricePerDay);

        public virtual async Task AddImage(int locationId, string uri)
        {
            // Save image.
            var image = this._context.Images.Add(new Image
            {
                IsCover = false,
                Url = uri
            }).Entity;

            await this._context.SaveChangesAsync();
         
            // Save LocationImage.
            this._context.LocationImages.Add(new LocationImage
            {
                ImageId = image.Id,
                LocationId = locationId
            });
            await this._context.SaveChangesAsync();
        }

        public virtual async Task<Location?> Details(int locationId)
        {
            var location = await this._context.Locations
                .Include(location => location.LocationImages)
                    .ThenInclude(locationImage => locationImage.Image)
                .Include(location => location.Landlord)
                    .ThenInclude(landlord => landlord.Avatar)
                .SingleOrDefaultAsync(location => location.Id == locationId);

            if (location == null)
                return null;

            return location;
        }

        public virtual async Task<List<DateTime>> UnavailableDates(int locationId)
        {
            var reservations = await _context.Reservations
                .Where(reservation => reservation.LocationId == locationId)
                .ToListAsync();

            List<DateTime> unavailableDates = [];

            foreach (var reservation in reservations)
            {
                // Safety check to ensure the reservation doesn't end before it's started.
                if (reservation.EndDate < reservation.StartDate)
                    continue;

                var range = reservation.EndDate - reservation.StartDate;
                unavailableDates.AddRange(Enumerable.Range(0, range.Days + 1)
                    .Select(offset => reservation.StartDate.AddDays(offset))
                    .Where(date => date >= DateTime.UtcNow));
            }

            return unavailableDates;
        }
    }
}

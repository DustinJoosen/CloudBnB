using Bogus;
using CloudBnB.API.Data;
using CloudBnB.API.Dtos;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Services
{
    public class SearchService : ISearchService
    {
        private ApplicationDbContext _context;
        public SearchService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public virtual async Task<List<Location>> Search(SearchDto search, CancellationToken cancellationToken)
        {
            var locations = await this._context.Locations
                .Include(location => location.Landlord)
                    .ThenInclude(landlord => landlord.Avatar)
                .Include(location => location.LocationImages)
                    .ThenInclude(locationImage => locationImage.Image)
                .ToListAsync(cancellationToken);

            if (search.MinPrice != null)
                locations = locations.Where(location => location.PricePerDay >= search.MinPrice).ToList();

            if (search.MaxPrice != null)
                locations = locations.Where(location => location.PricePerDay <= search.MaxPrice).ToList();

            if (search.Type != null)
                locations = locations.Where(location => location.LocationType == search.Type).ToList();

            if (search.Rooms != null)
                locations = locations.Where(location => location.Rooms > search.Rooms).ToList();

            if (search.Features != null)
                locations = locations.Where(location => location.Features >= search.Features).ToList();

            return locations;
        }
    }
}

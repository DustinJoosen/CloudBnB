using CloudBnB.API.Data;
using CloudBnB.API.Models;
using CloudBnB.API.Repositories;
using CloudBnB.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Services.Repositories
{
    public class LandlordRepository : CrudRepository<Landlord>, ILandlordRepository
    {
        public LandlordRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<List<Landlord>> GetAll(CancellationToken cancellationToken)
        {
            return await this._context.Landlords
                .Include(landlord => landlord.Avatar)
                .ToListAsync(cancellationToken);
        }
    }
}

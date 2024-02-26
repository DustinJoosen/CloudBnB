using CloudBnB.API.Data;
using CloudBnB.API.Models;
using CloudBnB.API.Repositories;
using CloudBnB.API.Services.Interfaces;

namespace CloudBnB.API.Services.Repositories
{
    public class ImageRepository : CrudRepository<Image>, IImageRepository
    {
        public ImageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

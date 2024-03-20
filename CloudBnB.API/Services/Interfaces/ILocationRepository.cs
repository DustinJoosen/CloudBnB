using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface ILocationRepository : ICrudRepository<Location>
    {
        /// <summary>
        /// Uploads both an image, and a locationimage
        /// </summary>
        /// <param name="locationId">Location to match image too</param>
        /// <param name="uri">Image to upload</param>
        public Task AddImage(int locationId, string uri);

        /// <summary>
        /// Returns the maximum price of any location currently stored in the datbase.
        /// </summary>
        /// <returns>Double maximum price</returns>
        public Task<double> GetMaxPrice();

        /// <summary>
        /// Gets the details of a particular location
        /// </summary>
        /// <param name="locationId">location to find</param>
        /// <returns></returns>
        public Task<Location?> Details(int locationId);
    }
}
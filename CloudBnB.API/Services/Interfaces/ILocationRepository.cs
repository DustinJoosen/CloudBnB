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
        /// <param name="cancellationToken">Token to cancel execution</param>
        public Task AddImage(int locationId, string uri, CancellationToken cancellationToken);

        /// <summary>
        /// Returns the maximum price of any location currently stored in the datbase.
        /// </summary>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Double maximum price</returns>
        public Task<double> GetMaxPrice(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the details of a particular location
        /// </summary>
        /// <param name="locationId">location to find</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>Model of found location</returns>
        public Task<Location?> Details(int locationId, CancellationToken cancellationToken);

        /// <summary>
        /// Gets a list of all unavailable dates for a specific location
        /// </summary>
        /// <param name="locationId">Id of location to check</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>List of DateTime's</returns>
        public Task<List<DateTime>> UnavailableDates(int locationId, CancellationToken cancellationToken);
    }
}
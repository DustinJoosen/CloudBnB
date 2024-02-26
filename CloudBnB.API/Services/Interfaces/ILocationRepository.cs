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
        /// Searches the title of each location for the term.
        /// </summary>
        /// <param name="term">Term to be checked. It will be parsed</param>
        /// <returns>A list of locations that match the term.</returns>
        public Task<List<Location>> Search(string term);
    }
}
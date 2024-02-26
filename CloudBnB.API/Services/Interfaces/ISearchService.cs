using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface ISearchService
    {
        /// <summary>
        /// Searches the title of each location for the term.
        /// </summary>
        /// <param name="term">Term to be checked. It will be parsed</param>
        /// <returns>A list of locations that match the term.</returns>
        public Task<List<Location>> SearchLocations(string term);
    }
}
using Bogus;
using CloudBnB.API.Models;
using CloudBnB.API.Services.Interfaces;

namespace CloudBnB.API.Services
{
    public class SearchService : ISearchService
    {
        private ILocationRepository _locationRepos;
        public SearchService(ILocationRepository locationRepos)
        {
            this._locationRepos = locationRepos;
        }

        /// <summary>
        /// Searches the title of each location for the term.
        /// </summary>
        /// <param name="term">Term to be checked. It will be parsed</param>
        /// <returns>A list of locations that match the term.</returns>
        public async Task<List<Location>> SearchLocations(string term) 
        {
            // Format the term for better results.
            term = term.Trim();
            term = term.ToLower();

            return await this._locationRepos.Search(term);
        }
    }
}

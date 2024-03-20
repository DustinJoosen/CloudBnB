using CloudBnB.API.Dtos;
using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface ISearchService
    {
        /// <summary>
        /// Searches for the locations.
        /// </summary>
        /// <param name="search">Criteria to apply</param>
        /// <returns>A list of locations that match the criteria.</returns>
        public Task<List<Location>> Search(SearchDto search);
    }
}
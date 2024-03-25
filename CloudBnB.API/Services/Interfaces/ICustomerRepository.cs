using CloudBnB.API.Models;

namespace CloudBnB.API.Services.Interfaces
{
    public interface ICustomerRepository : ICrudRepository<Customer>
    {
        /// <summary>
        /// If the customer exists, it gets returned. Otherwise it gets created
        /// </summary>
        /// <param name="email">Email to check existence of</param>
        /// <param name="firstName">Firstname of the user in case of create</param>
        /// <param name="lastName">Lastname of the user in case of create</param>
        /// <param name="cancellationToken">Token to cancel execution</param>
        /// <returns>The customer object</returns>
        public Task<Customer> FetchOrCreate(string email, string firstName, string lastName, CancellationToken cancellationToken);
    }
}
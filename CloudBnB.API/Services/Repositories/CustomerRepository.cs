using CloudBnB.API.Data;
using CloudBnB.API.Models;
using CloudBnB.API.Repositories;
using CloudBnB.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Services.Repositories
{
    public class CustomerRepository : CrudRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// If the customer exists, it gets returned. Otherwise it gets created
        /// </summary>
        /// <param name="email">Email to check existence of</param>
        /// <param name="firstName">Firstname of the user in case of create</param>
        /// <param name="lastName">Lastname of the user in case of create</param>
        /// <returns>The customer object</returns>
        public async Task<Customer> FetchOrCreate(string email, string firstName, string lastName)
        {
            // 'Fetch'. Checks if the customer exists. If it does, it gets returned.
            var customer = await this._context.Customers.SingleOrDefaultAsync(customer => customer.Email == email);
            if (customer != null)
                return customer;

            // 'Create'. The customer does not yet exist. Insert it.
            var newCustomer = this._context.Customers.Add(new Customer
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName
            }).Entity;

            await this._context.SaveChangesAsync();
            return newCustomer;
        }
    }
}

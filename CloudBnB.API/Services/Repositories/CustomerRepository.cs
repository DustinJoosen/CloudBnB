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

        public async Task<Customer> FetchOrCreate(string email, string firstName, string lastName, CancellationToken cancellationToken)
        {
            // 'Fetch'. Checks if the customer exists. If it does, it gets returned.
            var customer = await this._context.Customers.SingleOrDefaultAsync(customer => customer.Email == email, cancellationToken);
            if (customer != null)
                return customer;

            // 'Create'. The customer does not yet exist. Insert it.
            var newCustomer = this._context.Customers.Add(new Customer
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName
            }).Entity;

            await this._context.SaveChangesAsync(cancellationToken);
            return newCustomer;
        }
    }
}

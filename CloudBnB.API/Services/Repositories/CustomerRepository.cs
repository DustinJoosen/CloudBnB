using CloudBnB.API.Data;
using CloudBnB.API.Models;
using CloudBnB.API.Repositories;
using CloudBnB.API.Services.Interfaces;

namespace CloudBnB.API.Services.Repositories
{
    public class CustomerRepository : CrudRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

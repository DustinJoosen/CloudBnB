using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudBnB.API.Models;

namespace CloudBnB.API.Data
{
    public class CloudBnBAPIContext : DbContext
    {
        public CloudBnBAPIContext (DbContextOptions<CloudBnBAPIContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}

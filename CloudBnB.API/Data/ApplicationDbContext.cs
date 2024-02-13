using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudBnB.API.Models;
using Bogus;

namespace CloudBnB.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationImage> LocationImages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LocationImage>()
                .HasKey(li => new
                {
                    li.LocationId,
                    li.ImageId
                });


            // Use the seeding extension methods.
            modelBuilder
                .GenerateCustomers()
                .GenerateImages()
                .GenerateLandlords()
                .GenerateLocations()
                .GenerateReservations();
        }
    }
}

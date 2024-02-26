using Bogus;
using CloudBnB.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudBnB.API.Data
{
    public static class SeedingExtensionMethods
    {
        /// <summary>
        /// Generates 100 customers
        /// </summary>
        /// <returns>The modelbuilder self, to allow method-chaining</returns>
        public static ModelBuilder GenerateCustomers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Faker<Customer>()
                .RuleFor(customer => customer.Id, f => ++f.IndexVariable)
                .RuleFor(customer => customer.FirstName, f => f.Person.FirstName)
                .RuleFor(customer => customer.LastName, f => f.Person.LastName)
                .RuleFor(customer => customer.Email, f => f.Person.Email)
                .Generate(100));

            return modelBuilder;
        }

        /// <summary>
        /// Generates 100 images
        /// </summary>
        /// <returns>The modelbuilder self, to allow method-chaining</returns>
        public static ModelBuilder GenerateImages(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(new Faker<Image>()
                .RuleFor(image => image.Id, f => ++f.IndexVariable)
                .RuleFor(image => image.Url, f => f.Image.PicsumUrl())
                .RuleFor(image => image.IsCover, f => f.IndexVariable > 20)
                .Generate(100));

            return modelBuilder;
        }

        /// <summary>
        /// Generates 20 landlords
        /// </summary>
        /// <returns>The modelbuilder self, to allow method-chaining</returns>
        public static ModelBuilder GenerateLandlords(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Landlord>().HasData(new Faker<Landlord>()
                .RuleFor(landlord => landlord.Id, f => ++f.IndexVariable)
                .RuleFor(landlord => landlord.FirstName, f => f.Person.FirstName)
                .RuleFor(landlord => landlord.LastName, f => f.Person.LastName)
                .RuleFor(landlord => landlord.Age, f => f.Random.Number(18, 80))
                .RuleFor(landlord => landlord.AvatarId, f => f.IndexVariable)
                .Generate(20));

            return modelBuilder;
        }


        /// <summary>
        /// Generates 40 locations
        /// </summary>
        /// <returns>The modelbuilder self, to allow method-chaining</returns>
        public static ModelBuilder GenerateLocations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(new Faker<Location>()
                .RuleFor(location => location.Id, f => ++f.IndexVariable)
                .RuleFor(location => location.Title, f => f.Address.City())
                .RuleFor(location => location.Subtitle, f => f.Address.StreetName())
                .RuleFor(location => location.Description, f => string.Join(" ", f.Lorem.Words(8)))
                .RuleFor(location => location.LocationType, f => f.PickRandom<LocationType>())
                .RuleFor(location => location.Features, f => (LocationFeature)f.Random.Number(1, 63))
                .RuleFor(location => location.Rooms, f => f.Random.Number(1, 10))
                .RuleFor(location => location.NumberOfGuests, f => f.Random.Number(1, 20))
                .RuleFor(location => location.PricePerDay, f => f.Random.Double(99.99, 1495.99))
                .RuleFor(location => location.LandlordId, (f, e) => (e.Id + 1) / 2)
                .Generate(40));

            return modelBuilder;
        }
        
        /// <summary>
        /// Generates 120 reservations
        /// </summary>
        /// <returns>The modelbuilder self, to allow method-chaining</returns>
        public static ModelBuilder GenerateReservations(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().HasData(new Faker<Reservation>()
                .RuleFor(reservation => reservation.Id, f => ++f.IndexVariable)
                .RuleFor(reservation => reservation.LocationId, (f, e) => (e.Id + 1) / 3)
                .RuleFor(reservation => reservation.StartDate, f => f.Date.Between(DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(3)))
                .RuleFor(reservation => reservation.EndDate, f => f.Date.Between(DateTime.Now.AddMonths(-3), DateTime.Now.AddMonths(3)))
                .RuleFor(reservation => reservation.CustomerId, f => f.Random.Number(1, 100))
                .RuleFor(reservation => reservation.Discount, f => f.Random.Double() < 0.1 ? f.Random.Double(0, 10) : 0.0)
                .Generate(120));

            return modelBuilder;
        }
    }
}

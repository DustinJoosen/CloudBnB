using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBnB.API.Models
{
    public enum LocationType
    {
        Apartment,
        Cottage,
        Chalet,
        Room,
        Hotel,
        House
    }

    public class Location : IIdentifiable
    {
        public Location()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string Title { get; set; }

        [Required]
        public string Subtitle { get; set; }

        [Required, StringLength(1024)]
        public string Description { get; set; }

        [Required]
        public LocationType LocationType { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int Rooms { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int NumberOfGuests { get; set; }

        [Required, Precision(2)]
        public double PricePerDay { get; set; }

        [Required, ForeignKey(nameof(Landlord))]
        public int LandlordId { get; set; }
        public Landlord? Landlord { get; set; }


        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<LocationImage> LocationImages { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBnB.API.Models
{
    public class Reservation : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public Location Location { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }

        [Required, ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required, Precision(2)]
        public double Discount { get; set; }
    }
}
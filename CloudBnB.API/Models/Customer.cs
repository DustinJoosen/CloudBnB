using System.ComponentModel.DataAnnotations;

namespace CloudBnB.API.Models
{
    public class Customer : IIdentifiable
    {
        public Customer()
        {
            this.Reservations = new HashSet<Reservation>();    
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string FirstName { get; set; }

        [Required, StringLength(64)]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}

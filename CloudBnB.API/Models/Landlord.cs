using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBnB.API.Models
{
    public class Landlord : IIdentifiable
    {
        public Landlord()
        {
            this.Locations = new HashSet<Location>();
        }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(64)]
        public string FirstName { get; set; }

        [Required, StringLength(64)]
        public string LastName { get; set; }

        [Required, Range(0, 100)]
        public int Age { get; set; }

        [Required, ForeignKey(nameof(Avatar))]
        public int AvatarId { get; set; }
        public Image Avatar { get; set; }

        [NotMapped]
        public virtual ICollection<Location> Locations { get; set; }
    }
}

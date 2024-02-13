using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudBnB.API.Models
{
    public class LocationImage
    {
        [Key, Required, ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public Location? Location { get; set; }

        [Key, Required, ForeignKey(nameof(Image))]
        public int ImageId { get; set; }
        public Image? Image { get; set; }
    }
}

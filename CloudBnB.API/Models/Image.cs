using System.ComponentModel.DataAnnotations;

namespace CloudBnB.API.Models
{
    public class Image : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public bool IsCover { get; set; }
    }
}

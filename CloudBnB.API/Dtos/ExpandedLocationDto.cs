using CloudBnB.API.Models;

namespace CloudBnB.API.Dtos
{
    public class ExpandedLocationDto : LocationDto
    {
        public double Price { get; set; }
        public LocationType Type { get; set; }
    }
}

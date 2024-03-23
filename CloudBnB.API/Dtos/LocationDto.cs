using CloudBnB.API.Models;

namespace CloudBnB.API.Dtos
{
    public class LocationDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string LandlordAvatarURL { get; set; }
    }

    public class ExpandedLocationDto : LocationDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public LocationType Type { get; set; }
    }
}

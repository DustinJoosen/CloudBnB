using CloudBnB.API.Models;

namespace CloudBnB.API.Dtos
{
    public class DetailedLocationDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public float PricePerDay { get; set; }
        public LocationType LocationType { get; set; }
        public int Features { get; set; }
        public List<ImageDto> Images { get; set; }
        public LandlordDto Landlord { get; set; }
    }

    public class ImageDto
    {
        public string URL { get; set; }
        public bool IsCover { get; set; }
    }

    public class LandlordDto
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
    }
}

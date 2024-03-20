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
}

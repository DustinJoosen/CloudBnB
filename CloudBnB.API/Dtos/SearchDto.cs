using CloudBnB.API.Models;

namespace CloudBnB.API.Dtos
{
    public class SearchDto
    {
        public LocationFeature? Features { get; set; }
        public LocationType? Type { get; set; }
        public int? Rooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}

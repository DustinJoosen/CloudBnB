using AutoMapper;
using CloudBnB.API.Dtos;
using CloudBnB.API.Models;

namespace CloudBnB.API
{
    public class MappingProfile : Profile
    {

        private static readonly string _defaultImageUrl = "https://tinyurl.com/yckextn3";

        public MappingProfile()
        {
            CreateMap<Location, LocationDto>()
                .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src =>
                    src.Landlord.Avatar.Url ?? _defaultImageUrl))
                .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src =>
                    MapFirstLocationImage(src)));
        }


        private string MapFirstLocationImage(Location location)
        {
            if (!location.LocationImages.Any())
                return _defaultImageUrl;

            var firstLocationImage = location.LocationImages.FirstOrDefault(location => location?.Image?.IsCover ?? false);
            if (firstLocationImage == null)
                return _defaultImageUrl;

            return firstLocationImage.Image.Url;
        }

    }
}

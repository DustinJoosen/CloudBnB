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

            CreateMap<Location, ExpandedLocationDto>()
                .ForMember(dest => dest.LandlordAvatarURL, opt => opt.MapFrom(src =>
                    src.Landlord.Avatar.Url ?? _defaultImageUrl))
                .ForMember(dest => dest.ImageURL, opt => opt.MapFrom(src =>
                    MapFirstLocationImage(src)))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.PricePerDay))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.LocationType));

            CreateMap<Landlord, LandlordDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar.Url ?? _defaultImageUrl));

            CreateMap<Image, ImageDto>();

            CreateMap<Location, DetailedLocationDto>()
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.LocationImages.Select(locationImage => locationImage.Image)));

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

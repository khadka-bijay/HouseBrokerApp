using AutoMapper;
using HouseBroker.API.Models;
using HouseBroker.Infrastructure.Entities;

namespace HouseBroker.API.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Property, PropertyModel>();
            CreateMap<PropertySaveModel, Property>();
            CreateMap<PropertyImage, PropertyImageModel>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserModel>();

        }
    }
}

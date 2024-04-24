using API.Data.Entities;
using API.Services.Models.Response;
using AutoMapper;

namespace API.Infrastructre.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductResponseDM>().ReverseMap();
        }
    }
}

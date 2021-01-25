using Automapper.WebApi.DTOs;
using Automapper.WebApi.Models;
using AutoMapper;

namespace Automapper.WebApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Developer, DeveloperDTO>() //Map from Developer Object to DeveloperDTO Object
                .ForMember(dest => dest.Compensation, source => source.MapFrom(source => source.Salary)) //Specific Mapping
                .ForMember(dest => dest.IsEmployed, source => source.MapFrom(source => source.Salary > 0))//Conditional Mapping
                .ReverseMap();
            CreateMap<Address, AddressDTO>();
        }

    }
}

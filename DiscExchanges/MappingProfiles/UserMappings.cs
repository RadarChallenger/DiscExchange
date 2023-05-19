using AutoMapper;
using DiscExchanges.Dtos;
using DiscExchanges.Entities;

namespace DiscExchanges.MappingProfiles;

public class UserMappings : Profile
{
    public UserMappings()
    {
        CreateMap<UserEntity, UserDto>().ReverseMap();
        CreateMap<UserEntity, UserCreateDto>().ReverseMap();
    }
}
using AutoMapper;
using DiscExchanges.Dtos;
using DiscExchanges.Entities;

namespace DiscExchanges.MappingProfiles;

public class MovieMappings : Profile
{
    public MovieMappings()
    {
        CreateMap<MovieEntity, MovieDto>().ReverseMap();
        CreateMap<MovieEntity, MovieUpdateDto>().ReverseMap();
        CreateMap<MovieEntity, MovieCreateDto>().ReverseMap();
    }
}
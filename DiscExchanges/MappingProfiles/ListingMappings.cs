using AutoMapper;
using DiscExchanges.Dtos;
using DiscExchanges.Entities;

namespace DiscExchanges.MappingProfiles;

public class ListingMappings : Profile
{
    public ListingMappings()
    {
        CreateMap<ListingEntity, ListingDto>().ReverseMap();
        CreateMap<ListingEntity, ListingCreateDto>().ReverseMap();
    }
}
using AutoMapper;
using DiscExchanges.Dtos;
using DiscExchanges.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DiscExchanges.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ListingsController : ControllerBase
{
    private readonly IMapper _mapper;

    public ListingsController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet(Name = nameof(GetAllListings))]
    public ActionResult GetAllListings()
    {
        var listings = new List<ListingEntity>();

        return Ok(new
        {
            value = listings
        });
    }

    [HttpGet]
    [Route("{id:int}", Name = nameof(GetSingleListing))]
    public ActionResult GetSingleListing(int id)
    {
        var listing = new ListingEntity();

        return Ok(listing);
    }

    [HttpPost(Name = nameof(AddListing))]
    public ActionResult AddListing([FromBody] ListingCreateDto listingCreateDto)
    {
        var toAdd = _mapper.Map<ListingEntity>(listingCreateDto);

        return Ok(toAdd);
    }

    [HttpDelete(Name = nameof(RemoveListing))]
    public ActionResult RemoveListing(int id)
    {
        return NoContent();
    }
}
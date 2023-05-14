using AutoMapper;
using DiscExchanges.Dtos;
using DiscExchanges.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DiscExchanges.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMapper _mapper;

    public MoviesController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet(Name = nameof(GetAllMovies))]
    public ActionResult GetAllMovies()
    {
        var movieItems = new List<MovieEntity>();

        return Ok(new
        {
            value = movieItems
        });
    }

    [HttpGet]
    [Route("{id:int}", Name = nameof(GetSingleMovie))]
    public ActionResult GetSingleMovie(int id)
    {
        var movie = new MovieEntity();

        return Ok(movie);
    }

    [HttpPost(Name = nameof(AddMovie))]
    public ActionResult AddMovie([FromBody] MovieCreateDto movieCreateDto)
    {
        var toAdd = _mapper.Map<MovieEntity>(movieCreateDto);

        return Ok(toAdd);
    }

    [HttpDelete(Name = nameof(RemoveMovie))]
    public ActionResult RemoveMovie(int id)
    {
        return NoContent();
    }
}
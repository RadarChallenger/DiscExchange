using AutoMapper;
using DiscExchanges.Dtos;
using DiscExchanges.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DiscExchanges.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMapper _mapper;

    public UsersController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet(Name = nameof(GetAllUsers))]
    public ActionResult GetAllUsers()
    {
        var users = new List<UserEntity>();

        return Ok(new
        {
            value = users
        });
    }

    [HttpGet]
    [Route("{id:int}", Name = nameof(GetSingleUser))]
    public ActionResult GetSingleUser(int id)
    {
        var user = new UserEntity();

        return Ok(user);
    }

    [HttpPost(Name = nameof(AddUser))]
    public ActionResult AddUser([FromBody] UserCreateDto userCreateDto)
    {
        var toAdd = _mapper.Map<UserEntity>(userCreateDto);

        return Ok(toAdd);
    }

    [HttpDelete(Name = nameof(RemoveUser))]
    public ActionResult RemoveUser(int id)
    {
        return NoContent();
    }
}
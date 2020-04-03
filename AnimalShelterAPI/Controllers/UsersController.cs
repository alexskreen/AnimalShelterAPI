using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AnimalShelterAPI.Services;
using AnimalShelterAPI.Models;
using System.Linq;

namespace AnimalShelterAPI.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  // [ApiVersion("1.0")]

  public class UsersController : ControllerBase
  {
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    // POST /users/authenticate
    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]User userParam)
    {
      var user = _userService.Authenticate(userParam.Username, userParam.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect" });
      }
      else
      {
        return Ok(user);
      }
    }

    // GET /users
    [HttpGet]
    public IActionResult GetAll()
    {
      var users = _userService.GetAll();
      return Ok(users);
    }
  }
}
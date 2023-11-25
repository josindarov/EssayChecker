using Microsoft.AspNetCore.Mvc;

namespace EssayChecker.API.Controllers;

[ApiController]
[Route("api/controller")]
public class UserController : ControllerBase
{
    [HttpGet]
    public OkObjectResult GetHello()
    {
        return Ok("hello");
    }
}
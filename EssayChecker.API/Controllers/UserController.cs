using EssayChecker.API.Models.Users;
using EssayChecker.API.Services.Foundations.Users;
using Microsoft.AspNetCore.Mvc;

namespace EssayChecker.API.Controllers;

[ApiController]
[Route("api/controller")]
public class UserController : ControllerBase
{
    private readonly IUserService service;

    public UserController(IUserService service)
    {
        this.service = service;
    }

    [HttpPost]
    public async ValueTask<ActionResult<User>> PostUserAsync(User user)
    {
        return await service.AddUserAsync(user);
    }

    [HttpGet]
    public ActionResult<IQueryable<User>> GetAllUsers()
    {
        IQueryable<User> users = service.RetrieveAll();
        return Ok(users);   
    }

    [HttpGet("{id}")]
    public async ValueTask<ActionResult<User>> GetUserByIdAsync(Guid id)
    {
        User user = await service.RetriveUserByIdAsync(id);
        return Ok(user);
    }
}
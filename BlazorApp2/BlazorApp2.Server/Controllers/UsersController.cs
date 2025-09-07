using BlazorApp2.Application.Users.Commands.CreateUser;
using BlazorApp2.Application.Users.Commands.DeleteUser;
using BlazorApp2.Application.Users.Queries.GetUser;
using MediatR;

using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp2.Server.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get-user/{id}")]
    public async Task<IActionResult> GetUserById(Guid id)
    {
        try
        {
            var user = await _mediator.Send(new GetUserQuery(id));
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost("create-user")]
    public async Task<IActionResult> CreateUser(CreateUserCommand command)
    {
        try
        {
            var user = await _mediator.Send(command);
            return Ok(user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete("delete-user/{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        try
        {
            var user = await _mediator.Send(new DeleteUserCommand(id));
            return Ok(user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
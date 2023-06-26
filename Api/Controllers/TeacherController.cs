using Application.Commands.Users.Teachers;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Query.Queries.Users.Teachers;

namespace Api.Controllers;

[ApiController]
[Route("api/teachers")]
public class TeacherController : ControllerBase
{
    private readonly ICommandMediator _commandMediator;
    private readonly IQueryMediator _queryMediator;

    public TeacherController(ICommandMediator commandMediator, IQueryMediator queryMediator)
    {
        _commandMediator = commandMediator;
        _queryMediator = queryMediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return Ok(await _queryMediator.QueryAsync(new GetTeacherByIdQuery { Id = id }));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _queryMediator.QueryAsync(new GetTeachersQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTeacherCommand command)
    {
        return Ok(await _commandMediator.SendAsync(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateTeacherCommand command)
    {
        await _commandMediator.SendAsync(command);

        return NoContent();
    }
}
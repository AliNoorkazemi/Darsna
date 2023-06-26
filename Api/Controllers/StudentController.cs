using Application.Commands.Users.Students;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Query.Queries.Users.Students;

namespace Api.Controllers;

[ApiController]
[Route("api/students")]
public class StudentController : ControllerBase
{
    private readonly ICommandMediator _commandMediator;
    private readonly IQueryMediator _queryMediator;

    public StudentController(ICommandMediator commandMediator, IQueryMediator queryMediator)
    {
        _commandMediator = commandMediator;
        _queryMediator = queryMediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return Ok(await _queryMediator.QueryAsync(new GetStudentByIdQuery { Id = id }));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _queryMediator.QueryAsync(new GetStudentsQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateStudentCommand command)
    {
        return Ok(await _commandMediator.SendAsync(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStudentCommand command)
    {
        await _commandMediator.SendAsync(command);

        return NoContent();
    }
}
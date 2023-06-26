using Application.Commands.Classes;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Query.Queries.Classes;

namespace Api.Controllers;

[ApiController]
[Route("api/classes")]
public class ClassController : ControllerBase
{
    private readonly ICommandMediator _commandMediator;
    private readonly IQueryMediator _queryMediator;

    public ClassController(ICommandMediator commandMediator, IQueryMediator queryMediator)
    {
        _commandMediator = commandMediator;
        _queryMediator = queryMediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return Ok(await _queryMediator.QueryAsync(new GetClassByIdQuery { Id = id }));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _queryMediator.QueryAsync(new GetClassesQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateClassCommand command)
    {
        return Ok(await _commandMediator.SendAsync(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateClassCommand command)
    {
        await _commandMediator.SendAsync(command);

        return NoContent();
    }
}
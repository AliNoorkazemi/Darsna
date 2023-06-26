using Application.Commands.Lessons;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Query.Queries.Lessons;

namespace Api.Controllers;

[ApiController]
[Route("api/lessons")]
public class LessonController : ControllerBase
{
    private readonly ICommandMediator _commandMediator;
    private readonly IQueryMediator _queryMediator;

    public LessonController(ICommandMediator commandMediator, IQueryMediator queryMediator)
    {
        _commandMediator = commandMediator;
        _queryMediator = queryMediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return Ok(await _queryMediator.QueryAsync(new GetLessonByIdQuery { Id = id }));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _queryMediator.QueryAsync(new GetLessonsQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateLessonCommand command)
    {
        return Ok(await _commandMediator.SendAsync(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateLessonCommand command)
    {
        await _commandMediator.SendAsync(command);

        return NoContent();
    }
}
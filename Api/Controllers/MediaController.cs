using Application.Commands.Media;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Query.Queries.Media;

namespace Api.Controllers;

[ApiController]
[Route("api/media")]
public class MediaController : ControllerBase
{
    private readonly ICommandMediator _commandMediator;
    private readonly IQueryMediator _queryMediator;

    public MediaController(ICommandMediator commandMediator, IQueryMediator queryMediator)
    {
        _commandMediator = commandMediator;
        _queryMediator = queryMediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return Ok(await _queryMediator.QueryAsync(new GetMediaByIdQuery { Id = id }));
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _queryMediator.QueryAsync(new GetMediaQuery()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateMediaCommand command)
    {
        return Ok(await _commandMediator.SendAsync(command));
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateMediaCommand command)
    {
        await _commandMediator.SendAsync(command);

        return NoContent();
    }
}
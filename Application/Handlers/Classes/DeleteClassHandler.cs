using Application.Commands.Classes;
using Domain.Classes;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Classes;

public class DeleteClassHandler : ICommandHandler<DeleteClassCommand>
{
    private readonly IClassRepository _repository;

    public DeleteClassHandler(IClassRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(DeleteClassCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        await _repository.DeleteAsync(domain);
    }
}
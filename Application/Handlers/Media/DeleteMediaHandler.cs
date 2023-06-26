using Application.Commands.Media;
using Domain.Media;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Media;

public class DeleteMediaHandler : ICommandHandler<DeleteMediaCommand>
{
    private readonly IMediaRepository _repository;

    public DeleteMediaHandler(IMediaRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(DeleteMediaCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        await _repository.DeleteAsync(domain);
    }
}
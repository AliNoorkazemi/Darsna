using Application.Commands.Media;
using Domain.Media;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Media;

public class CreateMediaHandler : ICommandHandler<CreateMediaCommand, string>
{
    private readonly IMediaRepository _repository;

    public CreateMediaHandler(IMediaRepository repository)
    {
        _repository = repository;
    }

    public Task<string> HandleAsync(CreateMediaCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = new Domain.Media.Media(message.Url, message.Size, message.DurationTicks);

        return _repository.AddAsync(domain);
    }
}
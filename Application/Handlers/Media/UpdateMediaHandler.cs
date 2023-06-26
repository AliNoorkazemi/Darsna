using Application.Commands.Media;
using Domain.Media;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Media;

public class UpdateMediaHandler : ICommandHandler<UpdateMediaCommand>
{
    private readonly IMediaRepository _repository;

    public UpdateMediaHandler(IMediaRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(UpdateMediaCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);
        
        domain.Update(message.Url, message.Size, message.DurationTicks);

        await _repository.UpdateAsync(domain);
    }
}
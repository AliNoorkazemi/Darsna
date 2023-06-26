using Application.Commands.Classes;
using Domain.Classes;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Classes;

public class UpdateClassHandler : ICommandHandler<UpdateClassCommand>
{
    private readonly IClassRepository _repository;

    public UpdateClassHandler(IClassRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(UpdateClassCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);
        
        domain.Update(message.Name, message.TeacherId);

        await _repository.UpdateAsync(domain);
    }
}
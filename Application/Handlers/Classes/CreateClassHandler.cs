using Application.Commands.Classes;
using Domain.Classes;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Classes;

public class CreateClassHandler : ICommandHandler<CreateClassCommand, string>
{
    private readonly IClassRepository _repository;

    public CreateClassHandler(IClassRepository repository)
    {
        _repository = repository;
    }

    public Task<string> HandleAsync(CreateClassCommand message,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = new Class(message.Name, message.TeacherId);

        return _repository.AddAsync(domain);
    }
}
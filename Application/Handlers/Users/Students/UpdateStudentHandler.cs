using Application.Commands.Users.Students;
using Domain.Users;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Users.Students;

public class UpdateStudentHandler : ICommandHandler<UpdateStudentCommand>
{
    private readonly IUserRepository _repository;

    public UpdateStudentHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(UpdateStudentCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        await _repository.DeleteAsync(domain);
    }
}
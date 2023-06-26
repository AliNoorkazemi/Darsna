using Application.Commands.Users.Students;
using Domain.Users;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Users.Students;

public class DeleteStudentHandler : ICommandHandler<DeleteStudentCommand>
{
    private readonly IUserRepository _repository;

    public DeleteStudentHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(DeleteStudentCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        await _repository.DeleteAsync(domain);
    }
}
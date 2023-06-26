using Application.Commands.Users.Teachers;
using Domain.Users;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Users.Teachers;

public class DeleteTeacherHandler : ICommandHandler<DeleteTeacherCommand>
{
    private readonly IUserRepository _repository;

    public DeleteTeacherHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(DeleteTeacherCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        await _repository.DeleteAsync(domain);
    }
}
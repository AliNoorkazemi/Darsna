using Application.Commands.Users.Teachers;
using Domain.Users;
using Domain.Users.Teachers;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Users.Teachers;

public class CreateTeacherHandler : ICommandHandler<CreateTeacherCommand, string>
{
    private readonly IUserRepository _repository;

    public CreateTeacherHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<string> HandleAsync(CreateTeacherCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = new Teacher(message.UserName,
            message.Email,
            message.Password,
            message.Name,
            message.ClassIds);

        return _repository.AddAsync(domain);
    }
}
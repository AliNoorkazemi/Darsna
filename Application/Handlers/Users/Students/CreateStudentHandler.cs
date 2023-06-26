using Application.Commands.Users.Students;
using Domain.Users;
using Domain.Users.Students;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Users.Students;

public class CreateStudentHandler : ICommandHandler<CreateStudentCommand, string>
{
    private readonly IUserRepository _repository;

    public CreateStudentHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<string> HandleAsync(CreateStudentCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = new Student(message.UserName, 
            message.Email, 
            message.Password, 
            message.Name, 
            message.FavoriteClassIds);

        return _repository.AddAsync(domain);
    }
}
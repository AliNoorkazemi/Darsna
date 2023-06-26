using Application.Commands.Users.Students;
using Domain.Users;
using Domain.Users.Students;
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
        var domain = await _repository.GetByIdAsync<Student>(message.Id);

        domain.Update(message.UserName, 
            message.Email,
            message.Password,
            message.Name,
            message.FavoriteClassIds);

        await _repository.UpdateAsync(domain);
    }
}
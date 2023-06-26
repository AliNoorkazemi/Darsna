using Application.Commands.Users.Teachers;
using Domain.Users;
using Domain.Users.Teachers;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Users.Teachers;

public class UpdateTeacherHandler : ICommandHandler<UpdateTeacherCommand>
{
    private readonly IUserRepository _repository;

    public UpdateTeacherHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task HandleAsync(UpdateTeacherCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync<Teacher>(message.Id);
        
        domain.Update(message.UserName, 
            message.Email,
            message.Password,
            message.Name,
            message.ClassIds);

        await _repository.UpdateAsync(domain);
    }
}
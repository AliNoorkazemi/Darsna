using LiteBus.Commands.Abstractions;

namespace Application.Commands.Users;

public abstract class CreateUserCommand : ICommand<string>
{
    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }
}
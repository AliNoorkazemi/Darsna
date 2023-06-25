using LiteBus.Commands.Abstractions;

namespace Application.Commands.Users;

public abstract class UpdateUserCommand : ICommand
{
    public string Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }
}
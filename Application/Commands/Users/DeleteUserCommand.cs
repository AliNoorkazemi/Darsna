using LiteBus.Commands.Abstractions;

namespace Application.Commands.Users;

public abstract class DeleteUserCommand : ICommand
{
    public string Id { get; set; }
}
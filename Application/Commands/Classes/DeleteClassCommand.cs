using LiteBus.Commands.Abstractions;

namespace Application.Commands.Classes;

public class DeleteClassCommand : ICommand
{
    public string Id { get; set; }
}
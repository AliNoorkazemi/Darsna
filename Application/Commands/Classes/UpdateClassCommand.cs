using LiteBus.Commands.Abstractions;

namespace Application.Commands.Classes;

public class UpdateClassCommand : ICommand
{
    public string Id { get; set; }
    
    public string Name { get; set; }

    public string TeacherId { get; set; }
}
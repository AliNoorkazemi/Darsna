using LiteBus.Commands.Abstractions;

namespace Application.Commands.Classes;

public class CreateClassCommand : ICommand<string>
{
    public string Name { get; set; }

    public string TeacherId { get; set; }
}
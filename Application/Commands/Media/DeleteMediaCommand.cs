using LiteBus.Commands.Abstractions;

namespace Application.Commands.Media;

public class DeleteMediaCommand : ICommand
{
    public string Id { get; set; }
}
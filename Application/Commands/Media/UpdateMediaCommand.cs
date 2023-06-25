using LiteBus.Commands.Abstractions;

namespace Application.Commands.Media;

public class UpdateMediaCommand : ICommand
{
    public string Id { get; set; }

    public string Url { get; set; }

    public int Size { get; set; }

    public long DurationTicks { get; set; }
}
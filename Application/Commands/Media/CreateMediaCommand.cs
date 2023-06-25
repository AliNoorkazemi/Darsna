using LiteBus.Commands.Abstractions;

namespace Application.Commands.Media;

public class CreateMediaCommand : ICommand<string>
{
    public string Url { get; set; }

    public int Size { get; set; }

    public long DurationTicks { get; set; }
}
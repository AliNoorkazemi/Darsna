using LiteBus.Commands.Abstractions;

namespace Application.Commands.Lessons;

public class UpdateLessonCommand : ICommand
{
    public string Id { get; set; }

    public string Note { get; set; }

    public string MediaId { get; set; }

    public string ClassId { get; set; }
}
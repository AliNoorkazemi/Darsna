using LiteBus.Commands.Abstractions;

namespace Application.Commands.Lessons;

public class CreateLessonCommand : ICommand<string>
{
    public string Note { get; set; }

    public string MediaId { get; set; }

    public string ClassId { get; set; }
}
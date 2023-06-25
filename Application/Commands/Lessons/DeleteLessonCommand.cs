using LiteBus.Commands.Abstractions;

namespace Application.Commands.Lessons;

public class DeleteLessonCommand : ICommand
{
    public string Id { get; set; }
}
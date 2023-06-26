using Application.Commands.Lessons;
using Domain.Lessons;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Lessons;

public class CreateLessonHandler : ICommandHandler<CreateLessonCommand, string>
{
    private readonly ILessonRepository _repository;

    public CreateLessonHandler(ILessonRepository repository)
    {
        _repository = repository;
    }

    public Task<string> HandleAsync(CreateLessonCommand message,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = new Lesson(message.Note, message.MediaId, message.ClassId);

        return _repository.AddAsync(domain);
    }
}
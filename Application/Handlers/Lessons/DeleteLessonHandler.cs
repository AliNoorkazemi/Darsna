using Application.Commands.Lessons;
using Domain.Lessons;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Lessons;

public class DeleteLessonHandler : ICommandHandler<DeleteLessonCommand>
{
    private readonly ILessonRepository _repository;

    public DeleteLessonHandler(ILessonRepository repository)
    {
        _repository = repository;
    }

    public Task HandleAsync(DeleteLessonCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        
    }
}
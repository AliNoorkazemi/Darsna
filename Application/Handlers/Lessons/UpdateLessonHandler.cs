using Application.Commands.Lessons;
using Domain.Lessons;
using LiteBus.Commands.Abstractions;

namespace Application.Handlers.Lessons;

public class UpdateLessonHandler : ICommandHandler<UpdateLessonCommand>
{
    private readonly ILessonRepository _repository;

    public UpdateLessonHandler(ILessonRepository repository)
    {
        _repository = repository;
    }

    public Task HandleAsync(UpdateLessonCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        
    }
}
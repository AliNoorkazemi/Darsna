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

    public async Task HandleAsync(DeleteLessonCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        await _repository.DeleteAsync(domain);
    }
}
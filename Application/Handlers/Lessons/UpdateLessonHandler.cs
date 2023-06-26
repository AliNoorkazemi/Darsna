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

    public async Task HandleAsync(UpdateLessonCommand message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);
        
        domain.Update(message.Note, message.MediaId, message.ClassId);

        await _repository.UpdateAsync(domain);
    }
}
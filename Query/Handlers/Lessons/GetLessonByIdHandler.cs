using Domain.Lessons;
using LiteBus.Queries.Abstractions;
using Query.Queries.Lessons;
using Query.QueryModels.Lessons;

namespace Query.Handlers.Lessons;

public class GetLessonByIdHandler : IQueryHandler<GetLessonByIdQuery, LessonQueryModel>
{
    private readonly ILessonRepository _repository;

    public GetLessonByIdHandler(ILessonRepository repository)
    {
        _repository = repository;
    }

    public async Task<LessonQueryModel> HandleAsync(GetLessonByIdQuery message,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        return new LessonQueryModel
        {
            Id = domain.Id,
            Note = domain.Note,
            ClassId = domain.ClassId,
            CreatedAt = domain.CreatedAt,
            MediaId = domain.MediaId
        };
    }
}
using Domain.Lessons;
using LiteBus.Queries.Abstractions;
using Query.Queries.Lessons;
using Query.QueryModels.Lessons;

namespace Query.Handlers.Lessons;

public class GetLessonsHandler : IQueryHandler<GetLessonsQuery, IReadOnlyCollection<LessonListQueryModel>>
{
    private readonly ILessonRepository _repository;

    public GetLessonsHandler(ILessonRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<LessonListQueryModel>> HandleAsync(GetLessonsQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domains = await _repository.GetAllAsync();

        return domains.Select(domain => new LessonListQueryModel
        {
            Id = domain.Id,
            Note = domain.Note
        }).ToList();
    }
}
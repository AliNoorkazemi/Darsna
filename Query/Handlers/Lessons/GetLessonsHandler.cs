using LiteBus.Queries.Abstractions;
using Query.Queries.Lessons;
using Query.QueryModels.Lessons;

namespace Query.Handlers.Lessons;

public class GetLessonsHandler : IQueryHandler<GetLessonsQuery, IReadOnlyCollection<LessonListQueryModel>>
{
    public Task<IReadOnlyCollection<LessonListQueryModel>> HandleAsync(GetLessonsQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
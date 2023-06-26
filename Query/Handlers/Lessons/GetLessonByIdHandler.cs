using LiteBus.Queries.Abstractions;
using Query.Queries.Lessons;
using Query.QueryModels.Lessons;

namespace Query.Handlers.Lessons;

public class GetLessonByIdHandler : IQueryHandler<GetLessonByIdQuery, LessonQueryModel>
{
    public Task<LessonQueryModel> HandleAsync(GetLessonByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
using LiteBus.Queries.Abstractions;
using Query.QueryModels.Lessons;

namespace Query.Queries.Lessons;

public class GetLessonByIdQuery : IQuery<LessonQueryModel>
{
    public string Id { get; set; }
}
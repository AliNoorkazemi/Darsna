using LiteBus.Queries.Abstractions;
using Query.QueryModels.Users.Teachers;

namespace Query.Queries.Users.Teachers;

public class GetTeacherByIdQuery : IQuery<TeacherQueryModel>
{
    public string Id { get; set; }
}
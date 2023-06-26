using LiteBus.Queries.Abstractions;
using Query.QueryModels.Users.Students;

namespace Query.Queries.Users.Students;

public class GetStudentByIdQuery : IQuery<StudentQueryModel>
{
    public string Id { get; set; }
}
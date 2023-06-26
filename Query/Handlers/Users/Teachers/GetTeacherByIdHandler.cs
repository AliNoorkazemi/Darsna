using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Teachers;
using Query.QueryModels.Users.Teachers;

namespace Query.Handlers.Users.Teachers;

public class GetTeacherByIdHandler : IQueryHandler<GetTeacherByIdQuery, TeacherQueryModel>
{
    public Task<TeacherQueryModel> HandleAsync(GetTeacherByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
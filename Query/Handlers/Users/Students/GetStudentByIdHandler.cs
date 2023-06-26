using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Students;
using Query.QueryModels.Users.Students;

namespace Query.Handlers.Users.Students;

public class GetStudentByIdHandler : IQueryHandler<GetStudentByIdQuery, StudentQueryModel>
{
    public Task<StudentQueryModel> HandleAsync(GetStudentByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
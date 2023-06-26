using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Students;
using Query.QueryModels.Users.Students;

namespace Query.Handlers.Users.Students;

public class GetStudentsHandler : IQueryHandler<GetStudentsQuery, IReadOnlyCollection<StudentListQueryModel>>
{
    public Task<IReadOnlyCollection<StudentListQueryModel>> HandleAsync(GetStudentsQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
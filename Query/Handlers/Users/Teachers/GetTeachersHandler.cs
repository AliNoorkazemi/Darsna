using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Teachers;
using Query.QueryModels.Users.Teachers;

namespace Query.Handlers.Users.Teachers;

public class GetTeachersHandler : IQueryHandler<GetTeachersQuery, IReadOnlyCollection<TeacherListQueryModel>>
{
    public Task<IReadOnlyCollection<TeacherListQueryModel>> HandleAsync(GetTeachersQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
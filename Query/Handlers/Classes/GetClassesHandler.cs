using LiteBus.Queries.Abstractions;
using Query.Queries.Classes;
using Query.QueryModels.Classes;

namespace Query.Handlers.Classes;

public class GetClassesHandler : IQueryHandler<GetClassesQuery, IReadOnlyCollection<ClassListQueryModel>>
{
    public Task<IReadOnlyCollection<ClassListQueryModel>> HandleAsync(GetClassesQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
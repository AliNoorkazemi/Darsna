using LiteBus.Queries.Abstractions;
using Query.Queries.Classes;
using Query.QueryModels.Classes;

namespace Query.Handlers.Classes;

public class GetClassByIdHandler : IQueryHandler<GetClassByIdQuery, ClassQueryModel>
{
    public Task<ClassQueryModel> HandleAsync(GetClassByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
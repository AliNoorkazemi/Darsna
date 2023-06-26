using LiteBus.Queries.Abstractions;
using Query.Queries.Media;
using Query.QueryModels.Media;

namespace Query.Handlers.Media;

public class GetMediaByIdHandler : IQueryHandler<GetMediaByIdQuery, MediaQueryModel>
{
    public Task<MediaQueryModel> HandleAsync(GetMediaByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
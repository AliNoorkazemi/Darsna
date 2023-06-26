using LiteBus.Queries.Abstractions;
using Query.Queries.Media;
using Query.QueryModels.Media;

namespace Query.Handlers.Media;

public class GetMediaHandler : IQueryHandler<GetMediaQuery, IReadOnlyCollection<MediaListQueryModel>>
{
    public Task<IReadOnlyCollection<MediaListQueryModel>> HandleAsync(GetMediaQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
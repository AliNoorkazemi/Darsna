using Domain.Media;
using LiteBus.Queries.Abstractions;
using Query.Queries.Media;
using Query.QueryModels.Media;

namespace Query.Handlers.Media;

public class GetMediaHandler : IQueryHandler<GetMediaQuery, IReadOnlyCollection<MediaListQueryModel>>
{
    private readonly IMediaRepository _repository;

    public GetMediaHandler(IMediaRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<MediaListQueryModel>> HandleAsync(GetMediaQuery message,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var domains = await _repository.GetAllAsync();

        return domains.Select(domain => new MediaListQueryModel
        {
            Id = domain.Id,
            Url = domain.Url
        }).ToList();
    }
}
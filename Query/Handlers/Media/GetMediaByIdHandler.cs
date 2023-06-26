using Domain.Media;
using LiteBus.Queries.Abstractions;
using Query.Queries.Media;
using Query.QueryModels.Media;

namespace Query.Handlers.Media;

public class GetMediaByIdHandler : IQueryHandler<GetMediaByIdQuery, MediaQueryModel>
{
    private readonly IMediaRepository _repository;

    public GetMediaByIdHandler(IMediaRepository repository)
    {
        _repository = repository;
    }

    public async Task<MediaQueryModel> HandleAsync(GetMediaByIdQuery message,
        CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        return new MediaQueryModel
        {
            Id = domain.Id,
            CreatedAt = domain.CreatedAt,
            Url = domain.Url,
            Size = domain.Size,
            DurationTicks = domain.DurationTicks
        };
    }
}
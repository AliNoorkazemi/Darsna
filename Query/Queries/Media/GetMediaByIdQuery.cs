using LiteBus.Queries.Abstractions;
using Query.QueryModels.Media;

namespace Query.Queries.Media;

public class GetMediaByIdQuery : IQuery<MediaQueryModel>
{
    public string Id { get; set; }
}
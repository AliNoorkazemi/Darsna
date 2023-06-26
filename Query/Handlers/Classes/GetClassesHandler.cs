using Domain.Classes;
using LiteBus.Queries.Abstractions;
using Query.Queries.Classes;
using Query.QueryModels.Classes;

namespace Query.Handlers.Classes;

public class GetClassesHandler : IQueryHandler<GetClassesQuery, IReadOnlyCollection<ClassListQueryModel>>
{
    private readonly IClassRepository _repository;

    public GetClassesHandler(IClassRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<ClassListQueryModel>> HandleAsync(GetClassesQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domains = await _repository.GetAllAsync();

        return domains.Select(domain => new ClassListQueryModel
        {
            Id = domain.Id,
            Name = domain.Name
        }).ToList();
    }
}
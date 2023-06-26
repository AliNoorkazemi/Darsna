using Domain.Classes;
using LiteBus.Queries.Abstractions;
using Query.Queries.Classes;
using Query.QueryModels.Classes;

namespace Query.Handlers.Classes;

public class GetClassByIdHandler : IQueryHandler<GetClassByIdQuery, ClassQueryModel>
{
    private readonly IClassRepository _repository;

    public GetClassByIdHandler(IClassRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClassQueryModel> HandleAsync(GetClassByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync(message.Id);

        return new ClassQueryModel
        {
            Id = domain.Id,
            Name = domain.Name,
            TeacherId = domain.TeacherId
        };
    }
}
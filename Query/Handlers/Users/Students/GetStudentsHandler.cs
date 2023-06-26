using Domain.Users;
using Domain.Users.Students;
using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Students;
using Query.QueryModels.Users.Students;

namespace Query.Handlers.Users.Students;

public class GetStudentsHandler : IQueryHandler<GetStudentsQuery, IReadOnlyCollection<StudentListQueryModel>>
{
    private readonly IUserRepository _repository;

    public GetStudentsHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<StudentListQueryModel>> HandleAsync(GetStudentsQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domains = await _repository.GetAllAsync<Student>();

        return domains.Select(domain => new StudentListQueryModel
        {
            Id = domain.Id,
            UserName = domain.UserName,
            Email = domain.Email,
            Name = domain.Name,
        }).ToList();
    }
}
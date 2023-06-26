using Domain.Users;
using Domain.Users.Teachers;
using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Teachers;
using Query.QueryModels.Users.Teachers;

namespace Query.Handlers.Users.Teachers;

public class GetTeachersHandler : IQueryHandler<GetTeachersQuery, IReadOnlyCollection<TeacherListQueryModel>>
{
    private readonly IUserRepository _repository;

    public GetTeachersHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyCollection<TeacherListQueryModel>> HandleAsync(GetTeachersQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domains = await _repository.GetAllAsync<Teacher>();

        return domains.Select(domain => new TeacherListQueryModel
        {
            Id = domain.Id,
            UserName = domain.UserName,
            Email = domain.Email,
            Name = domain.Name,
        }).ToList();
    }
}
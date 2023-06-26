using Domain.Users;
using Domain.Users.Students;
using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Students;
using Query.QueryModels.Users.Students;

namespace Query.Handlers.Users.Students;

public class GetStudentByIdHandler : IQueryHandler<GetStudentByIdQuery, StudentQueryModel>
{
    private readonly IUserRepository _repository;

    public GetStudentByIdHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<StudentQueryModel> HandleAsync(GetStudentByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync<Student>(message.Id);

        return new StudentQueryModel
        {
            Id = domain.Id,
            UserName = domain.UserName,
            Email = domain.Email,
            Password = domain.Password,
            Name = domain.Name,
            FavoriteClassIds = domain.FavoriteClassIds
        };
    }
}
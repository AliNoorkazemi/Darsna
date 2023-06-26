using Domain.Users;
using Domain.Users.Teachers;
using LiteBus.Queries.Abstractions;
using Query.Queries.Users.Teachers;
using Query.QueryModels.Users.Teachers;

namespace Query.Handlers.Users.Teachers;

public class GetTeacherByIdHandler : IQueryHandler<GetTeacherByIdQuery, TeacherQueryModel>
{
    private readonly IUserRepository _repository;

    public GetTeacherByIdHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<TeacherQueryModel> HandleAsync(GetTeacherByIdQuery message, CancellationToken cancellationToken = new CancellationToken())
    {
        var domain = await _repository.GetByIdAsync<Teacher>(message.Id);

        return new TeacherQueryModel
        {
            Id = domain.Id,
            UserName = domain.UserName,
            Email = domain.Email,
            Password = domain.Password,
            Name = domain.Name,
            ClassIds = domain.ClassIds
        };
    }
}
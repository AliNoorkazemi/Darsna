using Domain.Users;
using Persistence.Repositories.Shared;

namespace Persistence.Repositories.Users;

public class UserRepository : RepositoryBase<User, string> , IUserRepository
{
    public UserRepository(IMongoConnection mongoConnection) : base(mongoConnection)
    {
    }
}
using Domain.Classes;
using Persistence.Repositories.Shared;

namespace Persistence.Repositories.Classes;

public class ClassRepository : RepositoryBase<Class, string> , IClassRepository
{
    public ClassRepository(IMongoConnection mongoConnection) : base(mongoConnection)
    {
    }
}
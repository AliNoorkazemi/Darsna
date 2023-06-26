using Domain.Media;
using Persistence.Repositories.Shared;

namespace Persistence.Repositories.Media;

public class MediaRepository : RepositoryBase<Domain.Media.Media, string> , IMediaRepository
{
    public MediaRepository(IMongoConnection mongoConnection) : base(mongoConnection)
    {
    }
}
using Domain.Lessons;
using Persistence.Repositories.Shared;

namespace Persistence.Repositories.Lessons;

public class LessonRepository : RepositoryBase<Lesson, string> , ILessonRepository
{
    public LessonRepository(IMongoConnection mongoConnection) : base(mongoConnection)
    {
    }
}
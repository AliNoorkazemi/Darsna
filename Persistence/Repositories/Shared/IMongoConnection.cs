using MongoDB.Driver;

namespace Persistence.Repositories.Shared;

public interface IMongoConnection
{
    IMongoCollection<TDocument> GetCollection<TDocument>(string name = default);
}
using Humanizer;
using MongoDB.Driver;

namespace Persistence.Repositories.Shared;

public class MonoConnection : IMongoConnection
{
    private readonly IMongoDatabase _database;
    
    public MonoConnection(MongoConnectionOptions mongoConnectionOptions)
    {
        var client = CreateMongoClient(mongoConnectionOptions);

        _database = client.GetDatabase(mongoConnectionOptions.DatabaseName);
    }

    public IMongoCollection<TDocument> GetCollection<TDocument>(string name = default)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            name = typeof(TDocument).Name.Pluralize();
        }

        return _database.GetCollection<TDocument>(name);
    }
    
    private static MongoClient CreateMongoClient(MongoConnectionOptions options)
    {
        var mongoClientSettings = MongoClientSettings.FromConnectionString(options.ConnectionString);

        return new MongoClient(mongoClientSettings);
    }
}
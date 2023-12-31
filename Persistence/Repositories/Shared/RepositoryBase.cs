﻿using Domain.Shared;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Persistence.Repositories.Shared;

public class RepositoryBase<T, TKey> : IRepositoryBase<T, TKey> where T : Domain<TKey>
{
    private readonly IMongoCollection<T> _collection;

    public RepositoryBase(IMongoConnection mongoConnection)
    {
        _collection = mongoConnection.GetCollection<T>();
    }

    public async Task<TKey> AddAsync(T domain)
    {
        if (domain is Domain<string> stringIdDomain)
        {
            stringIdDomain.SetId(ObjectId.GenerateNewId().ToString());
        }
        
        await _collection.InsertOneAsync(domain);

        return domain.Id;
    }

    public Task UpdateAsync(T domain)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T domain)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(TKey key)
    {
        throw new NotImplementedException();
    }

    public Task<TDerived> GetByIdAsync<TDerived>(TKey key) where TDerived : T
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<TDerived>> GetAllAsync<TDerived>() where TDerived : T
    {
        throw new NotImplementedException();
    }
}
﻿using Domain.Shared;
using MongoDB.Driver;

namespace Persistence.Repositories.Shared;

public class RepositoryBase<T, TKey> : IRepositoryBase<T, TKey>
{
    private readonly IMongoCollection<T> _collection;

    public RepositoryBase(IMongoConnection mongoConnection)
    {
        _collection = mongoConnection.GetCollection<T>();
    }

    public Task<TKey> AddAsync(T domain)
    {
        throw new NotImplementedException();
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
}
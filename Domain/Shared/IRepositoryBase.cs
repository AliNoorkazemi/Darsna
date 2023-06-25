namespace Domain.Shared;

public interface IRepositoryBase<T, TKey>
{
    Task<TKey> AddAsync(T domain);

    Task UpdateAsync(T domain);

    Task DeleteAsync(T domain);

    Task<T> GetByIdAsync(TKey key);
}
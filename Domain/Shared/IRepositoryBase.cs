namespace Domain.Shared;

public interface IRepositoryBase<T, TKey>
{
    Task<TKey> AddAsync(T domain);

    Task UpdateAsync(T domain);

    Task DeleteAsync(T domain);

    Task<T> GetByIdAsync(TKey key);

    Task<TDerived> GetByIdAsync<TDerived>(TKey key) where TDerived : T;

    Task<IReadOnlyCollection<T>> GetAllAsync();

    Task<IReadOnlyCollection<TDerived>> GetAllAsync<TDerived>() where TDerived : T;
}
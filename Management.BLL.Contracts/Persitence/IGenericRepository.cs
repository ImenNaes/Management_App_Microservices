namespace Management.BLL.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T?> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}

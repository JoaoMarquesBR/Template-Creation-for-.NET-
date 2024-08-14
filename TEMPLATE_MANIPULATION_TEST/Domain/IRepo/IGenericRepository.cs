namespace Domain.IRepo
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task DeleteById(int id);
        Task Update(int id, T entity);
    }
}

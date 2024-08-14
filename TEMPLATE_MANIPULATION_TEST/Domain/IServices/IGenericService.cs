namespace Domain.IServices
{
    public interface IGenericService<T> 
    {
        Task Add(T entity);
        Task <IEnumerable<T>> GetAll();
        Task Delete(int id);
        Task Update(int id, T entity);
    }
}

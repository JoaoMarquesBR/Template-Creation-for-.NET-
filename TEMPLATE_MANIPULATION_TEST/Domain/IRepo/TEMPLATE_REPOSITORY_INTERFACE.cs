using Domain.Entities;

namespace Domain.IRepo
{
    public interface TEMPLATE_ENTITY_REPOSITORY_INTERFACE<T> : IGenericRepository<TEMPLATE_ENTITY_CLASS> where T : class
    {

    }
}

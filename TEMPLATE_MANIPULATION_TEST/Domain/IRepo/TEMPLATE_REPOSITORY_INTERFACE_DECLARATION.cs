using Domain.Entities;

namespace Domain.IRepo
{
    public interface TEMPLATE_REPOSITORY_INTERFACE_DECLARATION<T> : IGenericRepository<TEMPLATE_ENTITY_CLASS> where T : class
    {

    }
}

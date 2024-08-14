using Domain.Entities;
using Domain.IRepo;
using Domain.IServices;

namespace Application.Services
{
    public class TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION : TEMPLATE_ENTITY_SERVICE_INTERFACE<TEMPLATE_ENTITY_CLASS>
    {
        private readonly TEMPLATE_ENTITY_REPOSITORY_INTERFACE<TEMPLATE_ENTITY_CLASS> TEMPLATE_REPOSITORY_INTERFACE_CLASS;

        public TEMPLATE_ENTITY_SERVICE_INTERFACE_DECLARATION(TEMPLATE_ENTITY_REPOSITORY_INTERFACE<TEMPLATE_ENTITY_CLASS> TEMPLATE_REPOSITORY_INTERFACE_CONSTRUCTOR)
        {
            TEMPLATE_REPOSITORY_INTERFACE_CLASS = TEMPLATE_REPOSITORY_INTERFACE_CONSTRUCTOR;
        }

        public async Task Add(TEMPLATE_ENTITY_CLASS entity)
        {
            await TEMPLATE_REPOSITORY_INTERFACE_CLASS.Add(entity);
        }

        public async Task Delete(int id)
        {
            if (await TEMPLATE_REPOSITORY_INTERFACE_CLASS.GetById(id) == null)
            {
                throw new Exception("Entity ID does not exist");
            }

            await TEMPLATE_REPOSITORY_INTERFACE_CLASS.DeleteById(id);
        }

        public async Task<IEnumerable<TEMPLATE_ENTITY_CLASS>> GetAll()
        {
            return await TEMPLATE_REPOSITORY_INTERFACE_CLASS.GetAll();
        }

        public async Task Update(int id, TEMPLATE_ENTITY_CLASS entity)
        {
            if (await TEMPLATE_REPOSITORY_INTERFACE_CLASS.GetById(id) == null) {
                throw new Exception("Entity ID does not exist");
            }

            await TEMPLATE_REPOSITORY_INTERFACE_CLASS.Update(id, entity);
        }
    }
}

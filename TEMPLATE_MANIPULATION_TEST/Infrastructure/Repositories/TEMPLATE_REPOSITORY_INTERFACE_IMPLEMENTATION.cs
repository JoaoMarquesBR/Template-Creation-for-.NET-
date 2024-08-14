using Domain.Entities;
using Domain.IRepo;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TEMPLATE_REPOSITORY_INTERFACE_IMPLEMENTATION : TEMPLATE_ENTITY_REPOSITORY_INTERFACE<TEMPLATE_ENTITY_CLASS>
    {
        private readonly DatabaseContext _databaseContext;

        public TEMPLATE_REPOSITORY_INTERFACE_IMPLEMENTATION(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task Add(TEMPLATE_ENTITY_CLASS entity)
        {
            try
            {
                await _databaseContext.AddAsync(entity);
                await _databaseContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task DeleteById(int id)
        {
            var user = await _databaseContext.TEMPLATE_ENTITY_CLASS.FirstOrDefaultAsync(x => x.EndUserId == id);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            _databaseContext.TEMPLATE_ENTITY_CLASS.Remove(user);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEMPLATE_ENTITY_CLASS>> GetAll()
        {
            return await _databaseContext.TEMPLATE_ENTITY_CLASS.ToListAsync();
        }

        public async Task<TEMPLATE_ENTITY_CLASS> GetById(int id)
        {
            return await _databaseContext.TEMPLATE_ENTITY_CLASS.FirstOrDefaultAsync(x => x.EndUserId.Equals(id));
        }

        public async Task Update(int id, TEMPLATE_ENTITY_CLASS entity)
        {
            var user = await _databaseContext.TEMPLATE_ENTITY_CLASS.FirstOrDefaultAsync(x => x.EndUserId == id);
            user.FirstName = entity.FirstName;
            user.LastName = entity.LastName;
            user.UserEmail = entity.UserEmail;

            _databaseContext.TEMPLATE_ENTITY_CLASS.Update(user);
            await _databaseContext.SaveChangesAsync();
        }
    }
}

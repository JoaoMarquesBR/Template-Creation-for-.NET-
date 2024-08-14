using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public virtual DbSet<TEMPLATE_ENTITY_CLASS> TEMPLATE_ENTITY_CLASS { get; set; }

    }
}

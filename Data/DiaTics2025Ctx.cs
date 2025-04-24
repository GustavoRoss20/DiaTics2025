using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DiaTics2025Ctx : DbContext
    {
        public DiaTics2025Ctx(DbContextOptions<DiaTics2025Ctx> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}

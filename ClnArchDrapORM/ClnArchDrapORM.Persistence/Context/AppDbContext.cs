using Microsoft.EntityFrameworkCore;
using ClnArchDrapORM.Domain.Entities;

namespace ClnArchDrapORM.Persistence.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();

        public DbSet<Category> Categories => Set<Category>();

        protected AppDbContext()
        {
        }
    }
}

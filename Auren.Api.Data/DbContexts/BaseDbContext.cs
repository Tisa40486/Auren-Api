using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Auren.Data.Model;

namespace Auren.Data.DbContexts
{
    public class BaseDbContext<TContext> : DbContext, IBaseDbContext where TContext : DbContext
    {
        public BaseDbContext(DbContextOptions<TContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public new EntityEntry<TModelDao> Entry<TModelDao>(TModelDao entry) where TModelDao : class, IModelDao
        {
            return base.Entry(entry);
        }
    }
}
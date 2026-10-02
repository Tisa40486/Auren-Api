using Auren.Db.DbContexts;
using Auren.Db.Repository;

namespace Auren.Db.UnitOfWork
{
    public class AurenApiUnitOfWork : IAurenApiUnitOfWork
    {
        public IAurenApiDbContext Context { get; }
        public IAurenRepository AurenRepository { get; }

        public AurenApiUnitOfWork(
            IAurenApiDbContext context, 
            IAurenRepository aurenRepository)
        {
            Context = context;
            AurenRepository = aurenRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
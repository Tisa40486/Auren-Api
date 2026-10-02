using Auren.Db.DbContexts;
using Auren.Db.Repository;

namespace Auren.Db.UnitOfWork
{
    public interface IAurenApiUnitOfWork
    {
        IAurenApiDbContext Context { get; }
        IAurenRepository AurenRepository { get; }
        Task<int> SaveChangesAsync();
    }   
}
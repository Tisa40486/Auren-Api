using Auren.Api.Db.Repository;
using Auren.Db.DbContexts;

namespace Auren.Api.Db.UnitOfWork
{
    public interface IAurenApiUnitOfWork
    {
        IAurenApiDbContext Context { get; }
        IBankAccountRepository BankAccountRepository { get; }
        Task<int> SaveChangesAsync();
    }   
}
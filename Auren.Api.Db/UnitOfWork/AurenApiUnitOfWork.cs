using Auren.Api.Db.Repository;
using Auren.Db.DbContexts;

namespace Auren.Api.Db.UnitOfWork
{
    public class AurenApiUnitOfWork : IAurenApiUnitOfWork
    {
        public IAurenApiDbContext Context { get; }
        public IBankAccountRepository BankAccountRepository { get; }

        public AurenApiUnitOfWork(
            IAurenApiDbContext context, 
            IBankAccountRepository bankAccountRepository)
        {
            Context = context;
            BankAccountRepository = bankAccountRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await Context.SaveChangesAsync();
        }
    }
}
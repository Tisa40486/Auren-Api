using Auren.Api.Data.Repository;
using Auren.Api.Model;
using Auren.Db.DbContexts;

namespace Auren.Api.Db.Repository
{
    public interface IBankAccountRepository : IBaseRepository<IAurenApiDbContext, BankAccountDao>
    {

    }
}
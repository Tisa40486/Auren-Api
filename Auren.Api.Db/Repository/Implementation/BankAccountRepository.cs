using Auren.Api.Data.Model;
using Auren.Api.Data.Repository;
using Auren.Api.Model;
using Auren.Data.DbContexts;
using Auren.Db.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Auren.Api.Db.Repository.Implementation
{
    public class BankAccountRepository : BaseRepository<IAurenApiDbContext, BankAccountDao>, IBankAccountRepository
    {
        private readonly IAurenApiDbContext _aurenApiDbContext;

        public BankAccountRepository(IAurenApiDbContext context) : base(context)
        {
            _aurenApiDbContext = context;
        }
    }
}
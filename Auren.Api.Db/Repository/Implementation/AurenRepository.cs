using Auren.Api.Model;
using Auren.Data.Repository;
using Auren.Db.DbContexts;

namespace Auren.Db.Repository.Implementation
{
    public class AurenRepository : BaseRepository<IAurenApiDbContext, BankAccountDao>, Repository.IAurenRepository
    {
        private readonly IAurenApiDbContext _templateApiDbContext;
        public AurenRepository(IAurenApiDbContext context) : base(context)
        {
            _templateApiDbContext = context;
        }
    }
}
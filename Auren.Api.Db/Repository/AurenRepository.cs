using Auren.Api.Model;
using Auren.Db.DbContexts;

using Auren.Data.Repository;

namespace Auren.Db.Repository
{
    public interface IAurenRepository : IBaseRepository<IAurenApiDbContext, BankAccountDao>
    {
        public IAurenApiDbContext _context => throw new NotImplementedException();

        public Task AddAndSaveAsync(BankAccountDao entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BankAccountDao>> GetAllAsync(bool withNoTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task<BankAccountDao?> GetByIdAsync(int id, bool withNoTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(BankAccountDao entity)
        {
            throw new NotImplementedException();
        }

        public Task RemoveByIdAsync(int id, bool withNoTracking = true)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(BankAccountDao entity)
        {
            throw new NotImplementedException();
        }
    }
}
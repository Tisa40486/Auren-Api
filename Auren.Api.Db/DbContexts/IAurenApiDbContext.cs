using Auren.Api.Model;
using Auren.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Auren.Db.DbContexts
{
    public interface IAurenApiDbContext : IBaseDbContext
    {
        public DbSet<UserDao> Users { get; set; }
        public DbSet<BankAccountDao> BankAccounts { get; set; }
    }
}   
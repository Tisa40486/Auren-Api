using Auren.Api.Data.DbContexts;
using Auren.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Auren.Db.DbContexts
{
    public class AurenApiDbContext : BaseDbContext<AurenApiDbContext>, IAurenApiDbContext
    {
        public AurenApiDbContext(DbContextOptions<AurenApiDbContext> options) : base(options)
        {
        }
        public DbSet<UserDao> Users { get; set; }
        public DbSet<BankAccountDao> BankAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the entity mappings here if needed
        }
    }
}
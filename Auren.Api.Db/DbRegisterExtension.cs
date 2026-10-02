using Auren.Api.Db.Repository;
using Auren.Api.Db.Repository.Implementation;
using Auren.Api.Db.UnitOfWork;
using Auren.Db.DbContexts;
using Microsoft.Extensions.DependencyInjection;

namespace Auren.Db
{
    public static class DbRegisterExtension
    {
        public static void RegisterAurenApiDbContainer(this IServiceCollection services)
        {
            services.AddScoped<IAurenApiDbContext, AurenApiDbContext>();
            services.AddScoped<IBankAccountRepository, BankAccountRepository>();
            services.AddScoped<IAurenApiUnitOfWork, AurenApiUnitOfWork>();
        }
    }
}
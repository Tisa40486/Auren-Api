using Auren.Db.DbContexts;
using Auren.Db.Repository;
using Auren.Db.Repository.Implementation;
using Auren.Db.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace Auren.Db
{
    public static class DbRegisterExtension
    {
        public static void RegisterAurenApiDbContainer(this IServiceCollection services)
        {
            services.AddScoped<IAurenApiDbContext, AurenApiDbContext>();
            services.AddScoped<IAurenRepository, AurenRepository>();
            services.AddScoped<IAurenApiUnitOfWork, AurenApiUnitOfWork>();
        }
    }
}
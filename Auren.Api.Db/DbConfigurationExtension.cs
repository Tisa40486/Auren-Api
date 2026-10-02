using Auren.Db.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Auren.Db
{
    public static class DbConfigurationExtension
    {
        public static void AppAurenApiContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DataBase");

            services.AddDbContext<AurenApiDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                    mysqlOptions =>
                    {
                        mysqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
                                    .UseRelationalNulls()
                                    .EnableRetryOnFailure(
                                        maxRetryCount: 5,
                                        maxRetryDelay: TimeSpan.FromSeconds(30),
                                        errorNumbersToAdd: null
                                    )
                                    .MigrationsAssembly("Auren.Api.Db");
                        mysqlOptions.CommandTimeout((int)TimeSpan.FromMinutes(2).TotalSeconds);
                    }));
        }
    }
}
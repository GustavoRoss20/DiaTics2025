using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    public static class Ioc
    {
        public static IServiceCollection AddEntityFrameworkDiaTics(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DiaTics2025Ctx>(
               options => options
               .UseSqlServer(connectionString)
               .EnableSensitiveDataLogging()
               .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            return services;
        }
    }
}

using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class IoC
    {
        /// <summary>
        /// Inversion de control para Entity Framework
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <returns></returns>
        public static IServiceCollection AddRepositoryViProduce(this IServiceCollection services, string connectionString)
        {
            services.AddEntityFrameworkDiaTics(connectionString);
            services.AddScoped<IEfRepository, EfRepository>();
            return services;
        }
    }
}

using Business.Ngc;
using Domain.Interfaces;

namespace DiaTics2025WebApi
{
    public static class IoC
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IAlumnoItf, AlumnoNgc>();
            services.AddScoped<IInvitadoItf, InvitadoNgc>();
            services.AddScoped<IGeneralItf, GeneralNgc>();

            return services;
        }
    }
}

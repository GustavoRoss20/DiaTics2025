﻿using Domain.Interfaces;
using Service.Srv;

namespace DiaTics2025
{
    public static class IoC
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<IAlumnoItf, AlumnoSrv>();
            services.AddScoped<IInvitadoItf, InvitadoSrv>();
            services.AddScoped<IGeneralItf, GeneralSrv>();

            return services;
        }
    }
}

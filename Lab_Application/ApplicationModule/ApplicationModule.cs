using AutoMapper;
using Lab_Application.Helper;
using Lab_Application.Interfaces;
using Lab_Application.Profiles;
using Lab_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Lab_Application.ApplicationModule
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddApplicationService();
            services.AddSessionService();
            services.AddHttpServices();
            services.AddAutoMapperService();

            return services;
        }

        private static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ITecnicoServices, TecnicoServices>();
            services.AddScoped<ILaboratorioServices, LaboratorioServices>();
            services.AddScoped<IUsuarioServices, UsuarioServices>();

            return services;
        }

        private static IServiceCollection AddHttpServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

        private static IServiceCollection AddSessionService(this IServiceCollection services)
        {
            services.AddScoped<ISessaoHelper, SessaoHelper>();
            services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });

            return services;
        }

        private static IServiceCollection AddAutoMapperService(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new TecnicoProfile());
                mc.AddProfile(new LaboratorioProfile());
                mc.AddProfile(new UsuarioProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}

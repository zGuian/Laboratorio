using EFTS_Application.Interfaces;
using Lab_Infrastructure.Factory;
using Lab_Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Lab_Infrastructure.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddRepositoryServices();
            services.AddSqlDataService();

            return services;
        }

        private static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<ITecnicoRepository, TecnicoRepository>();
            services.AddScoped<ILaboratorioRepository, LaboratorioRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }

        private static IServiceCollection AddSqlDataService(this IServiceCollection services)
        {
            services.AddSingleton<ISqlDataAcess, SqlDataAcess>();

            return services;
        }
    }
}
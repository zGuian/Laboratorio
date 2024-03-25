using EFTS_Application.Helper;
using EFTS_Application.Interfaces;
using EFTS_Application.Services;
using Lab_Infrastructure.Factory;
using Lab_Infrastructure.Repository;

namespace EFTS_WebUI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<ISqlDataAcess, SqlDataAcess>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<ISessaoHelper, SessaoHelper>();

            services.AddScoped<ITecnicoRepository, TecnicoRepository>();
            services.AddScoped<ITecnicoServices, TecnicoServices>();

            services.AddScoped<ILaboratorioRepository, LaboratorioRepository>();
            services.AddScoped<ILaboratorioServices, LaboratorioServices>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioServices, UsuarioServices>();

            services.AddSession(o =>
            {
                o.Cookie.HttpOnly = true;
                o.Cookie.IsEssential = true;
            });
        }
    }
}
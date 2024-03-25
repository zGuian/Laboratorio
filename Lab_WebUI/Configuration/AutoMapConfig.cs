using AutoMapper;
using EFTS_Application.Profiles;

namespace EFTS_WebUI.Configuration
{
    public static class AutoMapConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new TecnicoProfile());
                mc.AddProfile(new LaboratorioProfile());
                mc.AddProfile(new UsuarioProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
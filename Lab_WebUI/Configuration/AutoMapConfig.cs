using AutoMapper;
using Lab_Application.Profiles;

namespace Lab_WebUI.Configuration
{
    public static class AutoMapConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new TecnicoProfile());
            });

            var mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}

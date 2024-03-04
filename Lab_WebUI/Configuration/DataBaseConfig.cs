using Lab_Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Lab_WebUI.Configuration
{
    public static class DataBaseConfig
    {
        public static void AddDataBaseConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<AppDataContext>(opts => opts.UseSqlServer(
                builder.Configuration.GetConnectionString("Default")));
        }
    }
}

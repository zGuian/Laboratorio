namespace EFTS_WebUI.Configuration
{
    public static class RouteMapConfig
    {
        public static void RouteMapConfiguration(this WebApplication app)
        {
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=login}/{action=index}/{id?}");
        }
    }
}
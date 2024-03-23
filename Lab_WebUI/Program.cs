using Lab_Application.ApplicationModule;
using Lab_WebUI.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDataBaseConfiguration(builder);
builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddAutoMapperConfiguration();
Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();
app.RouteMapConfiguration();
app.Run();
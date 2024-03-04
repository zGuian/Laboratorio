using Lab_WebUI.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add _services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDependencyInjectionConfiguration();
builder.Services.AddAutoMapperConfiguration();
builder.Services.AddDataBaseConfiguration(builder);

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
using CatchUpPlatform.API.News.Application.Services;
using CatchUpPlatform.API.News.Domain.Repositories;
using CatchUpPlatform.API.News.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios para los controladores
builder.Services.AddControllersWithViews();

// Registra el servicio de consulta y el repositorio
builder.Services.AddScoped<IFavoriteSourceQueryService, FavoriteSourceQueryService>();
builder.Services.AddScoped<IFavoriteSourceRepository, FavoriteSourceRepository>(); // Implementaci�n del repositorio

var app = builder.Build();

// Pipeline para manejar errores
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

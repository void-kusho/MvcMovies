using System.Globalization;
using Microsoft.EntityFrameworkCore;
using GabrielMovies.Data;
using GabrielMovies.Models;

var builder = WebApplication.CreateBuilder(args);

// Force en-US so currency ([DataType.Currency]) renders as "$" instead of "¤".
var enUS = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = enUS;
CultureInfo.DefaultThreadCurrentUICulture = enUS;

builder.Services.AddDbContext<GabrielMoviesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("GabrielMoviesContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();

using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using YourLogo.Data.DAL;
using YourLogo.Data.RepositoryConcretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(opt =>

opt.UseSqlServer("Server=CA-R215-PC03\\SQLEXPRESS;DataBase=YourLogoDB;Trusted_Connection=true;Integrated Security=true;TrustServerCCertificate;"));

//builder.Service.AddScoped<ProjectRepository, ProjectRepository>
//    builder.Services.AddScoped<ProjectService, ProjectService>

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

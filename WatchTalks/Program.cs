using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WatchTalks.Data;
using WatchTalks.Interfaces;
using WatchTalks.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

#region Repositories
builder.Services.AddTransient(typeof(ICrudOperationsAsync<>), typeof(CrudOperationsAsync<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
#endregion


var app = builder.Build(); 

app.UseStaticFiles();

app.MapRazorPages();

app.Run();
using practica5.Models;
//Se usan las librerias puestas ,para que funcione la conexion , en este pomelo para mysql
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);
//Aqui se hace el servicio para que añada la base de datos con el connection string , con el options que pide nuestro modelo o nuestro dbContext para poder utilizarlo, por otro lado tambien pide la version del mysql en este caso yo use la version 8.0.32 el cual se necesita para que funcione
builder.Services.AddDbContext<dbContext>(options=>
options.UseMySql(builder.Configuration.GetConnectionString("mysqlConnection"),
                new MySqlServerVersion(new Version(8,0,32))
).EnableDetailedErrors());

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

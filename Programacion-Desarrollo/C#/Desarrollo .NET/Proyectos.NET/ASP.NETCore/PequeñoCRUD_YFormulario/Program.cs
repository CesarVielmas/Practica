using Microsoft.EntityFrameworkCore;
using Base.Models;

var builder = WebApplication.CreateBuilder(args);
//Creacion de la cadena de coneccion para la base de datos , donde se tendra que poner el server en direccion ip o como localhost si es local y database el nombre de la base
//De datos y el usuario y contraseña registrado en la base de datos
var Cadena ="server=localhost;Database=ProyectoEjemplo2;Uid=Cesar;Pwd=1234";
// Add services to the container.
builder.Services.AddControllersWithViews();
//Se añade la siguiente linea de comandos para hacer la coneccion se añade el addDbContext que es para la base de datos la cual contiene entre corchetes de html el nombre de
//La clase publica donde se seguira la coneccion de la base de datos completa y ya se ponen las options y se señala que usara mysql como base de datos y en los parametros 
//Tendra la cadena de coneccion para que se conecte
builder.Services.AddDbContext<BaseDatos>(options => options.UseMySQL(Cadena));
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

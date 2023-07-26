using practica7.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<dbContextCrud>(options=> options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),new MySqlServerVersion(new Version(8,0,32))).EnableDetailedErrors());

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//Con los Cors se le indica que fuentes pueden acceder a la API y que headers orignenes , etc ahi se puede ver
app.UseCors(x=>
     x.AllowAnyHeader()
     .AllowAnyMethod()
     .SetIsOriginAllowed(origen=> true)
     .AllowCredentials()
    //.WithOrigins("") si se desea especificar que origenes pueden acceder a dichos datos de la API
    );
app.Run();

var builder = WebApplication.CreateBuilder(args);

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

//Como se especifica aqui , el unico parametro que se puede obtener mediante la url , sin especificar seria "id" con lo cual el controlador si la accion pide un parametro y no se llama "id" entonces no lo tomara , debe llamarse especificamente asi para que cumpla con dicho parametro opcional, si no , pues se usa la otra manera de pasar parametro mediante la url al controlador
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//Este es el programa principal , lo primero que hace es que crea la aplicacion web
var builder = WebApplication.CreateBuilder(args);

// despues aqui se le indica a la aplicacion que contendra controladores y vistas , por lo cual esto es opcional , dependiendo las necesidades del proyecto
builder.Services.AddControllersWithViews();
//Aqui crea la aplicacion con dichas especificaciones
var app = builder.Build();

// Esto es para configurar los errores y servicios http lo cual se vera mas adelante
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Este apartado lo que hace es que puedan existir redirecciones https , asi como los guardianes en angular , sin embargo esto se tocara mas a fondo adelante es opcional
app.UseHttpsRedirection();
//Este apartado lo que hace es que pueda leer o interactuar con archivos estaticos , algo que tambien se vera mas adelante , tambien es opcional
app.UseStaticFiles();
//Aqui en este apartado se le indica que utilizara routing para hacer las diferentes rutas con los controllers y con las acciones aunque es opcional es super recomendado tenerlo
app.UseRouting();
//Aqui se le indica que podra utilizar authorization para hacer autorizaciones , esto tambien es opcional
app.UseAuthorization();
//Este es el mapa de las rutas de el programa , aqui se indicara , que rutas podra seguir el programa y ue controlador usara y que accion de dicho controlador usara
app.MapControllerRoute(
    //Aqui en el nombre , se menciona que sera por defecto , osea tomara el mismo nombre del controldor que se active o vista
    name: "default",
    //en el pattern se le indica la ruta que debe seguir y que controlador y accion del controlador seguira para que se active en este caso como es por defecto , se dice en dicha ruta que si no tiene controladores que el controlador por defecto sea "Home" luego se le indica la accion de dicho controlador "/" y que si dicha accion no existe , que la accion por defecto sea "Index" de dicho controlador y como parametro opcional "/" el "id" si es que lo hay todo eso indica "{controller=Home}/{action=Index}/{id?}"
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
//Por ultimo se le indica que ejecute la aplicacion
app.Run();

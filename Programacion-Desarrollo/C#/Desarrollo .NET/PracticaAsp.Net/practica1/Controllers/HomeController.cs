//Librerias comunes para hacer controladores
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica1.Models;
//Aqui son los controladores , dicho apartado de controllers es para realizar acciones a la url y decir que vistas utilizar o que acciones http hacer etc 
namespace practica1.Controllers;//Importante usar el mismo namespace , pues seria el mismo espacio de nombre para todos los controladores

//clase para realizar dichas acciones , es importante y por convencion poner "Controller" al final de cada controlador , para que sea mas facil y lo detecte el programa
public class HomeController : Controller //Importante tambien heredar la clase abstracta Controller para que se le obligue utilizar sus metodos y que lo detecte el programa como controlador
{
    //Campo privado que sera de solo lectura llamado _logger , el cual es una inyeccion de dependencia llamada ILogger el cual recibe una lista de HomeController , 
    private readonly ILogger<HomeController> _logger;//Por convencion el "_" al inicio de un campo es para indicar un campo privado

    //Contructor el cual recibe el mismo tipo de dato que el dato privado para darselo a _logger
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //Metodo o accion que retorna una vista , en este caso como su nombre especifica "Index" devolvera la vista "Index" de las vistas en la carpeta "Home" y devolvera la vista "Index"
    public IActionResult Index()
    {
        return View();
    }
    //Metodo o accion exactamente siendo lo mismo que "Index" pero ahora devolvera la vista Privacy
    public IActionResult Privacy()
    {
        return View();
    }
    //Vista que retornara cuando haya un error o cuando no haya internet
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

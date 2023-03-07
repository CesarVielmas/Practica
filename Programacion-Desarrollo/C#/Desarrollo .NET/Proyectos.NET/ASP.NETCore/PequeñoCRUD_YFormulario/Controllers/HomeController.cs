using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pagina.Models;
using Base.Models;
using Microsoft.EntityFrameworkCore;
namespace Pagina.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    //Se crea una variable global de tipo objeto de el nombre de la clase de la siguiente coneccion para poder usarla al inicio de la pagina y que se conecte
    public BaseDatos ctx;

    public HomeController(ILogger<HomeController> logger,BaseDatos ctx)
    {
        //Aqui se le asigna el valor al iniciar la pagina para rellenarlo mediante el constructor
        this.ctx = ctx;
        _logger = logger;

    }

    public IActionResult Index()
    {
        //Se crea un viewBag  y se iguala al objeto creado que tomo ya las propiedades al ingresarla en el constructor y toma formulario ya que asi se llama la tabla de la
        //Base de datos
        ViewBag.Formulario = ctx.Formulario.Include(a => a.Edad).ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult PaginaNueva()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

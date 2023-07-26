using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica9.Models;

namespace practica9.Controllers;

public class TestController : Controller
{
    private readonly ILogger<TestController> _logger;

    public HomeController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [TypeFilter(typeof(Filtros.FiltroExcepcion))]//Se le indica aqui , que el apartado del get cuando haga un error sera y utilizara el filtro creado personalizado  para cualquier dicho error en dicho apartado y si se pone a nivel del contructor o la aplicacion , entonces todos los metodos tomaran dicho filtro
    public IActionResult obtener(){

       return throw new Exception("Error Garrafal");
    }
}
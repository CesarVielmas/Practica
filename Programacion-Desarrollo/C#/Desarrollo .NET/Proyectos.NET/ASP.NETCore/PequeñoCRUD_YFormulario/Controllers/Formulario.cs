using System;
using Microsoft.AspNetCore.Mvc;
using Validaciones.Models;
using System.Linq;
using System.Threading.Tasks;
namespace Pagina.Controllers
{
    public class FormularioController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //BindProperty sirve para correlacionar con la tabla en este caso de los index
        [BindProperty]
        public Validacionesxd SetValidacion {get; set;} //Se crea una property para almacenar lo que se de en el objeto de validaciones que ya fue creado para llenarlo mediante la pagina
        public IActionResult Validacionxd()
        {
            //Aqui se manda un Json ya que lo que se guarde se quiere ver en pantalla por lo cual se crea un Json y con el method post se ve en pantalla lo que se le dio 
            return Json(SetValidacion);
        }
    }
}
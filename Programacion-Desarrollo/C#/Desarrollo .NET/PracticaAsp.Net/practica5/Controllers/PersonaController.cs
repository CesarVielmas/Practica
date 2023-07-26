//Este controlador servira para ver o extraer la informacion desde la base de datos 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica5.Models;

namespace practica5.Controllers
{
    public class PersonaController : Controller
    {
        //Lo que sucede en un principio , es que al inicio de la aplicacion , desde program.cs , como ya se inicializo la conexion a la base de datos y como dbContext ya contiene lo necesario para poder obtener sus modelos o sus datos dentro de esta misma , en este caso obtiene el modelo persona y producto, entonces en el contructor de la clase se le otorga dicho objeto con dichos datos y se le da a _dbContext , por ello es importante ponerselo al contructor
        private readonly dbContext _dbContext;
        public PersonaController(dbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Metodo index el cual obtendra los datos de la base de datos para ello necesita ser asincrono y esperar los datos pues depende de la conexion a internet
        public async Task<IActionResult> Index()
        {
            //await para esperar los datos y debe de ser una lista asincrona para darlos o asignarlos
            List<Persona> personas = await _dbContext.Personas.ToListAsync();
            return View(personas);
        }
    }
}
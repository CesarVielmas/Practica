using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using practica4.Models;

namespace practica4.Controllers
{
    public class EjemploController : Controller
    {
        public EjemploController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
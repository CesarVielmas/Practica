using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using practica6.Models;

namespace practica6.Controllers;
    public class PublicacionesController : Controller
    {
        private dbContextRel _dbContextRel;
        public PublicacionesController(dbContextRel dbContextRel)
        {
            _dbContextRel = dbContextRel;
        }

        public async Task<IActionResult> Index()
        {
            //Foreach el cual hace que el atributo de comentarios de publicacions se rellene con la tabla comentarios
            foreach (var item in await _dbContextRel.Publicacions.ToListAsync())
                item.Comentarios = await _dbContextRel.Comentarios.ToListAsync();

            List<Publicacion> publicacions = await _dbContextRel.Publicacions.ToListAsync();
            return View(publicacions);
        }
    }
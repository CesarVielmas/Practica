using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using practica6.Models;

namespace practica6.Controllers;
    public class ComentarioController : Controller
    {
        private dbContextRel _dbContextRel;
        public ComentarioController(dbContextRel dbContextRel)
        {
            _dbContextRel = dbContextRel;
        }

        public async Task<IActionResult> Postear(Comentario comentario){
            //Verifica que los datos que se mandaran hayan sido validos hasta ahora para el modelo , ya sea si se enviaron 2 o 3 datos del modelo
            if (ModelState.IsValid)
            {
                comentario.Fecha = DateTime.Now.Date;
                comentario.Nombre = "Usuario";
                _dbContextRel.Comentarios.Add(comentario);
                await _dbContextRel.SaveChangesAsync();
                return Redirect("/Publicaciones");
            }
            return Redirect("/Home");
        }
    }
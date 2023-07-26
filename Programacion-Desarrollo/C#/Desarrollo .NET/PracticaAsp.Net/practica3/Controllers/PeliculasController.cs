//Controlador para las peliculas con los datos de ejemplo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using practica3.Models;
using Newtonsoft.Json;//Libreria para serealizar un json

namespace practica3.Controllers;
    public class PeliculasController : Controller
    {
        //Se hace una lista privada donde ira una lista de objetos del modelo
        private List<PeliculaModel> _peliculaList = null;
        public PeliculasController()
        {
            //aqui lo que se hace es que se obtienen los datos el cual se uso la base de datos de ejemplo para dicha cuestion , despues de obtenerlos se desearilizan osease se convierten a un tipo en este caso a una lista de peliculamodel osease del modelo , aunque "<>" dentro de ambas llaves podria ir el tipo al que se necesita
           var jsonString = System.IO.File.ReadAllText("Datos/ejemplo.json");
           _peliculaList  = JsonConvert.DeserializeObject<List<PeliculaModel>>(jsonString);


        }

        public IActionResult Index()
        {
            return View(_peliculaList);
        }

        public IActionResult Especifico(int id){
            
           foreach (var item in _peliculaList)
           {
            if (item.Id == id)
            {
                return View(item);
            }
           }
           return View();
           
        }
    }
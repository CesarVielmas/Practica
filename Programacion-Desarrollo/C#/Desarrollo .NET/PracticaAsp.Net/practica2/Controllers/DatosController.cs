//En este controlador lo que se hara sera pasar los datos desde el controlador o la accion a la vista
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica2.Models;

namespace practica2.Controllers;

public class DatosController : Controller{
    //El IActionResult sirve para retornar la vista , aunque para mas cosas , sin embargo se vera a detalle despues

    //Ejemplo Correcto "http://localhost:5173/Datos/datosVistaControlador?variable1=cesar&variable2=rubi"

    public IActionResult datosVistaControlador(String variable1,String variable2){
        //Para ello hay 2 maneras de hacerlo , con ViewBag o con ViewData["variable"] para ello se veran ambas
        //ViewBag manera 1
        ViewBag.variable1 = variable1;
        //ViewData manera 2
        ViewData["variable2"] = variable2;

        return View();
    }
    //Pasando datos de el modelo a la vista

    //En este se le pide un id para que al momento de entrar a la accion entre a una o entre a otra
    public IActionResult datosControladorVista(int id){
        if (id==1)
        {
            DatosVistaModel datos = new DatosVistaModel(){
            Nombre = "Cesar",
            Apellido = "Vielmas",
            Edad = 21
            };
            /*
            Metodo no recomendado aunque funciona
            ViewBag.Datos = datos;
            ViewData["Datos"] = datos;
            return View();
            */
            //Metodo recomendado o elegante
            return View(datos);

        }
        else{
            
            DatosVistaModel datos = new DatosVistaModel(){
            Nombre = "Rubi",
            Apellido = "Esmeralda",
            Edad = 22
            };
            /*
            Metodo no recomendado aunque funciona
            ViewBag.Datos = datos;
            ViewData["Datos"] = datos;
            return View();
            */
            //Metodo recomendado o elegante
            return View(datos);
        }
       

    }

}
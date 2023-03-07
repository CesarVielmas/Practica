using System;
using Microsoft.AspNetCore.Mvc;
using Tabla.Models; //Usa el modelo tabla

namespace Pagina.Controllers; //Coneccion con todos los controladores
public class TablaEjemploController : Controller
{
    private int ID = 0;
    public IActionResult Tabla()
    {
        //Creacion de la lista de tipo para tabla
    List<ParaTabla> Datos = new List<ParaTabla>()
    {
        new ParaTabla()
        {
            ID = this.ID+1,
            NombreEmpleado = "Juan Dominguez Ordaz",
            AreaEncargada = "Administracion",
            Edad = 27,
            Ambiguedad = "2 años y 3 meses"
        }
        ,
        new ParaTabla()
        {
            ID = this.ID + 2,
            NombreEmpleado = "Flor Alejandra Segoviano",
            AreaEncargada = "Recursos Humanos",
            Edad = 20,
            Ambiguedad = "7 meses"
        }
        ,
        new ParaTabla()
        {
            ID = this.ID +3,
            NombreEmpleado = "Pepe Ortiz Pineda",
            AreaEncargada = "Contaduria",
            Edad = 22,
            Ambiguedad = "1 año"
        }
        ,
        new ParaTabla()
        {
            ID = this.ID + 4,
            NombreEmpleado = "Pepe Cuevas Dominguez",
            AreaEncargada = "Administracion",
            Edad = 25,
            Ambiguedad = "1 año y 8 meses"
        }
        ,
        new ParaTabla()
        {
            ID = this.ID + 5,
            NombreEmpleado = "Jose Alberto Hernandez",
            AreaEncargada = "Recursos Humanos",
            Edad = 33,
            Ambiguedad = "2 años"
        }
        ,
        new ParaTabla()
        {
            ID = this.ID + 6,
            NombreEmpleado = "Cesar Alejandro",
            AreaEncargada = "Sistemas",
            Edad = 21,
            Ambiguedad = "6 meses"
        }
        ,
        new ParaTabla()
        {
            ID = this.ID + 7,
            NombreEmpleado = "Pedro Humberto Hernandez",
            AreaEncargada = "Electronica",
            Edad = 46,
            Ambiguedad = "6 años"
        }
    };
    //Creacion del view data que sera usado en la pagina
    ViewData["Empleados"] = Datos;
        return View();
    }
}
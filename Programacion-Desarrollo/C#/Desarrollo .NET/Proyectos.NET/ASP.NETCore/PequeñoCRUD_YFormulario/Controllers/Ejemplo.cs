using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Pagina.Controllers;

public class EjemploController: Controller
{
   //Abrir Pdf Creando primero la variable privada de clase con cualquier nombre
   private IHostEnvironment _env;
   //Despues dentro del constructor pedir como parametro un objeto de iHostEnvironment para que la pagina al iniciar lo rellene y se lo asigne a la variable privada
 public EjemploController(IHostEnvironment env)
 {
    _env = env;
 }

 public IActionResult Index()
 {
    //Creacion de una lista para guardarla en el ViewBag , ViewData y TempData
    List<string> ListaXD = new List<string>()
    {
       "Perro","Gato","KoalaKong","Pepito El Gordito"
    };
    //Utilizando ViewBag La cual es la mas sencilla de las 3 y sirve para guardar datos y pasarlos a alguna vista
    ViewBag.Lista = ListaXD;
    //Lo mismo que ViewBag Solo que al pasarlo a una vista se ocupa hacer una conversion de el dato
    ViewData["Lista"] = ListaXD;
    //Lo mismo que ViewData Pero segun ahorra mas memoria y se puede usar solo en una vista y se elimina despues
    TempData["Lista"] = ListaXD;
    return View();
 }
 //Aqui secrea un metodo para poder ver los pdfs 
 public FileStreamResult PDF()
 {
    //Aqui se pone el path de los archivos donde se encuentran en este caso 2
    string ArchivePath = Path.Combine(_env.ContentRootPath,"wwwroot/Pdfs/","Encontrado.pdf");
    string ArchivePath2 = Path.Combine(_env.ContentRootPath,"wwwroot/Pdfs/","NoEncontrado.pdf");
    //Aqui se hace un if para detectar si existe el primer archivo 
    if(System.IO.File.Exists(ArchivePath))
    {
       //Se crea un objeto de tipo FileStream para poder abrir el archivo dentro del navegador dandole el path y diciendole que lo ponga en modo abrir
       FileStream Abrir = new FileStream(ArchivePath,FileMode.Open);
      //Aqui se retorna la pagina dandole abrir de el objeto filestream para que lo haga y diciendole que lo muestre en pantalla con "application/pdf"
      return File(Abrir,"application/pdf");
       //Aqui seria otra manera diferente retornando ahora ya no el archivo si no directamente descargandoselo al usuario desde el navegador
      // return File(Abrir,"application/octet-stream","ArchivoEjemplo");
    }
    //Aqui manda si no existe el archivo
   else
   {
       FileStream Abrir = new FileStream(ArchivePath2,FileMode.Open);
       //Aqui se retorna la pagina dandole abrir de el objeto filestream para que lo haga y diciendole que lo muestre en pantalla con "application/pdf"
       return File(Abrir,"application/pdf");
       //Aqui seria otra manera diferente retornando ahora ya no el archivo si no directamente descargandoselo al usuario desde el navegador
       //return File(Abrir,"application/octet-stream","ArchivoEjemplo");
   }
 }
}



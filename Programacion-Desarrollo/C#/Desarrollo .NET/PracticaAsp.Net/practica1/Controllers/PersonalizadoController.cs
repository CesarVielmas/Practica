//Ejemplo creado

//Librerias comunes para hacer controladores
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica1.Models;
//Aqui son los controladores , dicho apartado de controllers es para realizar acciones a la url y decir que vistas utilizar o que acciones http hacer etc 
namespace practica1.Controllers;//Importante usar el mismo namespace , pues seria el mismo espacio de nombre para todos los controladores

//clase para realizar dichas acciones , es importante y por convencion poner "Controller" al final de cada controlador , para que sea mas facil y lo detecte el programa
public class PersonalizadoController : Controller {

    public String Index(){

        return "Este es un mensaje desde el index";
    }
    //Metodos de ejemplo para acceder mediante su url
    public String mensaje(){

        return "Este es un mensaje de ejemplo , por mensaje";
    }

    public String mensaje2(){
        return "Este es otro mensaje de ejemplo , por mensaje 2";
    }

}
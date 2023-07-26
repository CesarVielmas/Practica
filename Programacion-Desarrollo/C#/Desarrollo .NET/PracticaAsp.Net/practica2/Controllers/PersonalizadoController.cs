using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica2.Models;

namespace practica2.Controllers;

public class PersonalizadoController : Controller{
    //Para pasar un parametro que no venga especificado en la url es de esta manera "?variable="valor"&variable2="valor"...." etc


    //accion que pasa el "id" especificamente como se pide en la url
    //Ejemplo Correcto "http://localhost:5173/Personalizado/paso1/10"
    public String paso1(int id){
        return "El id pasado especificamente mediante la url es:"+id;
    }
    //accion que pasa cualquier otro parametro que no se llame "id" 
    //Ejemplo Correcto "http://localhost:5173/Personalizado/paso2?edad=10"
    public String paso2(int edad){
        return "La edad es de :"+edad;

    }
    //accion que pide 2 o mas parametros
    //Ejemplo Correcto "http://localhost:5173/Personalizado/paso3?nombre="Cesar"&edad=21"
    public String paso3(string nombre, int edad) {
        return "Nombre: "+nombre+"\nEdad:"+edad;
    }
    //accion que pide especificamente "Id" y otro parametro
    //Ejemplo correcto "http://localhost:5173/Personalizado/paso4/Cesar?edad=21"
    public String paso4(string id,int edad){
        return "valor id:"+id+" edad:"+edad;
    }
}
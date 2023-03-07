using System;
using static System.Console; //Aqui se importo la clase console la cual ya no sera necesario poner para funcionar
using static System.Math;// Aqui la clase math que tambien ya no sera necesario poner para usar sus metodos
namespace PooParte8
{
//Aqui se vera lo que son las clases anonimas y como importar las clases que se pueden ver dentro del programa
//Empezando por las clases anonimas estas mismas sirven para crear objetos anonimos los cuales pueden contener
//Parametros o propiedades o campos de clase aunque solo eso ya que no pueden tener metodos y siempre deben
//de asignarse sus campos de clase o propiedades no pueden quedar vacios se vera un ejemplo en el codigo
//Ahora lo de importar las clases se pueden hacer aunque no es recomendable , exclusivamente en este programa
//se importaran las clases de console y math para uqe se vea un poco como es que funciona , aunque podria
//darle otro uso al crear nosotros nuestras clases y importarlas pero eso se vera despues
    class Parte8
    {
        static void Main(string[] args)
        {
            //Si no estuviera importada la clase
            System.Console.WriteLine("hola aqui se usan las clases system y console aunque no es necesario");
            //Si estuviera importada la clase en este caso si
            WriteLine("Hola aqui se usa el writeline solo ya que se importo la clase system y console");
    //La var se usa en estos casos de clases o objetos anonimos pues el compilador le asigna un tipo a la variable
     //Por eso var , es suceptible a cualquier dato que le asigne el compilador y se usa en esto de las clases anonimas
    //O objetos anonimos
            //Creacion de clase anonima
            var variable1 = new {Nombre = "Cesar", Edad= 20}; 
            //Creacion de otra clase anonima
            var variable2 = new {Nombre = "Rubi", Edad= 21};
            //Aqui un pequeño ejemplo de como podrian usarse
            WriteLine("Datos de la clase anonima o objeto anonimo 1: Edad:"+variable1.Edad+" Nombre:"+variable1.Nombre);
            WriteLine("Datos de la clase anonima o objeto anonimo 2: Edad:"+variable2.Edad+" Nombre:"+variable2.Nombre);
    //En este caso se pueden igualar ambas pues comparten el mismo nombre de los campos de clase y ademas 
    //El mismo tipo de dato de clase
            variable1 = variable2;
            variable2 = variable1;
        }
    }
}
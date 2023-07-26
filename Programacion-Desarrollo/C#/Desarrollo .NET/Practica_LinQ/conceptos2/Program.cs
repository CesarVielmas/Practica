// Ahora lo que se vera sera el uso de LINQ , con objetos "anonimos" o con creacion de objetos mediante una clase, pues los objetos anonimos tal y como es en javascript , sirven para crearlos en el momento de ejecucion , se les puede dar un nombre a dichos objetos anonimos o campos de dicho objeto anonimos creado , o no para ello se veran ambos ejemplos

//Con objeto anonimo
List<int> listaAnonima = new List<int>();
listaAnonima.Add(1);
listaAnonima.Add(2);
listaAnonima.Add(3);
listaAnonima.Add(4);
listaAnonima.Add(5);
listaAnonima.Add(6);
//Uso de LINQ
//lo de "x=>" es lambda el cual se vera en los demas conceptos para entenderlo bien
var resultado1 = listaAnonima.Where(x=>x%2==0).Select(x=> new {
    resultadoAnonimo = x
}).ToArray();
Console.WriteLine("objeto anonimo creado:"+resultado1);

//Con objeto o clase ya hecha
List<int> listaObjeto = new List<int>();
listaObjeto.Add(1);
listaObjeto.Add(7);
listaObjeto.Add(10);
listaObjeto.Add(8);
listaObjeto.Add(3);

var resultado2 = (from edad in listaObjeto
                  where edad%2==0
                  select new Edades{
                    _edad = edad
                  }).ToArray();
Console.WriteLine("objeto de clase creado:"+resultado2);
public class Edades{

    //Propiedad de la clase que pide     
    public int _edad{get;set;}
}
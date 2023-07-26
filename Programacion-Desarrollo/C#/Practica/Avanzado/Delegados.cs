using System;
using System.Collections.Generic;
using System.Linq;
namespace Delegados{
    public class delegados{
        //Ahora se vera sobre los delegados y para que sirven lo cual es muy util ya que los delegados sirven explicitamente para poder guardar funciones dentro de una variable como javascript o utilizar una funcion como un parametro para algun metodo , aqui se veran algunas formas para poder usarlo

        //Creacion del delegado el cual necesita de su palabra reservada "delegate" y necesita que tipo de dato va a mandar en este caso mandara un entero , ya es opcional si tendra parametros o no tendra ninguno
        public delegate int delegadoEjemplo(List<int> lista);

        //Forma 1 : crear una funcion o metodo aparte para que este lo resiva la variable que va a guardar el delegate, dicha funcion debe cumplir con sus parametros , en este caso que envie un int y que reciba una lista en sus parametros
        public static int mandarPrimerNumero(List<int> lista){
            //Uso de LINQ para metodos anidados y no de consultas
            return lista.First();
        }
         static void Main(string[] args)
         {
            //Forma 1: guardando la funcion dentro de una variable
            delegadoEjemplo variableFuncion1 = mandarPrimerNumero;
            //ahora usando dicha variable de funcion para mostrarla
            console.WriteLine("Primera Forma:"+variableFuncion1(new List<int>{1,9,8,5}));
            //Forma 2: usando una funcion anonima creada especialmente para el delegate de esta forma de ahorras el crear una funcion para dicho delegate
            delegadoEjemplo variableFuncion2 = delegate(List<int> listaTomada){
                 return listaTomada.First();
            };
            console.WriteLine("Segunda Forma:"+variableFuncion2(new List<int>{10,9,5,2}));
            //Forma 3: usando lambda el cual en otro archivo se profundizara
            delegadoEjemplo variableFuncion3 = (funcion=>funcion1.First());

            //Manera de usarlo o manera frecuente de usarlo

            //La mayoria de veces se usa para usarlo para pasarlo de parametro ya sea a un metodo de alguna clase o algun otro sitio , para ello se usa aqui un ejemplo
            delegadoClase.encontrarNumero(mandarPrimerNumero,new List<int>{10,9,5,2});
            //Y como se puede apreciar se mando una funcion el cual lo tomara la clase y su respectivo metodo para usarlo ya podria haberse mandado una funcion o una variable con ya la funcion incluida y para ello sirven los delegados
         }
    }
    public class delegadoClase{
        public static void encontrarNumero(delegadoEjemplo objetoDelegado,List<int> lista1){
            console.WriteLine("uso del delegado");
            console.WriteLine(objetoDelegado(lista1));
        }
    }
}
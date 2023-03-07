using System;
using System.Collections.Generic;
namespace ColeccionesParte1
{
//Lo que se vera son las colecciones , son una libreria compuesta de clases genericas las cuales sirven mucho
//Para ahorrar codigo , ya que estas te incluyen lo que podrias hacer con clases genericas , para arrays
//O para guardar cualquier tipo de objeto en arrays , tambien estas mismas tienen la ventaja de tener una
//Sintaxis menos complicada ya que esta hecho , tambien , te deja dentro de la ejecucion del programa agregar
//Mas valores a los arrays o eliminarlos , aunque existen 5 colecciones las cuales aqui se veran 2 y en la
//Siguiente parte otras 2 son muy utiles , aunque su mayor desventaja es que consumen mucho mas recursos
//Que hacerlo por uno mismo mediante clases genericas creadas por uno pero igualmente es muy util
//Ejemplo
    class Parte1Colecciones
    {
        static void Main(string[] args)
        {
           
            //Usando la coleccion "<List>"
            //Aqui se llama a la clase generica list poniendole una variable llamada empleados, como ya esta
            //Implicita la clase pues ya fue puesta mediante la biblioteca Using.Collection.Generic no hace
            //Falta declarar ninguna clase
            List <string> empleados = new List<string>();
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("Usando <List>\n--------------------------------------------------");
            System.Console.WriteLine("De que tamaño sera su List de empleados");
            //Aqui se declaran las variables para cuantos empleados tendra el array y el contador del array
            //Para salir del while
            int cantidadEmpleados = int.Parse(System.Console.ReadLine());
            int contador=0;
            while(contador<cantidadEmpleados)
            {
                System.Console.WriteLine("Introduzca el empleado "+contador+":");
                //Aqui se guarda en empleados , los valores proporcionados por el usuario
                //Para el array y como es una clase generica el que lo creo , se le pueden
                //Asignar los strings y que forme un array empleados
                empleados.Add(System.Console.ReadLine());
                contador++;
            }
            contador = 0;
            //Ya aqui se usa un foreach para desplegar los datos que fueron otorgados a el array de empleados
            //Para verlos en pantalla , muy recomendable usar foreach y no for para las clases genericas
            //Con arrays aunque creo que las clases genericas solo sirven para los arrays
            System.Console.WriteLine("Su lista quedaria de la siguiente manera: ");
            foreach(string valor in empleados)
            {
                System.Console.WriteLine("Empleado "+contador+": "+valor);
                contador ++;
            }
            //Algunas funciones basicas explicadas de la clase generica <List>
            /*
            empleados.Add(); esta funcion lo que hace es añadir el valor a el array de la variable 
                             objeto que se haya hecho
                             
            empleados.Count;esta propiedad lo que hace es como el lenght de los arrays solo que se llama count
                            Proporciona la cantidad de objetos almacenados en el array retornando un valor int

            empleados.RemoveAt();esta funcion lo que hace es eliminar algun elemento del array el cual debe
                                 asignarse cual posicion del array quiere eliminar en los parametros
            */

             //Usando la coleccion "<LinkedList>" <>
             //Lo que tiene de diferentes las linkedList es que en vez de crear valores en la memoria 
             //Crea objetos llamados nodos los cuales se conectan entre si , esto quiere decir que cuando
             //Se elimina un objeto de una List todo el programa oh bueno todo lo que este almacenado en esa
             //List sera movido todo hacia abajo o una posicion menos y eso a la memoria le cuesta , en cambio
             //LinkedList ahorra muy bien los recursos porque como estan conectados entre si al eliminar
             //Algun objeto como estan conectados con los demas , solo el objeto una posicion arriba del
             //Eliminado sera quien se actualize y los demas no , esto hace que sea muchisimo menos pesado para
             //La memoria en vez de mover cada uno hacia abajo ademas que como ya se dijo puedes modificar o 
             //Añadir nodos a tu voluntad para una variable que sea linkedlist o de tipo objeto linkedlist
             LinkedList<string> empleados2 = new LinkedList<string>();
              System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine("Usando <LinkedList>\n--------------------------------------------------");
            System.Console.WriteLine("Ingrese cuantos empleados habra para la LinkedList");
            //Variables para ingresar el tamaño de el array y el contador para salir del while
            int cantidadEmpleados2 = int.Parse(System.Console.ReadLine());
            int contador2 = 0;
            while(contador2<cantidadEmpleados2)
            {
             System.Console.WriteLine("Ingrese el nombre del empleado "+contador2);
             string valor = System.Console.ReadLine();
             //LinkedListNode o nodo de linkedlist para crear objetos y no datos en el objeto empleado 2
             //Aunque es igual
            LinkedListNode<string> NodoEmpleados2 = new LinkedListNode<string>(valor);
             empleados2.AddLast(NodoEmpleados2);
             contador2++;
             }
             contador2 =0;
             //Foreach para ver lo que tiene almacenado el array empleado 2
             foreach(string nombres in empleados2)
             {
                 System.Console.WriteLine("Nombre del empleado "+contador2+":"+nombres);
                 contador2++;
             }

        }
    }

}
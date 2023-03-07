using System;
using System.Collections.Generic;
namespace ColeccionesParte2
{
//Ahora aqui lo que se vera es el Queue, Stacks y Dictionary , empezando por el Collection Queue lo que hace es
//que utiliza el sistema FIFO por su traduccion(First Int , First Out) esto significa que el primero en entrar sera el 
//Primero en salir , este es util ya que se quedan en espera los datos o procesos , hasta que salga el primer
//Dato que entro y asi se va , en este caso para los arrays , el primer dato ingresado , solamente podra ser
//Removido el primer dato ingresado , y luego el segundo y etc etc , hasta el ultimo y para ello se usa 
//Queue, es como hacer cola para entrar a un lugar , ahora los Stacks es exactamente casi lo mismo que los
//Queue pero al reves ahora es LIFO por su traduccion (Last Int First out) que significa el ultimo en entrar
//Es el primero que sale y por ultimo los Dictonary estos son los mas interesantes pues tienen 2 parametros
//Uno que es un string y otro un int o double , estos mismos tienen que almacenar esos 2 parametros para 
//Que sean ingresados al array 
//Ejemplo
    class Parte2Colecciones
    {
        static void Main(string[] args)
        {

            //Ejemplo Usando Queue
            System.Console.WriteLine("--------------------\nUsando Queue\n--------------------");
            //Se crea la instancia o objeto a Queue como se hizo con list y linkedList
            Queue <string>UsuariosEnEspera = new Queue<string>();
            int Contador1 =0;
            System.Console.WriteLine("¿Cuantos usuarios hay en espera?");
            //Aqui se asigna el valor de cuantos usuarios seran
            int CantidadDeUsuarios = int.Parse(System.Console.ReadLine());
            while(Contador1 <CantidadDeUsuarios)
            {
                //Aqui se le asigna el nombre a cada usuario
                System.Console.WriteLine("Digame el nombre del usuario "+(Contador1+1)+" en espera");
                string usuarios = System.Console.ReadLine();
                //Y Se usa Enqueue el cual asigna el valor al array de el objeto
                //El Dequeue lo que hace es eliminar el primer objeto lo cual es en lo que esta
                //Especializado Queue
                UsuariosEnEspera.Enqueue(usuarios);
                Contador1++;
            }
            Contador1 =0;
            //Obteniendo los valores con el foreach
            foreach(string nombre in UsuariosEnEspera)
            {
                System.Console.WriteLine("entro "+nombre+" en la posicion "+Contador1+" entonces sale \nluego");
                Contador1++;
            }
            System.Console.WriteLine("Termina el programa");
            //Ejemplo usando Stack
            System.Console.WriteLine("--------------------\nUsando Stack\n--------------------");

            //Se crea la instancia o objeto a stack como se hizo con list y linkedList
            Stack <string>Usuarios1 = new Stack<string>();
            int Contador =0;
            System.Console.WriteLine("¿Cuantos usuarios hay?");
            //Aqui se asigna el valor de cuantos usuarios seran
            int CantidadDeUsuarios1 = int.Parse(System.Console.ReadLine());
            while(Contador<CantidadDeUsuarios1)
            {
                //Aqui se le asigna el nombre a cada usuario
                System.Console.WriteLine("Digame el nombre del usuario "+(Contador+1));
                string usuarios2 = System.Console.ReadLine();
                //Y Se usa Push el cual asigna el valor al array de el objeto en los de tipo stack
                Usuarios1.Push(usuarios2);
                Contador++;
            }
            Contador = 0;
             System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Antes de eliminar un valor:");
            //Obteniendo los valores con el foreach antes de eliminar 1
            foreach(string nombre in Usuarios1)
            {
                System.Console.WriteLine("entro "+nombre+" en la posicion "+Contador);
                Contador++;
            }
            //Eliminar el ultimo valor ya que es stack
            Usuarios1.Pop();
             System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Despues de eliminar un valor:");
            Contador=0;
            foreach(string nombre in Usuarios1)
            {
                System.Console.WriteLine("entro "+nombre+" en la posicion "+Contador);
                Contador++;
            }
            System.Console.WriteLine("Termina el programa");
            //Ejemplo usando Dictionary
            System.Console.WriteLine("--------------------\nUsando Dictionary\n--------------------");
            Dictionary <string,int> Personas = new Dictionary<string, int>();
            int Contador3 =0;
            System.Console.WriteLine("¿Cuantas personas hay?");
            //Aqui se asigna el valor de cuantos usuarios seran
            int CantidadDeUsuarios2 = int.Parse(System.Console.ReadLine());
            while(Contador3<CantidadDeUsuarios2)
            {
                //Aqui se le asigna el nombre a cada usuario
                System.Console.WriteLine("Digame el nombre del usuario "+(Contador3+1));
                string usuarios3 = System.Console.ReadLine();
                //Aqui se le asigna la edad a el usuario
                System.Console.WriteLine("Digame la edad del usuario "+(Contador3+1));
                int usuarios4 =int.Parse( System.Console.ReadLine());
                //Y Se usa Add el cual asigna el valor al array de el objeto en los de tipo Dictionary
                //El cual pide dos valores que es el string o el codigo unico y un valor entero
                Personas.Add(usuarios3,usuarios4);
                Contador3++;
            }
            Contador3 = 0;
             System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Antes de eliminar un valor:");
            //Obteniendo los valores con el foreach antes de eliminar 1
            foreach(KeyValuePair<string, int> ejemplo in Personas)
            {
                System.Console.WriteLine("entro "+Personas.Keys+" Con edad de "+Personas.Values+" en la posicion "+Contador);
                Contador3++;
            }
            //Eliminar un valor el que sea
            Personas.Clear();
             System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("Despues de eliminar todo:");
            Contador3=0;
           foreach(KeyValuePair<string, int> ejemplo in Personas)
            {
                System.Console.WriteLine("entro "+Personas.Keys+" Con edad de "+Personas.Values+" en la posicion "+Contador);
                Contador3++;
            }
            System.Console.WriteLine("Termina el programa");
        }
    }
}
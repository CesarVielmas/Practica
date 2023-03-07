using System;
namespace InterfacesParte2
{
    //Ahora lo que se vera son las ambiguedades en las interfaces , esto de las ambiguedades , es cuando se 
    //Tiene 2 o mas interfaces con los mismos metodos , esto quiere decir que al momento de heredar la interfaz
    //Una clase , el metodo que es el mismo para todas las interfaces , pues lo tomaran todas las interfaces
    //Y por obvias razones no se quiere tener lo mismo en las interfaces , se vera un ejemplo el cual resuelve
    //Esto , tambien usando el metodo de sustitucion el cual es lo mejor que se puede en estos casos
    //Ejemplo
    class Parte2Interfaces
    {
        static void Main(string[] args)
        {
            //Ahora aqui se hara el metodo de sustitucion para que pueda ser llamado ese comportamiento de la clase
            //Creacion del objeto
            Humano objeto1 = new Humano();
            //Metodo de sustitucion tomando sus comportamientos para que pueda ser usado
            IinteligenciaMedia media = objeto1;
            //Asignando el valor que retorna a una variable que sera llamada
           int inteligenciaMedia = media.inteligencia();
            //Metodo de sustitucion tomando sus comportamientos para que pueda ser usado
           IinteligenciaAlta alta = objeto1;
            //Asignando el valor que retorna a una variable que sera llamada
           int IinteligenciaAlta = alta.inteligencia();
           //Llamando a los valores
           System.Console.WriteLine("La inteligencia media es: "+inteligenciaMedia+" y la inteligencia alta es: "+IinteligenciaAlta);
        }
    }
    //Creacion de las interfaces las cuales haran de herencia a la clase humano , Aqui se ve el claro ejemplo
    //Ambas interfaces , comparten los mismos comportamientos mas sin embargo el numero es diferente para cada
    //Una de las interfaces , la inteligencia media es 100 el cual tiene el 69% de la poblacion y una inteligencia
    //Alta se considera desde 115 hacia arriba que solo el 16% de la poblacion tiene
    interface IinteligenciaMedia
    {
        int inteligencia();
    }
    interface IinteligenciaAlta
    {
        int inteligencia();
    }
    //Se heredan las interfaces 
    class Humano : IinteligenciaMedia,IinteligenciaAlta
    {
        public Humano()
        {
            System.Console.WriteLine("Soy un humano");
        }
        //Ahora aqui el problema al asignarle el compartamiento inteligencia , no se puede hacer ambos asi
        //Porque da error , sin embargo ambas interfaces toman como el compartamiento a una misma lo cual no se
        //Quiere hacer eso 
        //Ejemplo

        /*public int inteligencia()
        {

        }
        */
        //La solucion es crear 2 metodos los cuales no tendran metodo de acceso , ya que al querer ser llamados
        //Desde la clase principal el compilador no sabra a cual de los 2 llamar , para ello se hace la 
        //Sustitucion la cual se hace en la clase principal pero eso ya se vera arriba
        //Solucion
     int IinteligenciaMedia.inteligencia()
        {
            return 100;
        }
    int IinteligenciaAlta.inteligencia()
    {
        return 120;
    }
    }
}
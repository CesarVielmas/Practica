using System;
namespace Delegados
{
//Ahora lo que se vera son los delegados ,los delegados por su definicion en español son personas que son encargadas
//De diferentes personas para realizar las tareas , en programacion no es muy diferente , lo que hara es que
//El que delegado que creamos , tome metodos de cualquier clase siempre y cuando cumpla con el mismo tipo
//Del delegado y o parametros que tiene el metodo en especifico , cabe aclarar que es muy similar como los
//Apuntadores de c++ y tambien aclarar que C# es de los pocos o unicos que contiene los delegados , lambdas y
//Predicados
//Ejemplo
    class Delegadosxd
    {
        static void Main(string[] args)
        {
            //Creando objeto del tipo delegado
            Delegadoxd valor1 = new Delegadoxd(saludo.saludito);
            //Llamandolo , dandole el parametro que pide
            valor1("Cesar Alejandro Vielmas Salais");
             //Creando objeto del tipo delegado
            Delegadoxd valor2 = new Delegadoxd(despedida.despedidaxd);
            //Llamandolo , dandole el parametro que pide
            valor2("Mauricio Aguilar Ponce Puto");
        }
        //Creacion del delegado con la palabra reservada delegate
        //Luego se le pasa el tipo que debe ser el delegado y los metodos que tomara
        //Y por ultimo el nombre y los parametros y debe de cerrarse , no lleva llaves
        delegate void Delegadoxd(string parametro);
    }
    //Creacion de la clase
    class saludo
    {
        //Constructor
        public  saludo()
        {

        }
        //Metodo que tomara el delegate , se hara static para no tener que crear un objeto y instanciarlo
        public static void saludito(string saludo)
        {
            System.Console.WriteLine("Hola buenos dias "+saludo);
        }
    }
    //Creacion de la segunda clase
    class despedida
    {
        //Constructor
        public despedida()
        {

        }
        //Metodo que tomara el delegate , se hara static para no tener que crear un objeto y instanciarlo
        public static void despedidaxd(string despedida)
        {
            System.Console.WriteLine("Hola ya me voy "+despedida);
        }
    }
}
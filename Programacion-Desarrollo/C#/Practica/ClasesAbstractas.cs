using System;
namespace ClasesAbstractas
{
    //Lo que se vera ahora son las clases abstractas , estas clases son casi siempre la cuspide de la herencia
    //Ya que lo que hacen es obligar a las demas clases que hereden de el a sobreescribir el metodo que tiene
    //Es como una interface pero de herencia para que sea la cuspide de una clase , esto en lo que se diferencia
    //De la interface es que la interface obliga a el programador a que asigne todos sus metodos dentro de esta
    //Y la clase abstracta a sobreescribir y asignar el metodo abstracto nada mas , tambien una clase abstracta
    //Es abstracta cuando minimo tiene 1 metodo abstracto , aunque tuviera 1000 metodos public pero solo 1
    //Metodo abstracto esta clase seria abstracta
    //Ejemplo de su uso
    class AbstractasClases
    {
        static void Main(string[] args)
        {
            //Llamando a los metodos de las clases creando objetos para ver su funcionamiento
            //Creando objeto para la clase Cuarto la cual , se tiene que igualar a una subclass
            //Ya que no se puede instanciar una clase abstracta
            Cuarto objeto1 = new CuartoPequeño();
            objeto1.NombreCuarto();
            objeto1.Piso();
            //Creando objeto para la clase CuartoPequeño
            CuartoPequeño objeto2 = new CuartoPequeño();
            objeto2.NombreCuarto();
            objeto2.Piso();
            System.Console.WriteLine("Numero de puertas del cuarto pequeño: "+objeto2.numeroPuertas());
            System.Console.WriteLine("Numero de ventanas del cuarto pequeño: "+objeto2.numeroVentanas());
            //Creando objeto para la clase CuartoPequeño
            CuartoGrande objeto3 = new CuartoGrande();
            objeto3.NombreCuarto();
            objeto3.Piso();
            System.Console.WriteLine("Numero de puertas del cuarto grande: "+objeto3.numeroPuertas());
            System.Console.WriteLine("Numero de ventanas del cuarto grande: "+objeto3.numeroVentanas());
            //Polimorfismo
            System.Console.WriteLine("-------------------------------------------------------------------");
            System.Console.WriteLine("Polimorfismo");
            objeto1 = objeto2;
            objeto1.NombreCuarto();
            objeto1= objeto3;
            objeto1.NombreCuarto();
            
        }
    }
    //Creacion de la interface que sera heredada 
    interface cuarto
    {
        int numeroPuertas();
        int numeroVentanas();
    }
    //Creacion de la clase abstracta
    abstract class Cuarto
    {
        //Creacion del metodo abstracto el cual obligara al usuario a sobreescribir el metodo cuando sera heredado
        public abstract void NombreCuarto();
        public void Piso()
        {
            System.Console.WriteLine("Tiene un piso el cuarto");
        }
    }
    class CuartoPequeño : Cuarto,cuarto
    {
        //Creacion de su constructor
        public CuartoPequeño()
        {
            System.Console.WriteLine("Es un cuarto Pequeño");
        }
        //Metodo obligado a poner por la herencia de la clase abstracta a sobreescribirla
        public override void NombreCuarto()
        {
            System.Console.WriteLine("El cuarto se llama Cuartito");
        }
        //Metodos obligados por la herencia a la interface
        public int numeroPuertas()
        {
            return 1;
        }
        public int numeroVentanas()
        {
            return 2;
        }
    }
    class CuartoGrande : Cuarto,cuarto
    {
        public CuartoGrande()
        {
            System.Console.WriteLine("Este es un cuarto grande");
        }
        public override void NombreCuarto()
        {
            System.Console.WriteLine("El cuarto se llama Cuartote");
        }
        public int numeroPuertas()
        {
            return 2;
        }
        public int numeroVentanas()
        {
            return 4;
        }
    }
}
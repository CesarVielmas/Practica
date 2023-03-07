using System;
namespace PooParte3
{
    //Se veran los constructores los constructores son las propiedades por defecto que tiene una clase o objeto
    // al llamar o crear un nuevo objeto , se le llama a un constructor en cualquier caso , una clase siempre
    //tendra un constructor por defecto el constructor puede ser asignado y se hace mediante un metodo con
    //el mismo nombre de la clase , ademas se pueden hacer sobrecargas de constructores tambien para mandar a 
    //llamar un constructor con parametros
    //ejemplo
    class Parte3Poo
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ejemplo de las caracteristicas basicas de una persona");
        //Aqui se le llama a el constructor en este caso como no tiene parametros se dejan vacios
            persona caracteristicas = new persona();
        //Aqui se muestra lo que es una sobrecarga de constructor , funciona como la sobrecarga de metodos
        //Solo que ayuda mucho y se tiene que llenar los parametros dependiendo del constructor al que se desea
        //acceder  
            persona caracteristicas2= new persona(2,3,2,3);
        //obteniendo el valor de manos , que esta encapsulado , con un metodo de acceso
            System.Console.WriteLine("obteniendo las manos las cuales son:"+caracteristicas.GetManos());

        //modificando el valor de manos con un metodo ya que esta encapsulado manos
        System.Console.WriteLine("modificando las manos teniendo 3:"+caracteristicas2.ModificarManos(3));
        


        }

    }

    class persona
    {
     //se encapsulan estas propiedades o campos de clase para que no se puedan modificar en otra clase
        private int manos;
        private int piernas;
        private int ojos;
        private int orejas;
        //generando el constructor
        public persona()
        {
            manos= 2;
            piernas=2;
            ojos=2;
            orejas=2;
            System.Console.WriteLine($"Aqui se genera un constructor y se le asigno unas propiedades basicas las cuales son: \n manos:{manos} piernas:{piernas} ojos:{ojos} y orejas:{orejas}");
        }
        //Sobrecarga de constructor 
        public persona(int manosxd=2,int piernasxd=2,int ojosxd=2, int orejasxd=2)
        {
            manos = manosxd;
            piernas = piernasxd;
            ojos = ojosxd;
            orejas = orejasxd;
            System.Console.WriteLine($"Aqui se genera un constructor de sobrecarga , el cual tiene parametros opcionales las cuales son: \n manos:{manos} piernas:{piernas} ojos:{ojos} y orejas:{orejas}");

        }
        //Metodo de acceso
    //Lo que hace el metodo de acceso es que envie la informacion de cierta propiedad para que pueda verse en 
    //alguna otra clase , es bastante util pues no permite modificaciones ni vistas las propiedades encapsuladas
    //aunque mediante este metodo de acceso si se pueda ver pues pertenece a la clase aunque no se puede modificar
    //por el momento pues si se quiere modificar se tiene que tener un parametro
    //los metodos de acceso tienen como convencion siempre llamarlo get al principio y despues el nombre del 
    //que obtendra esta informacion
        public int GetManos()
        {
            return manos;
        }
        //Aqui un ejemplo modificando manos pues esta encapsulado
        public int ModificarManos(int manosxdd)
        {
            manos = manosxdd;
            return manos;
        }

    }
}
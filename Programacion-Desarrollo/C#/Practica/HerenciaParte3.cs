using System;
namespace HerenciaParte3
{
    //Aqui se vera lo que es los principios de sustitucion , al hacer una superclass , se tiene de herencia a
    //Otras clases las cuales pueden llamar a los metodos o propiedades de esta superclass , algo de lo que
    //Sirve bastante ya que heredan esto para reutilizacion de codigo , aunque por otro lado los principios
    //de sustitucion dejan un amplio rango de posibilidades , pues mediante una super class se puede almacenar
    //los datos de su subclass , en la practica se ve mejor y a eso se le llama principios de sustitucion
    //Aunque lo malo es que mediante la superclass al crear un objeto y asignarle como parametro de constructor
    //El de su subclass no puede utilizar los metodos de esta subclass ni tampoco sus propiedades
    //Ejemplo    
    class Parte3Herencia
    {
        static void Main(string[] args)
        {
            //Creacion normal de una instancia a la superclase
            SuperClase objeto = new SuperClase();
            //Creacion normal de una instancia a la subclase
            Subclase objeto1 = new Subclase();
            //Lo interesante
            //A una superclase se le puede asignar el constructor de una subclase , esto para guardar dentro
            //De el objeto el contenido del constructor de esta subclase a ese objeto de tipo superclass
            //Aunque lo unico malo es que solo puede usar metodos de la superclase mas no de la subclase
            SuperClase objeto2 = new Subclase();
            //Creacion de un array de objeto
            SuperClase [] objeto3 = new SuperClase();
            //Aqui se puede ver como una superclase puede almacenar objetos de una subclase algo que una subclase
            //No puede hacer con las superclases 
            objeto3[0] = objeto1;
            objeto3[1] = objeto2;
            objeto3[2] = objeto;
            //Aqui un ejemplo de que una superclase se puede equivaler a una subclase pero una subclase
            //A una subclase no
            //Bien si se puede objeto3 = objeto1;
            //Error objeto1 = objeto3;


        }
    }
    //Creacion de la superclase
    class SuperClase
    {
        public SuperClase()//Creacion de su constructor
        {
            System.Console.WriteLine("Esto es una superclase");
        }
    }
    //Creacion de la subclase con herencia
    class Subclase : SuperClase
    {
        public Subclase() :base()//Creacion del constructor con herencia
        {
            //Añadirle el siguiente mensaje ademas del mensaje del constructor de la superclase
            System.Console.WriteLine("Esto es una subclase");
        }
    }
}
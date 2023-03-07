using System;
namespace HerenciaParte4
{
    //Ahora lo que se vera es el polimorfismo , esto del polimorfismo es muy importante a la hora de programar
    //Como su propio nombre lo dice , el polimorfismo , es cuando algo , cambia constantemente de forma
    //Se convierte de una cosa a otra cosa y no es algo fijo constantemente , esto tiene mucho que ver con los
    //Objetos creados por las clases , aqui se vera un ejemplo de como funciona , junto con las palabras 
    //Reservadas , virtual , override y new , las cuales son importantes , primero la virtual , esto hace que
    //Un metodo dentro de una clase que este siendo heredada a otras subclases les este dando especificamente
    //Ese metodo , que toda subclase que este siendo heradada obtendra ese metodo pero de esa superclase y no
    //La convierte ni la pone en la subclase solo la toma , la palabra new , se usa mucho y esta lo que hace
    //Es que cuando se tiene en la superclass un metodo que en la subclass es el mismo , se oculta el metodo
    //De la superclass y se pone el metodo de la subclass , el compilador de c# lo hace en automatico , aunque
    //Es una muy buena practica ponerlo cuando se quiera hacer eso y por ultimo la palabra override , esta 
    //Lo que hace como su nombre lo indica es que sobreescribe un metodo que sea virtual , por ello se usan
    //Ambas , para que se pase a ser su metodo de la subclass y se sobreescriba
    //Ejemplo
    class Parte4Herencia
    {
        static void Main(string[] args)
        {
            //Polimorfismo
            Vertebrados[] vertebrados = new Vertebrados[3];
            Chango vertebrados1 = new Chango("Jorgito");
            humano vertebrados2 = new humano("Gabriel");
            Vertebrados vertebrados3 = new Vertebrados("Animal");
            vertebrados[0] = vertebrados1;
            vertebrados[1] = vertebrados2;
            vertebrados[2] = vertebrados3;
            //Pasa de convertirse de un chango a un humano y de humano a un animal etc , eso es plomorfismo
        }
    }
    //Creacion de la superclass vertebrados
    class Vertebrados 
    {
        public Vertebrados(string nombre)
        {
            System.Console.WriteLine("Mi nombre es: "+nombre);
            
        }
        //Metodo Caminar
        public virtual void caminar()
        {
            System.Console.WriteLine("Puedo caminar");
        }
    }
    //Creacion de la subclass con herencia de vertebrados
    class Chango : Vertebrados
    {
        //Nombre de el constructor tomando el constructor de la superclase heredada vertebrados
        public Chango(string nombreChango):base(nombreChango)
        {
            System.Console.WriteLine("y soy un chango");
        }
        //Se sobreescribe lo que hay en caminar ya que chango puede caminar y trepar
        public override void caminar()
        {
            System.Console.WriteLine("Puedo trepar y caminar");
        }
    }
    //Subclass de la superclass de herencia de vertebrados
    class humano : Vertebrados
    {
        public humano(string nombreHumano):base(nombreHumano)
        {
            System.Console.WriteLine("y soy un humano");
        }
        //Aqui se oculta el caminar de vertebrado para solo mostrar el metodo caminar de humano con new
        public new void caminar()
         {
             System.Console.WriteLine("Puedo caminar y pensar");
         }
    }
}
using System;
namespace InterfacesParte1
{
//En esta etapa nueva ahora se vera lo que es una interface y su sintaxis basica,por definicion una interface
//Es aquella que asigna una regla en especifico que debe de cumplir si o si , una clase esto es bastante usado
//Ya que cuando se trabaja en un equipo de trabajo , se le da instrucciones o se le asigna que es lo que debe
//Contener ciertas clases para su creacion en objeto ,para hacer una interface , su sintaxis es muy similar
//A como se crea una clase , solo que en vez de usar la palabra reservada "class" se utiliza "interface"
//Tambien otra cosa es que las interface deben de llevar solamente metodos los cuales debe cumplir la clase
//En otras palabras le asignas el comportamiento obligatorio que debe contener una clase 
//Ejemplo
    class Parte1Interfaces
    {
        static void Main(string[] args)
        {
            //Creacion de objetos de las clases 
            SeresVivos objeto1 = new SeresVivos("Ballena");
            Humano Objeto2 = new Humano("Juanito");
            Planta Objeto3 = new Planta("Buganbilia");
            //Obteniendo sus metodos
            objeto1.Reproduccion();
            objeto1.Morir();
            Objeto2.Reproduccion();
            Objeto2.Morir();
            Objeto3.Reproduccion();
            Objeto3.Morir();
            Objeto3.Fotosintesis();
            //Polimorfismo
            System.Console.WriteLine("Polimorfismo");
            objeto1 = Objeto2;
            objeto1.Reproduccion();
            objeto1.Morir();
            objeto1= Objeto3;
            objeto1.Reproduccion();
            objeto1.Morir();
            
        }
    }
    //Creacion de la interface , la cual esta hecha para heredarsela a planta la que le exigira , que en sus
    //Comportamientos incluya uno que sea "Fotosintesis" y que sea void ya que estara vacio
    interface IPlantas
    {
        //Al asignarle comportamientos tambien no se deben usar los metodos de acceso publico o privado 
        //O protegidos "public, private , static, protected , etc etc" ya que no lo aceptan las interfaces
        //Las interfaces son solo para darle reglas a una clase , las cuales deben seguir sus comportamientos
        //Asignados dentro de la interface
        //Ejemplo de un comportamiento de la interface Iplantas
        void Fotosintesis();
    }
    //Creacion de superclass llamada SeresVivos
    class SeresVivos 
    {
        public SeresVivos(string nombre)
        {
            System.Console.WriteLine("Soy un ser vivo y mi nombre es: "+nombre);
        }
        public virtual void Reproduccion()
        {
            System.Console.WriteLine("Puedo reproducirme");
        }
        public virtual void Morir()
        {
            System.Console.WriteLine("Puedo morir");
        }
    }
    //Creacion de la subclass humano con herencia a seres vivos
    class Humano : SeresVivos
    {
        public Humano(string nombre):base(nombre)
        {
            System.Console.WriteLine("Tambien soy un humano");
        }
        public override void Reproduccion()
        {
            System.Console.WriteLine("Ya que soy un humano");
        }
         public override void Morir()
        {
            System.Console.WriteLine("Ya que soy un humano");
        }
    }
    //Creacion de la subclass planta con herencia a seres vivos y con herencia a la interface Iplanta
    //Para heredar 2 clases o mas se utilizan las comas "," las cuales hacen que incluyas varias clases 
    //O interfaces , las interfaces tambien algo importante , siempre van al final de la herencia , no pueden
    //Ir al principio
    //Ejemplo
    class Planta : SeresVivos,IPlantas //La interface siempre debe ir heredada al final 
    {
        public Planta(string nombre):base(nombre)
        {
            System.Console.WriteLine("Tambien soy una planta");
        }
        //Metodo obligatorio que debe llevar plantas gracias a la interface que fue heredada a ella
        public void Fotosintesis()
        {
            System.Console.WriteLine("Hago fotosintesis");
        }
         public override void Reproduccion()
        {
            System.Console.WriteLine("Ya que soy una planta");
        }
         public override void Morir()
        {
            System.Console.WriteLine("Ya que soy una planta");
        }
    }
}
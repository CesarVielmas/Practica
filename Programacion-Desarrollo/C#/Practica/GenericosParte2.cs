using System;
namespace GenericosParte2
{
//Ahora lo que se vera son los genericos con restricciones ,como ya se sabe los genericos toman todas las clases
//Que hay , ya que toma object , pero muchas veces , se necesitan poner restricciones para que solo tome
//Ciertas clases o objetos , para que no afecte al programa y para ello es lo que se vera, lo que se usa
//Es la palabra reseverda "where" que significa donde y se usan los 2 puntos ":" luego se pone la letra generica
//Que le quieras dar por ejemplo "<T>" se pone T y por ultimo el nombre de la interface
//Que necesita que cumplan las clases que podra obtener
//Ejemplo
    class Parte2Genericos
    {
        static void Main(string[] args)
        {
            //Aqui se hace una variable de clase generica la cual obtiene la clase adolecente  y solo puede
            //Obtener esa ya que tiene como restriccion tener la interface IidentificacionMayorEdad
            Adulto <Adolecente> adolecente = new Adulto<Adolecente>(1);
            //Aqui se le asigna y no da ningun error y todo esta bien
            adolecente.setAdulto(new Adolecente(20));
            //Lo que no se debe hacer:
            /*
            Adulto <niño> niño = new Adulto<niño>(1);
            adolecente.setAdulto(new niño(15));

            Esto no se puede hacer ya que el niño no contiene la interface identificacion adulto , aunque es
            logico que no la hiba a obtener ya que es un niño y asi funcionan las clases genericas con 
            restricciones
            */
        }
    }
    //Interface para la clase generica y las clases que se pueda incluir en clase generica
    interface IidentificacionMayorEdad
    {
        void nombreIdentificacion();
    }
    //Clase generica
    class Adulto <T> where T: IidentificacionMayorEdad //Restriccion de que interface deben tener las clases para usarlo
    {
        //Mismo codigo que la parte 1 para guardar objetos cumpliendo esa restriccion
        private int contador =0;
        private int i;
        private T[] Adultos;
        public Adulto(int i)
        {
            this.i = i;
            Adultos = new T[i];
        }
        public void setAdulto(T objeto)
        {
            Adultos[contador] = objeto;
            contador++;
        }
        public T getAdulto(int numero)
        {
            return Adultos[numero];
        }
    }
    //Clase niño de ejemplo
    class niño
    {
        private int edad;
        public niño(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
    }
    //Clase Adolecente que servira para la clase generica ya que si cumple su restriccion de tener 
    //Dicha interface
    class Adolecente : IidentificacionMayorEdad
    {
        private int edad;
        public Adolecente(int edad)
        {
            this.edad = edad;
            System.Console.WriteLine("La edad del adolecente es de: "+edad);
        }
        public int getEdad()
        {
            return edad;
        }
        public void nombreIdentificacion()
        {
            System.Console.WriteLine("INE");
        }
    }
}
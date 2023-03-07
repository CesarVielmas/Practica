using System;
namespace HerenciaParte1
{
    //En este primer ejeplo se vera lo que es la herencia con la superclass y la subclass ademas de el tipo
    //Object , Pero primero una pequeña explicacion de la herencia , la herencia en programacion es como la 
    //Herencia en la vida diaria , por ejemplo un abuelo hereda una propiedad al padre y el padre a los hijos
    //En dicho caso el padre tendria la propiedad del abuelo y los hijos tendrian las propiedades del abuelo y
    //Del padre, en programacion es similar , la herencia son clases que por si mismo comparten unas propiedades
    //Y comportamientos a otras clases , como se vera en el ejemplo , esto es muy muy eficaz para reducir mucho
    //La cantidad de codigo y ademas reutilizarlo , tambien una cosa importante es saber quien sera el que herede
    //Propiedades y quienes seran quienes tomen esas propiedades
    //Ejempplo
    class Parte1Herencia
    {
        static void Main(string[] args)
        {
       
            //Aqui se muestra la informacion de la superclass Empleado la cual no obtiene ningun valor de herencia
            //O Propiedad de herencia pero si hereda sus propiedades en este caso hereda las propiedades del 
            //Constructor y se las asigna a el otro constructor de jefe ya que hereda las propiedades de empleado
          System.Console.WriteLine("Empleado");
            Empleado.InfoEmpleado();
            //Aqui se muestra la informacion de la subclass de empleado osease jefe , la cul hereda propiedades
            //de Empleado en este caso hereda las propiedades del constructor 
            System.Console.WriteLine("----------------------------------------------------------------------\n--Jefe----------------------------------------------------------------");
            Jefe.InfoJefe();
            //Aqui se muestra la informacion de la subclass de jefe , la cual hereda las propiedades de jefe y asi
            //Mismo jefe tiene las propiedades de empleado asi que tambien se las hereda a director , mas que todo
            //A su constructor
            System.Console.WriteLine("----------------------------------------------------------------------\n--Director------------------------------------------------------------");
            Director.InfoDirector();
            System.Console.WriteLine("----------------------------------------------------------------------\n--Object--------------------------------------------------------------");
            //La clase object es una de las que ya vienen implicitas dentro del lenguaje c# esta misma tambien
            //Se le llama como superclass universal , ya que cualquier clase siempre estara por debajo de 
            //Object esto quiere decir que object siempre heredara sus propiedades a todas las clases siempre
            //Ejemplo
            Empleado valor1 = new Empleado();
            Jefe valor2 = new Jefe();
            Empleado.Equals(valor1 , valor2);//Este metodo no existe en ninguna clase que nosotros creamos sin embargo sale
            //Ya que pertenece a la superclass universal de object
        }
    }
    //Se crea Empleado en la cima de la herencia ya que se desea heredar de empleado sus propiedades
    //O comportamientos ya que jefe o director tienen en comun estas mismas propiedades y algunos comportamientos
    //De Empleados
    class Empleado
    {
        //Creacion del constructor con las propiedades a heredar de empleado
        public  Empleado()
        {
            System.Console.WriteLine("Tengo un salario");
            System.Console.WriteLine("Estoy dado de alta en el seguro");
            System.Console.WriteLine("Soy un pilar para la empresa");
        }
        //Metodo que tambien hereda la clase empleado
        public static void InfoEmpleado()
        {
            Empleado ejemplo = new Empleado();
        }
    }
    //Aqui se crea otra clase llamada jefe la cual obtiene de herencia a empleado sus propiedades
    class Jefe : Empleado
    {
        //Creacion del constructor de jefe , el cual hereda del constructor de empleado sus propiedades y 
        //Se le asigna tambien dentro de este mismo
        public  Jefe()
        {
            System.Console.WriteLine("Soy un rango superior a empleado");
        }
        //Este metodo se le da de herencia a director
        public static void InfoJefe()
        {
            Jefe ejemplo = new Jefe();
        }
    }
    //Creacion de la ultima subclase llamada director el cual hereda las propiedades y metodos de jefe y de
    //Empleado
    class Director : Jefe
    {
        //Creacion del constructor de director el cual obtiene las propiedades de jefe y de empleado
        public  Director()
        {
            System.Console.WriteLine("Tambien soy un rango superior a un jefe");
        }
        //Metodo exclusivo solo para director , pues aqui termina la herencia y este no hereda a ningun otra
        //Clase
        public static void InfoDirector()
        {
            Director ejemplo = new Director();
        }
    }
}
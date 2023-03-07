using System;
using System.Collections.Generic;
namespace DelegadosPredicadosxd
{
//Ahora se vera los delegados predicados , estos sirven muchisimo para hacer algun filtro a un array o a objetos
//Estos mismos solo aceptan parametros boleanos ya que retornan si es falso o verdadero , por ello se usan 
//Para hacer filtros , a diferencia de los delegate que sirven mucho para ahorrar codigo 
//Ejemplo
    class DelegadosPredicados
    {
        static void Main(string[] args)
        {
            //Para comprobar mejor la funcion del filtro o comprobacion , intente cambiar los valores
            //De cada objeto para ver
            
            //Se hace una lista para guardar a los objetos posteriores de la clase empleados
            List<Empleados> lista = new List<Empleados>();
            //Se hace el objeto o la instancia del objeto
            Empleados empleado1  = new Empleados();
            //Se usa la propiedad EDAD para almacenar el dato de la edad
            empleado1.EDAD = 20;
             //Se usa la propiedad NOMBRE para almacenar el dato de el nombre
            empleado1.NOMBRE = "Cesar";
             //Se usa la propiedad SALARIO para almacenar el dato de el salario
            empleado1.SALARIO = 20000;
             //Se hace otro objeto o instancia de la clase empleados
            Empleados empleado2  = new Empleados();
             //Se usa la propiedad EDAD para almacenar el dato de la edad
            empleado2.EDAD = 21;
             //Se usa la propiedad NOMBRE para almacenar el dato de el nombre
            empleado2.NOMBRE = "pepe";
             //Se usa la propiedad SALARIO para almacenar el dato de el salario
            empleado2.SALARIO = 40000;
             //Se crea otro objeto o instancia de la clase empleados
            Empleados empleado3  = new Empleados();
             //Se usa la propiedad EDAD para almacenar el dato de la edad
            empleado3.EDAD = 40;
             //Se usa la propiedad NOMBRE para almacenar el dato de el nombre
            empleado3.NOMBRE = "Jose";
             //Se usa la propiedad EDAD para almacenar el dato de el salario
            empleado3.SALARIO = 80000;
             //Se almacenan los objetos creados para almacenar sus propiedades
             //Edad, Nombre, Salario , para que puedan ser comparados posteriormente
             //Para eso se usa el metodo AddRange el cual lo que hace es que le asigna varios
             //Valores ,los que sean ya que es una clase generica , aunque obviamente cumpliendo 
             //Con el valor generico asignado , en este caso objetos de tipo empleado en un array 
             //De objetos para hacer lo que se dijo anteriormente
            lista.AddRange(new Empleados[] {empleado1,empleado2,empleado3});
             //Aqui entra en funcionamiento el predicado , el cual esa es la forma de crearlo
             //Para crear un objeto de tipo predicado en este caso se le asigno como nombres
             //Comprobacion y como se ve al final debe recibir como parametro un metodo de tipo boleano
             //Pues como ya se dijo lo que hace predicate , es para hacer filtros o comparar, en este
             //Caso filtros
             //Creacion del objeto tipo predicate llamado comprobacion1 tomando como parametro 
             //El metodo boleano AlguienLlamadoCesarComprobar
            Predicate<Empleados> Comprobacion1 = new Predicate<Empleados>(AlguienLlamadoCesarComprobar);
             //Creacion del objeto tipo predicate llamado comprobacion2 tomando como parametro 
             //El metodo boleano AlguienConBuenSalarioComprobar
            Predicate<Empleados> Comprobacion2 = new Predicate<Empleados>(AlguienConBuenSalarioComprobar);
            //Creacion del objeto tipo predicate llamado comprobacion3 tomando como parametro 
             //El metodo boleano AlguienMayorComprobar
            Predicate<Empleados> Comprobacion3 = new Predicate<Empleados>(AlguienMayorComprobar);
            //Aqui lo que se hace es usar el metodo de las list llamado Exists y lo que hace es comprobar 
            //Mediante un predicado si existe o no , lo que se comprueba en el metodo boleano y si , si hay
            //Manda un true y si no un false , este hace la comprobacion en general y el filtro
            bool Resultado1 = lista.Exists(Comprobacion1);
            if(Resultado1 == true)
            {
                System.Console.WriteLine("Existe alguien llamado cesar");
            }
            else
            {
                System.Console.WriteLine("No existe alguien llamado cesar");
            }
            bool Resultado2 = lista.Exists(Comprobacion2);
            if(Resultado2 == true)
            {
                System.Console.WriteLine("Existe alguien con buen salario");
            }
            else
            {
                System.Console.WriteLine("No existe alguien con buen salario");
            }
            bool Resultado3 = lista.Exists(Comprobacion3);
            if(Resultado1 == true)
            {
                System.Console.WriteLine("Existe alguien mayor de edad");
            }
            else
            {
                System.Console.WriteLine("No existe alguien mayor de edad");
            }
            
        }
        //Metodo estatico boleano que comprueba si edad es mayor que 18 y si es verdad manda un true
        //Y si no un false
        static bool AlguienMayorComprobar(Empleados comprobacion)
        {
            if(comprobacion.EDAD>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Lo mismo que el primero pero ahora comprueba si existe el nombre "Cesar"
        static bool AlguienLlamadoCesarComprobar(Empleados comprobacion)
        {
            if(comprobacion.NOMBRE =="Cesar")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Lo mismo pero ahora comprueba si el salario es bueno
        static bool AlguienConBuenSalarioComprobar(Empleados comprobacion)
        {
            if(comprobacion.SALARIO>=30000.23)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //Creacion de la clase de ejemplo empleado
    class Empleados
    {
        //Campos de clase
        private string nombre;
        private int edad;
        private double salario;
        //Constructor
        public Empleados()
        {

        }
        //setter para la propiedad nombre
        public string LlenarNombre(string nombre)
        {
            this.nombre = nombre;
            return nombre;
        }
        //Creacion de la propiedad nombre
        public string NOMBRE
        {
            get{return nombre;}
            set{ nombre = LlenarNombre(value);}
        }
        //Setter para la propiedad edad
         public int LlenarEdad(int edad)
        {
            this.edad = edad;
            return edad;
        }
        //Creacion de la propiedad edad
        public int EDAD
        {
            get{return edad;}
            set{ edad = LlenarEdad(value);}
        }
        //Setter de la propiedad salario
         public double LlenarSalario(double salario)
        {
            this.salario = salario;
            return salario;
        }
        //Creacion de la propiedad salario
        public double SALARIO
        {
            get{return salario;}
            set{ salario = LlenarSalario(value);}
        }
    }
}
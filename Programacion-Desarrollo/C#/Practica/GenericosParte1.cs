using System;
namespace GenericosParte1
{
//Ahora aqui se vera lo que son los genericos o programacion generica ,esto sirve mucho para ahorrar mas espacio
//En el codigo , tiene ventajas ,de las clases y construccion de objetos , los genericos se usan mas que todo
//Para cuando se necesite obtener el valor de un objeto , cuando este mismo retorna el ejemplo , cuando nosotros
//Estamos creando una clase y por alguna razon se obtiene un objeto de un metodo , se tiene que hacer un casting
//Para obtener el valor que se esta esperando de ese objeto asi mismo si es mas complejo y se obtiene un objeto
//De otro objeto seria entonces hacer un casting de tipo objeto para el primero y despues hacer otro para obtenr
//El valor del que se requiere de ese objeto
//Ejemplo
    class Parte1Genericos
    {
        static void Main(string[] args)
        {
            //Usando una clase con programacion orientada a objetos

            //Se obtiene o se hace una instancia a la clase para la creacion del objeto
            //Pasandole 5 pues ese valor sera el limite del array
            HacerArray arrayxd = new HacerArray(5);
            //Rellenando el array
            arrayxd.CreandoArray("Hola");
            arrayxd.CreandoArray("Hola");
            arrayxd.CreandoArray("Hola");
            arrayxd.CreandoArray("Hola");
            arrayxd.CreandoArray("Hola");
            //Haciendo un casting ya que es necesario si no y se se pusiera el dar array el metodo en el
            //Write line daria como resultado un objeto pues devuelve un objeto por ello se le asigna a una
            //Variable del mismo dato de el parametro del array y se imprime en consola
            string datoDeArray = (string)arrayxd.DarArray(2);
            System.Console.WriteLine(datoDeArray);

            //Usando la programacion generica o genericos
            //Creacion de la instancia para una clase generica
            //Para hacer la creacion de la instancia para una clase generica se usa <> y se le pone el tipo
            //Que recibira el objeto para su creacion , como es generica puede recibir cualquier parametro
            //De la clase object osease casi todo , ya que lo engloba todo , despues de eso se le deben asignar
            //Valores correspondientes al objeto creado  
            //Objeto de la clase generica con strings
            HacerArray2<string> array2xd = new HacerArray2<string>(2);
            array2xd.CreandoArray("Hola");
            array2xd.CreandoArray("Como estas");
            //Objeto de la clase generica con doble
            HacerArray2<double> array3xd = new HacerArray2<double>(1); 
            array3xd.CreandoArray(23.54);
            //Aqui se puede apreciar la mayor ventaja de los objetos genericos , que estos mismos , como son
            //Del mismo valor que la variable guardada se le pueden guardar a otra variable de ese mismo valor
            //Lo del objeto sin hacer un casting gracias al <> que se le asigno
            string datoArray = array2xd.DarArray(1);
            double datoarrayxd = array3xd.DarArray(0);
            //Imprimiendo en consola
            System.Console.WriteLine(datoArray+datoarrayxd);

        }
    }
    //Creacion de clase
    class HacerArray
    {
        //Campos de clase
        private int i;
        private int contador=0;
        //Cracion del campo de clase que toma un objeto object el cual puede ingresar cualquier dato de la
        //Clase object
        private Object[] arrayxd;

        //Constructor asignandole de que tamaño sera el array de objetos 
        public HacerArray(int i)
        {
            this.i = i;
            arrayxd = new Object[i];
        }
        //Metodo para crear el array , como la clase object acepta cualquier valor string, int , double etc 
        //Pues se le puede asignar cadenas de texto o valores numericos , cuando este mismo pide un objeto
        //En el parametro del metodo , si fuera otro objeto seria mandarle el objeto de esa clase y no como
        //Sucede con el objeto de tipo object ya que engloba casi todo del compilador
        public void CreandoArray(Object objeto)
        {
            //Se hace una clausula o verificacion
            if(i <= i)
            {
                //Si no sobrepasa el array se hace esto el cual le pasa el parametro , del objeto dado 
                //Por el usuario en el primero , segundo , tercero parametro etc , gracais a contador 
                //Que aumenta cada que pasa por ahi o se usa el metodo 
            arrayxd[contador]=objeto;
            contador++;
            }
            //Si no , no hace nada
            else
            {
                System.Console.WriteLine("Sobrepasa lo permitido en el array");
            }
        }
        //Aqui solo hace un getter que retorna el valor que tendra que ser casteado para que sea del valor
        //Que le pide la variable
        public Object DarArray(int contador)
        {
            return arrayxd[contador];
        }
    }
    //Clase generica , para hacerla una clase generica se ponen <> estas 2 y el programador le puede asignar
    //Una letra , la que sea , aunque por convencion se usa la T y quedaria <T>  
    //Ahora esta clase es generica por lo cual tiene heredada el atributo object dentro de la <T> por lo cual
    //Tiene cualquier valor esa <T> ya que object engloba todo por lo mismo se cambia donde hiba object 
    //Por <T> para que sea mas legible y menos codigo    
     class HacerArray2 <T> 
    {
        //Campos de clase
        private int i;
        private int contador=0;
        //Cracion del campo de clase que toma un objeto object el cual puede ingresar cualquier dato de la
        //Clase object
        private T [] arrayxd;

        //Constructor asignandole de que tamaño sera el array de objetos 
        public HacerArray2(int i)
        {
            this.i = i;
            arrayxd = new  T [i];
        }
        //Metodo para crear el array , como la clase object acepta cualquier valor string, int , double etc 
        //Pues se le puede asignar cadenas de texto o valores numericos , cuando este mismo pide un objeto
        //En el parametro del metodo , si fuera otro objeto seria mandarle el objeto de esa clase y no como
        //Sucede con el objeto de tipo object ya que engloba casi todo del compilador
        public void CreandoArray(T objeto)
        {
            //Se hace una clausula o verificacion
            if(i<=i)
            {
                //Si no sobrepasa el array se hace esto el cual le pasa el parametro , del objeto dado 
                //Por el usuario en el primero , segundo , tercero parametro etc , gracais a contador 
                //Que aumenta cada que pasa por ahi o se usa el metodo 
            arrayxd[contador]=objeto;
            contador++;
            }
            //Si no , no hace nada
            else
            {
                System.Console.WriteLine("Sobrepasa lo permitido en el array");
            }
        }
        //Aqui solo hace un getter que retorna el valor que tendra que ser casteado para que sea del valor
        //Que le pide la variable
        public T DarArray(int contador)
        {
            return arrayxd[contador];
        }
    }
}
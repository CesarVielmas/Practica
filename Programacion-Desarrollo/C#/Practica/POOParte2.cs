using System;
namespace PooParte2
{
    //Ahora lo que se vera encapsulacion  y convenciones de la encapsulacion , las convenciones son hechos o
    //cosas que se podrian hacer pero que no son del todo correctas , la encapsulacion es aquella que hace que
    //el programa muestre mas seguridad a la hora de tomar los datos o metodos de una clase para un objeto
    //en su mayoria o casi siempre los metodos o comportamientos y solo algunos , deberian poder ser llamados
    //para su ejecucion en otra clase ,en cambio las propiedades casi siempre no deben de ser publicas y deben
    // ser encapsuladas , en la encapsulacion esta el tipo public y private aunque hay mas , pero en su mayoria
    //esos 2 son los principales los cuales como su propio nombre lo dice , los public es para acceso publico
    //osea que puede ser llamado desde cualquier otra clase o los private que solo pueden ser usados dentro de
    //su "ambito" osease su clase tambien las convenciones de estos 2 seria que los public , deben de ir su 
    //primera letra en mayuscula ejemplo de metodo con public"public float SumaNumeros() { }" y por el contrario los
    //de tipo private deben de ir primero con una minuscula , por ejemplo "private float sumaNumeros() {}"
    //usando el camelCase y esas serian sus convenciones
    //Ejemplo
    class MetodoMainParaPooParte2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Este sera un programa para obtener el area de un cuadrado mediante su base y su altura");
            area programa = new area();
            programa.AreaCuadrado();


        }
    }

    class area
    {
        //Aqui irian las propiedades , en este caso no hay propiedades o campos de clase

        //Aqui se ve como AreaCuadrado tiene la mayuscula en cada inicio de palabra lo cual es una convencion
        //de el encapsulamiento public
        public void AreaCuadrado()//Metodo o comportamiento de la clase o objeto
        {
            System.Console.WriteLine("Debe ingresar la base y la altura");
            float baseXD = baseCuadrado();
            float AlturaXD = alturaCuadrado();
            System.Console.WriteLine($"Su area seria de {baseXD * AlturaXD}");

        }

        //Como es private la primera letra es minuscula y las demas pueden ser la primera letra mayuscula
        
        private float baseCuadrado()//Encapsulamiento tipo private pues solo se usara dentro de la clase
        {
            System.Console.WriteLine("Ingrese la base");
            float laBase = float.Parse(System.Console.ReadLine());
            return laBase;
        }
         private float alturaCuadrado()//Encapsulamiento tipo private pues solo se usara dentro de la clase
        {
            System.Console.WriteLine("Ingrese la altura");
            float laAltura = float.Parse(System.Console.ReadLine());
            return laAltura;
        }
    }


}
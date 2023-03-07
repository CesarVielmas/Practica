using System;
namespace POOParte1
{
//Creacion de clases y instancias ahora lo que se vera que es de programacion orientada a objetos son las clases
//y las instancias , pero primero que nada recordar que una clase es para generar un objeto , este objeto el cual
//es personalizado , puede ser creado para facilitar el trabajo y ademas de eso dividir el codigo en varias
//partes escenciales para que al momento que haya un error no se caiga todo el programa como tal y que se pueda
//facilitar la localizacion del problema por los diferentes objetos a esto de dividir el codigo en partes
//por clases para crear varios objetos se llama 

//Este es una clase para la creacion de un objeto llamado POO 
    class POO
    {
//Aqui irian sus propiedades , osease sus propiedades son las caracteristicas que tiene el objeto ,por ejemplo
//algun valor flotante de algun tamaño como su area , o un string con el nombre de el color que es este objeto
//las posibilidades son varias ,pero siempre las propiedades van dentro de la clase y fuera de las funciones
//o metodos el cual es el comportamiento del objeto tambien a las propiedades de un objeto se les conoce como
//campo de clase


        //Ahora aqui en este metodo o funcion se podria decir que es el comportamiento o lo que hace el objeto
        //el cual puede ser llamada dependiendo si es public o private este varia , pero su funcion es el
        //comportamiento o lo que hace el objeto
        static void Main(string[] args)
        {
            System.Console.WriteLine("Programa para calcular el area de un triangulo");
            triangulo areaxd = new triangulo();//Aqui se le asigna el objeto ya creado triangulo a "areaxd"
            //Aqui se hace una instancia , la cual es tomar un metodo o por su traduccion , comportamiento
            //del objeto , por ejemplo la clase triangulo o objeto triangulo tiene el comportamiento o metodo
            //llamada area la cual esta junto con otros metodos en conjunto para obtener el area de un triangulo
            // y la cual la esta llamando gracias a que area tiene las propiedades y comportamientos del objeto
            //triangulo y ya solo lo toma y funciona perfectamente
            areaxd.Area();
        }


    }

    //en este caso creare una nueva clase para ser llamada desde la clase POO 
class triangulo
{
//propiedades o campo de clases
//en este caso no tiene pues el usuario se lo asignara
//pero un ejemplo de una propiedad o clase de campo podria ser en su caso "float baseXD=23.45F;" 
//por ejemplo claro aunque en este caso no las ocupo
public  void Area()//estos son los metodos o comportamientos de el objeto , el cual fue llamado en el metodo main
{
float Basexd = BaseTriangulo();
float alturaxd = AlturaTriangulo();
System.Console.WriteLine($"La area de su triangulo daria como resultado: {(Basexd * alturaxd)/2}"); 
}

public  float BaseTriangulo()
{
float BaseXD;
System.Console.WriteLine("Ingrese el valor de la base");
try
    {
BaseXD = float.Parse(System.Console.ReadLine());
 }
 catch(FormatException ex)
 {
System.Console.WriteLine("Ingrese un numero , no una linea de texto, se seteara y se tendra 0 su valor de base");
BaseXD = 0;

 }
 catch(Exception ex)
 {
System.Console.WriteLine("Error: "+ex.Message+"Se seteara y se tendra 0 en su valor de base");
BaseXD = 0;
 }

return BaseXD;
}

public  float AlturaTriangulo()
{
float AlturaXD;
System.Console.WriteLine("Ingrese el valor de la altura");
try
    {
AlturaXD = float.Parse(System.Console.ReadLine());
 }
 catch(FormatException ex)
 {
System.Console.WriteLine("Ingrese un numero , no una linea de texto, se seteara y se tendra 0 su valor de base");
AlturaXD = 0;

 }
 catch(Exception ex)
 {
System.Console.WriteLine("Error: "+ex.Message+"Se seteara y se tendra 0 en su valor de base");
AlturaXD = 0;
 }

return AlturaXD;
}

}

}
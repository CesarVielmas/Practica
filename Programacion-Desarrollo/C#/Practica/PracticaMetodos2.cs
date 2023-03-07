using System;
namespace PracticaMetodos2
{
    class PracticaMetodos2xd
    {
        //Ejemplo de una sobrecarga basica la cual hace que los metodos se puedan llamar exactamente igual 
        //pero dependiendo de los valores que se tomen en los parametros del metodo ira hacia ese metodo en particular 
        //bastante eficiente esta caracteristica de la sobrecarga de metodos
        /*

        static void Main(string[] args)
        {
            int opcion1,opcion2,opcion3,opcion4;
            opcion1=opcion2=opcion3=40;
         Opcion(opcion1,opcion2,opcion3);

        }

        static void Opcion(int opcion1)
        {
            System.Console.WriteLine("Muy bien ingresaste solamente un valor");
        }
        static void Opcion(int ipcion1 , int opcion2)
        {
            System.Console.WriteLine("muy bien ingresaste 2 valores");
        }
        static void Opcion(int opcion1,int opcion2,int opcion3)
        {
            System.Console.WriteLine("muy bien ingresaste 3 valores");
        }
        static void opcion(int opcion1 , int opcion2, int opcion3 , int opcion4)
        {
            System.Console.WriteLine("muy bien ingresaste 4 valores");
        }
*/
//ejemplo de un metodo con parametros opcionales , este metodo es bastante util cuando no se usa la sobrecarga
//de metodos , ya que algunos lenguajes de programacion no soportan la sobrecarga de metodos , una opcion util
//para situaciones en especifico con otro lenguaje de programacion
/*
static void Main(string[] args)
{
int valor1,valor2,valor3,valor4;
System.Console.WriteLine("programa para sumar numeros");
System.Console.WriteLine("Primero ingrese el primer numero");
valor1= int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Ahora el segundo");
valor2= int.Parse(System.Console.ReadLine());
System.Console.WriteLine(practica(valor1,valor2));
}
static int practica(int numero1,int numero2, int numero3 = 0 ,int numero4= 0) => numero1+numero2+numero3+numero4;
     */
     }
}
using System;

namespace Ejemplo
{
    class Ejemploxd
    {
            static void Main(string[] args)
        {
        /*Concatenacion con signo dolar $ exclusiva de lenguaje c#
        string shola="hola";
        string sbienvenido="bienvenido";
        byte bedad=23;
        byte bedad1= bedad;
        bedad1++;
        System.Console.WriteLine($"{shola} {sbienvenido} como estas amigo yo tengo {bedad} casi {bedad1}");
        */

        /*Concatenacion normal de todos los lenguajes
        string shola="hola";
        string sbienvenido="bienvenido";
        byte bedad=23;
        byte bedad1= bedad;
        bedad1++;
        System.Console.WriteLine(shola+" "+sbienvenido+" como estas amigo yo tengo "+bedad+" casi "+bedad1);
        */

       /*Exclusivo del lenguaje c# para declarar varias variables a la vez
       byte hola1,hola2,hola3,hola4;
        hola1=hola2=hola3=hola4=40;
       System.Console.WriteLine($"{hola1} {hola2} {hola3} {hola4}");
        */

        /*Conversion explicita o casting
           
           int calor = 30;
        double calorExacto=31.8;
        calor = (int)calorExacto;
        System.Console.WriteLine(calor);

        */
        
        /*TypeConvert Convertir de texto a un numero o viceversa , algo que el casting no lo permite

        int valor1,valor2,resultado;
        string valor1Cadena,valor2Cadena;

        System.Console.WriteLine("Escriba 2 valores para sumarlos");
        System.Console.WriteLine("1-");
        valor1=int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("2-");
        valor2=int.Parse(System.Console.ReadLine());
        resultado= valor1 + valor2;
        System.Console.WriteLine($"el resultado de {valor1} + {valor2} es {resultado}");
        */

       /*Ejemplo con constantes
        const string EDAD = "20";
        const string ESTADO="coahuila";
        string hola= "me encantaria conocerte";
        string hola1= "me encantaria follarte";
        float edad;
        edad=float.Parse(EDAD);
        System.Console.WriteLine($"hola tengo {edad} y son nacido en {ESTADO}"+ " {1}",hola,hola1);
       */
        }
    }
}
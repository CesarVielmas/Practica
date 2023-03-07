using System;
namespace Lambdas
{
//Ahora lo que se vera son las lambdas , las expresiones lambas sirven para simplificar una funcion en el area
//De un parametro , se usan muy frecuentemente en los delegados , ya que muchas de sus funciones pueden ser
//Simples ,ademas de ahorrar espacio de codigo y que sea menos complejo ya que tambien es algo mas facil de
//Interpretar que las funciones o metodos que es lo mismo , estas expresiones lambdas , se emplean de la 
//Siguiente manera "=>" a esto se llama lamba y sus reglas basicas son que los parametros van al principio
//Osease los parametros como si fueran los parametros de una funcion y se utiliza lambda => y luego se ponen
//Lo que hara el codigo , ejemplo (num1 => System.Console.WriteLine(num1)) cuando se tienen varios parametros
//Se usa un parentesis en los parametros y cuando se tienen varias lineas de codigo se usan las llaves y cada
//Linea de codigo termina en un punto y coma ejemplo ((num1,num2)=>{System.Console.WriteLine("Suma:");num1+num2})
//Ahora se vera un ejemplo basico ocn lambda
    class Lambdasxd
    {
        static void Main(string[] args)
        {
            //Sin usar lambda y teniendo que crear la funcion
            Sumaxd objetoDelegado = new Sumaxd(sumar);
            objetoDelegado(4,6);
            //Usando lambda y ahorrandonos la funcion
            Sumaxd objetoDelegado2 = new Sumaxd((numero1,numero2)=> numero1+numero2);
            System.Console.WriteLine("La suma seria con lambda: "+objetoDelegado2(5,6));
        }
        //Creando delegado
        public delegate double Sumaxd(double num1,double num2);
        //Funcion para el delegado
        static double sumar(double num1,double num2)
        {
            System.Console.WriteLine("La suma seria con funcion: "+(num1+num2));
            return num1 + num2;
        }
    }
}
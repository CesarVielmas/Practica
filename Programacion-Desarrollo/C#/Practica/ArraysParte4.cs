using System;
namespace ArraysParte4
{   
    //Lo que se vera son los arrays como parametros de metodos y como devolucion de metodos osease return
    //Estos bastantes utiles para pasarle un arreglo o generar un arreglo mediante el usuario aqui unos
    //Ejemplos de sus usos
    class Parte5Arrays
    {
        static void Main(string[] args)
        {
        //Generando el metodo 
        int[] ArrayParaMetodo = new int[5];
        //Asignandole valores a cada posicion
        ArrayParaMetodo[0]= 10;
        ArrayParaMetodo[1]= 9;
        ArrayParaMetodo[2]= 18;
        ArrayParaMetodo[3]= 7;
        ArrayParaMetodo[4]= 6;
        //Llamando al metodo
        ImprimiendoValores(ArrayParaMetodo);
        //Llamando al metodo que retorna un array
        double[] ArrayQueArrojaElMetodo = ArrayDelMetodo();
        int contador = 0;
        foreach(double Arrayxd in ArrayQueArrojaElMetodo)
        {
            System.Console.WriteLine($"Valor del array {contador} de los valores que arrojo el metodo: "+Arrayxd);
            contador++;
        }
         }
         //Metodo el cual tiene como entrada un array
         static void ImprimiendoValores(int[]valores)
         {
             //Contador para contar cada array que fue traido del metodo
             int contador = 0;
             //Un foreach para poner en pantalla los valores del arreglo tomado
             foreach(int valoresParaForeach in valores)
             {
                 System.Console.WriteLine($"Valor del array {contador} de el array para el metodo: "+valoresParaForeach);
             contador++;
             }
         }
         //Metodo el cual retornara un array
         static double[] ArrayDelMetodo()
         {
             System.Console.WriteLine("¿Cuantos valores quiere en array?");
             string valores = System.Console.ReadLine();
             int CantidadDeValoresParaArray = int.Parse(valores);
            double [] valorParaCadaArray = new double[CantidadDeValoresParaArray];
             for(int i = 0; i<CantidadDeValoresParaArray; i++)
             {
                 System.Console.WriteLine($"Digame el valor de la posicion {i}");
                 valores= System.Console.ReadLine();
                 valorParaCadaArray[i] = double.Parse(valores);
               
             }
               return valorParaCadaArray;
         }
    }
}
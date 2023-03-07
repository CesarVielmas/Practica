using System;
using System.Collections.Generic;
using System.Text;
//se usa el mismo nombre de namespace que el de PooParte5(1) para que puedan conectarse y obtenga las clases
//por eso obtiene el mismo nombre para juntar ambos archivos fuente
namespace PooParte5
{ 
    //Aqui esta la clase para crear el objeto imprimir numeros
    public partial class imprimirNumeros //se divide la clase en 2 
    {
        //Campos de clase o propiedades de la clase
        private int numero1=0;
        private int numero2=0;
        private int numero3=0;

        public imprimirNumeros()//constructor sin parametros
        {
            System.Console.WriteLine($"Constructor definido aunque predeterminado numero1 = {numero1}, numero2 = {numero2}, numero3 = {numero3}");
        }
     }
        public partial class imprimirNumeros //segunda parte de la clase imprimirNumeros
        {
        public imprimirNumeros(int numero1, int numero2 , int numero3)//Sobrecarga de constructor con parametros
        {
            this.numero1 = numero1;//referencia a this pues como se llaman igual ambos parametros se usa
            this.numero2 = numero2;//tomando primero los campos de clase o propiedades de la clase y
            this.numero3 = numero3;//igualandola al parametro de la sobrecarga del constructor
            System.Console.WriteLine($"Sobrecarga de constructor con parametros numero1= {numero1}, numero2= {numero2}, numero3= {numero3}");

        }

    }
 }
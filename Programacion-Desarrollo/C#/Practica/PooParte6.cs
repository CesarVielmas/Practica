using System;
namespace PooParte6
{
//En esta parte se vera como incluir un objeto como parametro en un metodo 
//ejemplo
    class Parte6
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Este sera un programa para sumar 2 numeros");
        suma objetito1 = new suma();
        suma objetito2 = new suma(4,5);
        //Se llama el metodo y se le da el objeto a el consolo write line para que lo escriba en consola
        //Pues el objeto solo retorna valores
        System.Console.WriteLine("La suma de el primer objeto fue de: "+objetito1.LaSuma(objetito1)); 
        System.Console.WriteLine("La suma de el segundo objeto fue de: "+objetito2.LaSuma(objetito2));
        }
        //Metodo con un objeto como parametros el cual toma sus propiedades
    }

    class suma //creacion de la clase para hacer un objeto
    {
        //Propiedades o campos de clase
        private float numero1;
        private float numero2;

        public suma()//Creacion del constructor
        {
            numero1 = 0;
            numero2 = 0;
            System.Console.WriteLine($"valores por ahora numero 1 = {numero1}, numero 2 = {numero2}");
        }
        public suma(int numero1 , int numero2)//Creacion de constructor de sobrecarga
        {
            //Uso de this para referirse a el tipo de variables de los campso de clase y que se sobreescriban
            //Con los datos de los parametros
            this.numero1 = numero1;
            this.numero2 = numero2;
            System.Console.WriteLine($"valores por ahora numero 1 = {numero1}, numero 2 = {numero2}");
        }
        public float LaSuma(suma objeto)//Metodo que recibe como parametro un objeto tomando sus propiedades
        {
            float numerazo1 = objeto.numero1;
            float numerazo2 = objeto.numero2;

            return numerazo1 + numerazo2;
        }

    }


}
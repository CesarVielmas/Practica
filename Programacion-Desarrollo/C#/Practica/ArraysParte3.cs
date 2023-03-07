using System;
namespace ArraysParte3
{
    //Lo que veremos aqui es el foreach el foreach lo que hace es facilitar el trabajo a la hora de imprimir
    //Un array , aunque for o while o cualquier otro ciclo lo puede hacer , igualmente es una opcion a la hora
    //De ver el array de una manera mas comoda especificamente se usa mucho mas para arrays que sean de clase
    //clase anonima o arrays que ya estan definidos , tambien se vera una propiedad que es de los arrays la cual
    //Es lenght que sirve mucho para el ciclo for ya que obtiene el valor de la cantidad de elementos que tiene
    //Un array 
    //Ejemplo
    class Parte3Arrays
    {

        static void Main(string[] args)
        {
            //Array de clase anonima
            var arrarAnonimo = new[] {

                new{Nombre = "Pedrito" , Edad = 20},
                new{Nombre = "Sanchez" , Edad = 21},
                new{Nombre = "Pablito" , Edad = 22}
            };
            //array definido
            int[] arrayDefinido = new int[9] {10,20,30,40,50,60,70,80,90};
            //Aqui se ve el funcionamiento de foreach el cual se le debe asignar una variable del tipo del arreglo
            //Que sera tomado en este caso como es un array anonimo se le dio var variableEjemploForeach y despues
            //Se usa la funcion reservada "in" Para asignarle a esa variable creada los atributos del array 
            //Despues de que fue asignada ya solo se imprime en consola la variable del foreach para ver los resultados
            foreach(var variableEjemploForeach in arrarAnonimo)
            {
                System.Console.WriteLine(variableEjemploForeach);
            }
            //for de ejemplo con la funcion o metodo de los arrays llamada length el cual toma cuanta cantidad
            //De elementos tiene el array ayudando a facilitar el trabajo y no modificando el for por si ese
            //Numero o cantidad crece o incremente etc que sea modificado 
            for(int i = 0; i< arrayDefinido.Length; i++)
            {
                System.Console.WriteLine(arrayDefinido[i]);
            }
        }
    }
}
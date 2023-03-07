using System;
namespace ArraysParte1
{
    //Aqui se veran lo que son los arrays en su forma mas primitiva y basica , estos arrays o arreglos sirven
    //Para almacenar grandes o pequeñas cantidades de un mismo dato en una sola variable , son bastantes 
    //Utiles a la hora de ahorrar espacio de memoria y de no crear variables consecuentes en vez de crear varias
    //Variables solamente crear una
    class Parte1Arrays
    {
        static void Main(string[] args)
         {
            //Declaracion del array siempre los corchetes al principio solo en c# []
            int[] variableEntera;
            //Inicializacion de valores a la variable en este caso sera para guardar 10 valores enteros dentro de
            //esta misma variable
            variableEntera = new int[10];
            //Tambien se puede inicializar los valores cuando se declara la variable aqui un ejemplo
            //Donde se guardaran 20 datos de tipo entero en la variable
            int[] variableEntera1 = new int[10];
            //Ahora aqui seria la inicializacion de cada valor en cada posicion , por ejemplo en el primero
            //Tiene 10 posiciones siempre iniciando desde el 0 , a lo cual se guardan varios datos en cada posicion
            //Ejemplo
            variableEntera[0]= 20;//Primera posicion
            variableEntera[1]= 21;//Segunda posicion
            variableEntera[2]= 22;//Tercera posicion
            variableEntera[3]= 23;//Cuarta posicion
            variableEntera[4]= 24;//Quinta posicion
            variableEntera[5]= 25;//Sexta  posicion
            variableEntera[6]= 26;//Septima posicion
            variableEntera[7]= 27;//Octava posicion
            variableEntera[8]= 28;//Novena posicion
            variableEntera[9]= 29;//Decima posicion
            //Y como se puede ver se le asignaron 10 posiciones y aqui estan las 10 posiciones de el array
            //Aqui se manda a llamar a [1] osease a la segunda posicion
            System.Console.WriteLine(variableEntera[1]);

            //Tambien y no menos importante se pueden asignar y crear variables array , por ejemplo lo siguiente
            //El cual sirve pues ya se esta asignando y donde se asigna tambien ya se estan dando valores
            //Respetando las posiciones obviamente empezando por el 0
            int[] variableEntera2 = new int[9] {20,30,40,50,60,70,80,90,100};
            //Aqui se imprime la posicion 0 en este caso la cual es como valor el 20
            System.Console.WriteLine(variableEntera2[0]);


         }
    }
}
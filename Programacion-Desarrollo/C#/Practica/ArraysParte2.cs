using System;
namespace ArraysParte2
{
    //Ahora aqui lo que se vera son los arrays implicitos , los arrays utilizando objetos y los arrays usando
    //Clases anonimas , o arrays anonimos ademas de ver el bucle for , los arrays implicitosson aquellos que 
    //Toman un tipo predeterminado por el compilador dependiendo los datos que obtenga , es util , hasta cierto
    //Punto pues te ahorras el trabajo de pensar que clase de dato sera el array de la variable , aunque el 
    //Problema es que no puede ser de varios tipos a la vez , solamente puede ser de 1 en especifico 
    //El array de objeto o utilizando objetos , este es muy util pues resulta que puede tomar un objeto y sus
    //Propiedades mediante alguna instancia declarandola o , en el mismo array por posiciones se vera un ejemplo
    //Y Para terminar con los diferentes tipos de arrays estan los arrays que usan clases anonimas o arrays
    //Anonimos los cuales deben de asignarles valores en sus posiciones , con una sintaxis bastante similar al
    //de una clase anonima que tambien se vera a continuacion
    //Y ya por ultimo el bucle for el cual 
    class Parte2Arrays
    {
        static void Main(string[] args)
        {
            //Nota solamente se puede hacer de esta manera un array implicito , asignandole los valores
            //Creacion Array Implicito ejemplo
            var variable1 = new[]{10,20,30,40,50};//Como recibio puros int entonces variable1 lo hace int
            System.Console.WriteLine("Primera posicion: "+variable1[0]);
            //Creacion del objeto 
            objeto objetito1 = new objeto();//Con constructor generico
            objeto objetito2 = new objeto(5,6);//Con constructor definido
            //Creacion de Array de objeto 
            objeto[] arrayObjeto = new objeto[2];
            //Array con con instancia de objeto 
            arrayObjeto[0]= objetito1;
            //Array dandole los parametros del constructor para que se guarde en la posicion 1
            arrayObjeto[1]= new objeto(10,20);
            System.Console.WriteLine("Primera posicion del array objeto: "+arrayObjeto[0]);
            System.Console.WriteLine("Segunda posicion del array objeto: "+arrayObjeto[1]);
            //Creacion del array anonimo o de clase anonima
            //Nota importante al hacer un aray de clase anonima o array de clase anonima es importante que 
            //Lo que se tiene en la posicion 0 sean lo mismos parametros en las demas posiciones ya que
            //No se pueden cambiar los parametros como pasar de un string a un int etc por ello se repite
            //En las demas posiciones de el array anonimo
            var arrayAnonimo = new[]{

              new{Nombre = "PEPE",Edad = 20},//Posicion 0 de el array anonimo o array de clase anonima
              new{Nombre = "PABLO",Edad= 21},//Posicion 1 de el array anonimo o array de clase anonima
              new{Nombre = "FLORENCIO",Edad = 22}//Posicion 2 de el array anonimo o array de clase anonima      
            }; 
            //Imprimira con todo y llaves dependiendo la posicion de el array el cual fue creado por ejemplo
            //Aqui se le pide la posicion 0 el cual emitira como resultado = {Nombre= PEPE , Edad= 20} 
            System.Console.WriteLine(arrayAnonimo[0]);
            System.Console.WriteLine("------------------------For------------------------");
            //Ahora el bucle for el cua tiene varias caracteristicas lo principal que tiene es que es un ciclo
            //Se asemeja mucho al while y do while ya que se podria decir que lo que hacen los otros bucles
            //lo puede hacer el y viceversa , su llamada o su inicio es con una variable llamada "i" Aunque 
            //Podria llamarse de alguna otra manera pero es una buena practica ponerle como nombre "i" esta
            //Misma variable i se asigna o se le da un valor dependiendo las necesidades del programador en
            //Este caso se le asigna 0 pues lo que se quiere hacer es llamar a un arreglo y que muestre sus
            //Valores y para ello se reutiliza la ariable "i" despues de la asignacion de la variable i se le
            //Da un parametro de bucle , como en while , que cosa debe de hacer i o la variable asignada para 
            //Que se cumpla el ciclo , despues de asignar ese parametro se incrementa o se decrementa "i" o la
            //Variable que fue asignada dependiendo de el programador
            //Creacion del bucle for
            for(int i=0; i<=2; i++)
            {
                System.Console.WriteLine(arrayAnonimo[i]);
            }
            //Ejemplo con while
            System.Console.WriteLine("-----------------------While-------------------------");
            int j=0;
            while(j!=3)
            {
                System.Console.WriteLine(arrayAnonimo[j]);
                j++;
            }
        } 
    }
    class objeto
    {
        private int numero1;
        private int numero2; 

        public objeto()//Constructor sin parametros
        {
            System.Console.WriteLine("Hola entraste a un constructor generico");
            numero1 = 1;
            numero2 = 1;
            System.Console.WriteLine("Valor numero 1 = "+numero1+" Valor numero 2 = "+numero2 );

        }
        public objeto(int numero1 , int numero2)//Sobrecarga de constructor
        {
            System.Console.WriteLine("Valor numero 1 = "+numero1+" Valor numero 2 = "+numero2 );
            this.numero1 = numero1;
            this.numero2 = numero2;
            System.Console.WriteLine("Suma= "+(numero1+numero2));
        }
    }
}
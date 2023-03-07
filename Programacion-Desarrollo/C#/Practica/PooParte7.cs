using System;
namespace PooParte7
{
//Ahora se vera lo que son los metodos o variables static , estas variables o metodos son creadas para ser
// llamadas desde su clase y no creando un objeto especificamente , mas que todo el hecho de crear un metodo
//o variables tipo static y no un objeto mediante la clase , es que no se necesita tener las propiedades del
//objeto en una variable en especifico , ya que no es sustancial , pues lo unico que se quiere hacer es llamar
//a ese metodo o a esa variable y para ello por eso se usa static , cuando se crea una variable objeto , es
//para despues atribuir los valores del objeto a otra variable o a un metodo trayendo el objeto , depende 
//la situacion a lo que se quiera usar
//Ejemplo
    class Parte7
    {
        static void Main(string[] args)
        {
            estatico.Pow(5,3); //Uso de clase con static
            objeto sumaxd = new objeto(5,5); // creacion de objeto para usar el metodo suma
            sumaxd.Suma(sumaxd);//Pasar las propiedades del objeto de sumaxd a suma para que pueda hacer la suma

        }
    }
   
    class estatico  // un ejemplo para traer un metodo estatico o una variable estatica
    {
        //Campos de clase estatica o propiedades estaticas
        public static void Pow(double variableParaSuPow,double valorParaSubir)
        {
            double valorParaSubir1= valorParaSubir;
            double valorResultante;
            while(valorParaSubir1 != valorParaSubir); 
            {
                if(valorParaSubir == 1)
                {
                     System.Console.WriteLine("Su resultado fue: "+variableParaSuPow);
                }
                else
                {
                    switch(valorParaSubir)
                    {
                        case 2:
                        System.Console.WriteLine("Su resultado fue: "+variableParaSuPow*variableParaSuPow);
                        break;
                         case 3:
                        System.Console.WriteLine("Su resultado fue: "+(variableParaSuPow*variableParaSuPow)*variableParaSuPow);
                        break;
                         case 4:
                        System.Console.WriteLine("Su resultado fue: "+((variableParaSuPow*variableParaSuPow)*variableParaSuPow)*variableParaSuPow);
                        break;
                         case 5:
                        System.Console.WriteLine("Su resultado fue: "+(((variableParaSuPow*variableParaSuPow)*variableParaSuPow)*variableParaSuPow)*variableParaSuPow);
                        break;
                    }
                }
                valorParaSubir1++;
            } 
        }
    }

    class objeto // un ejemplo para traer y asignar un objeto a una variable mediante su clase
    {
        //Propiedades de la clase o campos de clase
        private float numero1;
        private float numero2;
        public objeto()//Creacion del constructor
        {
            numero1 = 0;
            numero2 = 0;
        }
        public objeto(float numero1, float numero2)//Creacion de la sobrecarga de el constructor
         {
             this.numero1 = numero1;
             this.numero2 = numero2;
         }
         public void Suma(objeto objetoxd)//Metodo el cual pide un objeto para tomar sus propiedades y hacer la suma
        {
          float numero1 = objetoxd.numero1;
          float numero2 = objetoxd.numero2;
          System.Console.WriteLine("Resultado suma: "+(numero1+numero2));
        }
    }
}
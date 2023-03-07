using System;
namespace Bucles
{
    class Bucles
    {
        /*Bucle While o "Mientras" por su traduccion al español , ya que es bastante util al traducirlo ya que
        sigue el proceso del ciclo "mientras" se cumpla lo que viene dentro del parentesis , por ejemplo en
        este caso el primer ciclo se cumple porque se le asigno un "si" a la variable salir while principal
        entonces como dice el mismo ciclo , mientras salir del while principal sea diferente de "no" seguira
        el bucle y cuando sea igual a "no" se terminara el bucle, bastante eficaz el ciclo while y muy util
        tambien se le agrego metodos para que el programa fuera mas complejo y propusiera un mayor reto 
        aunque eran opcionales 

        static void Main(string[] args)
        {
            string salirWhilePrincipal="si";
            while(salirWhilePrincipal !="no")
            {
            int numeroIntentos =1;
            System.Console.WriteLine("Bienvenido este sera un programa para adivinar un numero del 0-100");
            int numeroAleatorio=NumeroAleatorio();
            int numeroIngresado=NumeroIngresado();
            while(numeroAleatorio != numeroIngresado){
                numeroIngresado=ComprobacionError(numeroIngresado,numeroAleatorio);
                numeroIntentos++; 
            }
            salirWhilePrincipal = Finalizacion(numeroAleatorio,numeroIntentos);
            }
        }
        //Metodos utilizados para volver mas complejo el problema y mas pequeño el metodo principal
        static int NumeroAleatorio()
        {
            Random numero= new Random();
            int numeroAleatorio=numero.Next(0,100);
            return numeroAleatorio;
        }
        static int NumeroIngresado()
        {
            System.Console.WriteLine("El numero ya fue creado ¿Que numero cree que sea? ingreselo");
            int numeroIngresado= int.Parse(System.Console.ReadLine());
            return numeroIngresado;
        }
        static int ComprobacionError(int numeroIngresado, int numeroAleatorio)
        {
                System.Console.WriteLine("Numero Incorrecto");
                if(numeroIngresado<numeroAleatorio) System.Console.WriteLine($"El numero es mayor que {numeroIngresado}");
                
                else System.Console.WriteLine($"El numero es menor que {numeroIngresado}");
    
                System.Console.WriteLine("Vuelva a intentarlo y ingrese el valor nuevamente");
                numeroIngresado=int.Parse(System.Console.ReadLine());
                return numeroIngresado;
        }
        static string Finalizacion (int numeroAleatorio ,int numeroIntentos)
        {
            System.Console.WriteLine($"Perfecto ya adivinaste el numero el cual era {numeroAleatorio} y lo hiciste con {numeroIntentos} intentos");
            System.Console.WriteLine("¿Desea volver a jugar?");
            string finalizar = System.Console.ReadLine();
            return finalizar;
        }
        */
        // Bucle Do While o  "haz mientras" por su traduccion es demasiado parecido a el bucle while , pero la
        //diferencia entre el uno del otro es que Do While ejecutara si o si su linea de codigo al menos 1 vez
        //que a diferencia de el while que solo lo ejecuta si , se cumple la condicion en los parametros
        //Esto es eficaz en ciertos casos donde se necesite ejecutar al menos solo 1 vez una cosa pero saliendo
        //del ciclo o por otro lado que se ejecute una cosa y que los parametros dentro del ciclo hagan que
        //el ciclo siga fluyendo
        /*
        Aqui un ejemplo usando ambos el do while con el while , el cual se le tuvo que hacer pequeñas modificaciones
        como inicializar salirWhilePrincipal ya que como esta atrapado dentro del do , no esta inicializado
        pero todo lo demas esta normal y casi igual para que quede un poco claro para que se usa el do while
        static void Main(string[] args)
        {

            string salirWhilePrincipal=" ";
            do{
            int numeroIntentos =1;
            System.Console.WriteLine("Bienvenido este sera un programa para adivinar un numero del 0-100");
            int numeroAleatorio=NumeroAleatorio();
            int numeroIngresado=NumeroIngresado();
            while(numeroAleatorio != numeroIngresado){
                numeroIngresado=ComprobacionError(numeroIngresado,numeroAleatorio);
                numeroIntentos++; 
            }
            salirWhilePrincipal = Finalizacion(numeroAleatorio,numeroIntentos);
            }while(salirWhilePrincipal !="no");
        }
        //Metodos utilizados para volver mas complejo el problema y mas pequeño el metodo principal
        static int NumeroAleatorio()
        {
            Random numero= new Random();
            int numeroAleatorio=numero.Next(0,100);
            return numeroAleatorio;
        }
        static int NumeroIngresado()
        {
            System.Console.WriteLine("El numero ya fue creado ¿Que numero cree que sea? ingreselo");
            int numeroIngresado= int.Parse(System.Console.ReadLine());
            return numeroIngresado;
        }
        static int ComprobacionError(int numeroIngresado, int numeroAleatorio)
        {
                System.Console.WriteLine("Numero Incorrecto");
                if(numeroIngresado<numeroAleatorio) System.Console.WriteLine($"El numero es mayor que {numeroIngresado}");
                
                else System.Console.WriteLine($"El numero es menor que {numeroIngresado}");
    
                System.Console.WriteLine("Vuelva a intentarlo y ingrese el valor nuevamente");
                numeroIngresado=int.Parse(System.Console.ReadLine());
                return numeroIngresado;
        }
        static string Finalizacion (int numeroAleatorio ,int numeroIntentos)
        {
            System.Console.WriteLine($"Perfecto ya adivinaste el numero el cual era {numeroAleatorio} y lo hiciste con {numeroIntentos} intentos");
            System.Console.WriteLine("¿Desea volver a jugar?");
            string finalizar = System.Console.ReadLine();
            return finalizar;
        }
        */
    }
}
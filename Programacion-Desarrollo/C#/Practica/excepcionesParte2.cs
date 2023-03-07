using System;
namespace MasExcepciones
{
    class excepciones
    {

        // En este se ve lo que es los errores de catch cuando ya se tiene una excepcion asignada y como se ve
        // cuando ya se tiene asignado un Excepcion o una de sus 2 ramas o diferentes ramas las cuales incluyan
        //alguna otra excepcion que nosotros hayamos puesto posteriormente abajo dara error pues ya fue asignada
        //implicitamente en ese excepcion de rango superior pues abarca el excepcion que nosotros ya pusimos
        // para solucionarlo o se pone el excepcion en especifico arriba del que ya lo incluye , para que al 
        //al momento de ejecutar el programa no lo pase por alto pues sigue el flujo de ejecucion del programa o
        // se haceun filtro de excepcion el cual se ve tambien mas abajo , lo que hace el codigo es que agarra
        //el objeto que fue asignada a la excepcion por ejemplo (Excepcion ex) agarra de ahi el "ex" para que  
        //posteriormente despues de agarrarlo le omita la excepcion formatExcepcion o cualquier otro para que
        //posteriormente abajo del catch con filtro se pueda poner , se utiliza "when" para hacer este tipo de
        //filtro que es muy util a la hora de querer poner un mensaje en especifico o algo en especifico en una
        //excepcion 
        /*
        static void Main(string[] args)
        {
            int numero1,numero2;
            System.Console.WriteLine("Este sera un programa de suma");
            System.Console.WriteLine("Primero ingrese el primer numero");
            // Ejemplo poniendo el catch arriba para agarrar una excepcion en especifico
            try{
                  numero1 = int.Parse(System.Console.ReadLine());
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Ingrese un valor valido , Su primer numero se sustituira por 0");
                numero1=0;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Error");
                System.Console.WriteLine(ex.Message);
                numero1=0;
            }
            //Ejemplo utilizando el filtro en el catch para que posteriormente se pueda usar ese excepcion 
            //en especifico y asignarle algun mensaje o lo que se desee , de lo contrario si no se hace el filtro
            //saldra error como ya se dijo anteriormente porque ya se assigno dentro de el excepcion en general
            System.Console.WriteLine("Ahora ingrese el segundo numero");
          try{
                  numero2 = int.Parse(System.Console.ReadLine());
            }

            //Aqui lo que se hace es que toma los valores del objeto ex el cual contiene todas las excepciones
            //y hace que si es diferente de formatException que ejecute el catch de exception y si es igual a formatException
            //que se salte el catch de exception y prosiga con el siguiente catch el cual es formatException el cual esta
            //abajo bastante util el filtro de excepciones
            catch(Exception ex) when (ex.GetType()!= typeof(FormatException ))
            {
                System.Console.WriteLine("Error");
                System.Console.WriteLine(ex.Message);
                numero2=0;

            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Ingrese un valor valido , Ahora su segundo numero pasara a tomar un valor de 0");
                numero2= 0;
            }
            System.Console.WriteLine($"{numero1} + {numero2} = {numero1+numero2}");
        }
        */
        //Ahora se vera lo que es checked y uncheked los cuales sirven como su nombre lo dice para checkar el programa
        //es como un debugger , pero estos sirven o son muy utiles para cosas que el propio compilador pasa por alto
        //como por ejemplo el siguiente ejemplo de abajo 
        //un dato muy importante es que checked y un unchecked no funciona con valores flotantes , osease double , float
        //etc
        /*
        static void Main(string[] args)
        {
            int valormaximo1=int.MaxValue;
            int valormaximo2=int.MaxValue;
            int valormaximo = valormaximo1 + 20;
            //uncheked lo que hace es que no se cheque el codigo en el cual esta encerrado , tambien puede ser
            //con llaves como uncheked{  "codigo que no se checara"  } aunque aqui se uso parentesis ya que solo
            //se queria no checar una cosa en especifico 
            System.Console.WriteLine("ejemplo con uncheked");
            unchecked(System.Console.WriteLine(valormaximo));
            //el checked por otro lado es lo contrario a unchecked el cual hace que se cheque el codigo a la fuerza
            //y aunque el compilador lo pueda correr con errores pero que lo corra y lo de en pantalla , pues que no
            //no lo corra y se pare el programa y que muestre la excepcion en especifico que provoca ese error
            System.Console.WriteLine("ejemplo para  check");
            checked(System.Console.WriteLine(valormaximo));
        }
        */
    }
}
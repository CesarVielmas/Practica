using System;
namespace ExcepcionParte3
 {
     class ExcepcionThrow
     {
//Aqui se vera como throw puede ayudar a las excepciones , a provocarlas mas que todo ya que si hay algun error
//pues el programa caera , lo que hace throw es dar un mensaje del error del cual pueda hacer que se caiga un programa
//esto mas que todo se usa bastante mas en proyectos donde esten trabajando varias personas en un mismo proyecto
//mas que todo hace o obliga a otra persona que implemente un try catch para ese throw y ya que el throw manda
//el mensaje de la excepcion el programador se dara cuenta de que tipo de excepcion se trata y pondra el try
//catch pero el objetivo principal del throw es hacer que se caiga un programa y que mande una excepcion en 
//pantalla aqui un ejemplo el cual usa el try catch y el throw
/*
          static void Main(string[] args)
        {
//estas 2 lineas de comandos deja en claro como throw detiene el programa y manda una excepcion de tipo formatException
//lo cual hace que el programa caiga y mande el mensaje de formato invalido            
            //throw new FormatException();
            //System.Console.WriteLine("Aqui seguiria el programa");
        
        //Ya aqui empieza el ejemplo completo
        System.Console.WriteLine("Programa para saber que mes del año es con el numero");
        System.Console.WriteLine("Primero deme el numero del mes y le dire el mes");
        try{
             int numeroMes= int.Parse(System.Console.ReadLine());

        }
        catch(Exception ex)
        {
            System.Console.WriteLine("A terminado el programa gracias a el error");
            System.Console.WriteLine(ex.Message);
        }
       
        }
        public static string mes(int numeroMes)
        {
            switch(numeroMes)
            {
                case 1:
                return "enero";
                break;
                case 2:
                return "febrero";
                break;
                case 3:
                return "marzo";
                break;
                case 4:
                return "abril";
                break;
                case 5:
                return "mayo";
                break;
                case 6:
                return "junio";
                break;
                case 7:
                return "julio";
                break;
                case 8:
                return "agosto";
                break;
                case 9:
                return "septiembre";
                break;
                case 10:
                return "octubre";
                break;
                case 11:
                return "noviembre";
                break;
                case 12:
                return "diciembre";
                break;
                default:
                //Aqui se refiere a que si el usuario poner 13 o un 15 o un string tome la excepcion en general
                //y mande el mensaje a excepcion del catch y lo tome el objeto ex y lo genere en pantalla el error
                //si se cumple pues no se ejecutara el throw el cual hace que se cierre el programa y se genere una
                //excepcion del cual tu le asignas que excepcion en este ejemplo se uso exception el cual engloba una gran cantidad
                // de excepciones del cual envia el mensaje y se termina el programa 
                throw new Exception();
                //en este caso hay una excepcion que no engloba pero que si existe la cual es ArgumentOutOfRangeException
                //en este caso me dio flojera ponerla pero eso evita que ponga numeros mas grandes de lo que el metodo soporta
                System.Console.WriteLine("usted puso un numero mas grande que 12 o menor que 1 porfavor vuelva a intentarlo");
                break;

            }
        }
        */

        //Ahora se vera la accion de finally , este es recomendado usarlo , lo que hace finally es que lo que
        //Este dentro de sus llaves porque lleva llaves por ejemplo finally{ } , siempre se ejecute pase lo que pase
        //claro que omitiendo excepciones , errores , para ello se a creado este sencillo ejemplo de un uso normal
        //con finally 
        /*
        static void Main(string[] args)
        {
            //aqui se asigna a la variable archivo un stream reades o un lector de strings y se inicializa en null
            //pues no hay aun algo que leer y se necesita inicializarlo para que entre al try

            System.IO.StreamReader archivo= null;

            try
            {
                //contador de cuantas lineas tiene el codigo y que seran leidas
                int contador=0;
                //Aqui lee las lineas para imprimirlas
                string linea;
                //la ruta del archivo que sera leido
                string ruta = @"/home/cesarvielmas/Programacion-Desarrollo/C#/Practica/ParteParaExcepcionesParte3.txt";
                //aqui se le asigna el archivo que sera leido mediante la ruta que ya fue asignada en la variable
                archivo= new System.IO.StreamReader(ruta);
                //Aqui se guarda en linea lo que lee por cada linea en el archivo con readline y si es nulo
                //osea si no hay lineas que leer acaba el programa
                while((linea = archivo.ReadLine())!= null)
                {
                    System.Console.WriteLine(linea);
                    contador++;
                }
                
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Mal la ruta esta mal");
            }

        //Aqui el finally se ejecutara siempre , aunque el archivo nunca se haya habierto
        finally
        {
            System.Console.WriteLine("El archivo se a cerrado");
            archivo.Close();

        }
        

        }
        */
     }
 }
using System;
 namespace ExcepcionBloqueTryCatch
 {
     class BloqueTryCatch
     {
         //Aqui se vio lo que es el try catch ambos son muy importantes a la hora de toma de errores y soluciones
         //de los mismos , mediante el try , que en español es "intenta" este intentara ejecutar cierta linea de codigo
         //dada por el programador , si existe una excepcion o error como le quieras decir , este que esta dentro
         //del try pasara al catch asi mismo no haciendo que el programa se cierre de forma abrupta y dando dentro
         //del catch otra solucion o aviso al try que intento ejecutar , despues de que el catch se ejecute sale 
         //de las llaves y pasa a las siguientes partes del codigo
        /* Aqui un ejemplo basico de el try catch dentro de los switch el cual arroja un FormatException 
        que hace que si se asigna un valor invalido a un formato por ejemplo un string a un int , funcione el
        try catch

         static void Main(string[] args)
         {
            int numero1 , numero2,Opcion;
            System.Console.WriteLine("Programa para sumar , restar o dividir");
            System.Console.WriteLine("Escriba alguna de las opciones");
            System.Console.WriteLine("1-Sumar");
            System.Console.WriteLine("2-Restar");
            System.Console.WriteLine("3-Dividir");
            try
            {
                Opcion= int.Parse(System.Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Opcion= 0;
            }
            switch(Opcion)
            {
                case 1:
                System.Console.WriteLine("Usted escogio sumar");
                System.Console.WriteLine("Deme los 2 numeros que quiera sumar");
                try
                {
                    numero1 = int.Parse(System.Console.ReadLine());
                    numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    numero1= 0;
                    numero2= 0;
                    System.Console.WriteLine("Como usted introdujo valores no validos no se sumara nada quedando 0 como resultado");
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1+numero2}");
                break;

                case 2:
                 System.Console.WriteLine("Usted escogio restar");
                System.Console.WriteLine("Deme los 2 numeros que quiera restar");
                try
                {
                    numero1 = int.Parse(System.Console.ReadLine());
                    numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    numero1= 0;
                    numero2= 0;
                    System.Console.WriteLine("Como usted introdujo valores no validos no se restara nada quedando 0 como resultado");
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1-numero2}");
                break;

                case 3:
                 System.Console.WriteLine("Usted escogio dividir");
                System.Console.WriteLine("Deme los 2 numeros que quiera dividir");
                try
                {
                     numero1 = int.Parse(System.Console.ReadLine());
                     numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(FormatException ex)
                {
                     numero1= 0;
                     numero2= 0;
                    System.Console.WriteLine("Como usted introdujo valores no validos no se dividira nada quedando 0 como resultado");
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1/numero2}");
                break;

                default:
                System.Console.WriteLine("Seleccione una opcion valida y vuelva a intentarlo");
                break;
            }

         }
         */
        // Ahora se vera lo que son los try catch de varias excepciones por ejemplo en este codigo de ejemplo 
        // son 2 excepciones y no 1 como en el anterior ya que fue incluido otro catch dentro de el try el cual 
        //ahora se fija en el formatexcepcion que ya fue visto anteriormente y en el overflowExcepcion el cual es
        //el segundo y que se usa cuando el numero es mucho mas grande o pequeño que de lo que puede soportar el 
        //parametro ya sea un int o un float o un long o un string etc etc se pueden poner infinidad de catch
        //dentro de los try para muchisimas excepciones aunque si el codigo es muy complejo no se recomienda poner
        //tantos y tantos catch en los try y utilizar lo que se vera en el tercer ejemplo
        /*
         static void Main(string[] args)
         {
             int numero1 , numero2,Opcion;
            System.Console.WriteLine("Programa para sumar , restar o dividir");
            System.Console.WriteLine("Escriba alguna de las opciones");
            System.Console.WriteLine("1-Sumar");
            System.Console.WriteLine("2-Restar");
            System.Console.WriteLine("3-Dividir");
            try
            {
                Opcion= int.Parse(System.Console.ReadLine());
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("Ingrese un valor numerico valido");
                Opcion= 0;
            }
            catch(OverflowException ex)
            {
                System.Console.WriteLine("Ingrese un valor numerico no tan grande");
                Opcion= 0;
            }
            switch(Opcion)
            {
                case 1:
                System.Console.WriteLine("Usted escogio sumar");
                System.Console.WriteLine("Deme los 2 numeros que quiera sumar");
                try
                {
                    numero1 = int.Parse(System.Console.ReadLine());
                    numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    numero1= 0;
                    numero2= 0;
                    System.Console.WriteLine("Como usted introdujo valores no validos no se sumara nada quedando 0 como resultado");
                }
                catch(OverflowException ex)
                {
                    System.Console.WriteLine("Ingrese valores no tan grandes se reseteara a 0 todo");
                    numero1= 0;
                    numero2= 0;
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1+numero2}");
                break;

                case 2:
                 System.Console.WriteLine("Usted escogio restar");
                System.Console.WriteLine("Deme los 2 numeros que quiera restar");
                try
                {
                    numero1 = int.Parse(System.Console.ReadLine());
                    numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    numero1= 0;
                    numero2= 0;
                    System.Console.WriteLine("Como usted introdujo valores no validos no se restara nada quedando 0 como resultado");
                }
                catch(OverflowException ex)
                {
                    System.Console.WriteLine("Ingrese valores no tan grandes se reseteara a 0 todo");
                    numero1= 0;
                    numero2= 0;
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1-numero2}");
                break;

                case 3:
                 System.Console.WriteLine("Usted escogio dividir");
                System.Console.WriteLine("Deme los 2 numeros que quiera dividir");
                try
                {
                     numero1 = int.Parse(System.Console.ReadLine());
                     numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(FormatException ex)
                {
                     numero1= 0;
                     numero2= 0;
                    System.Console.WriteLine("Como usted introdujo valores no validos no se dividira nada quedando 0 como resultado");
                }
                catch(OverflowException ex)
                {
                    System.Console.WriteLine("Ingrese valores no tan grandes se reseteara a 0 todo");
                    numero1= 0;
                    numero2= 0;
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1/numero2}");
                break;

                default:
                System.Console.WriteLine("Seleccione una opcion valida y vuelva a intentarlo");
                break;
            }
         }
         */
         //Ahora se ve algo de lo cual sirve mucho para excepciones mas complejas el cual es Excepcion dentro 
         //del catch este arregla cualquier excepcion del sistema que pueda haber pero asi mismo este no es 
         // muy intuitivo y por lo mismo se utiliza el objeto alado de el Excepcion donde se guarda la 
         //informacion , catch(Excepcion ex), en este caso es ex , aunque podria ser cualquiera y se imprime
         //en pantalla para tener una breve explicacion del error , el Excepcion es muy bueno en metodos o excepciones
         //mas complejas donde se necesitarian muchos catch , aunque lo mas recomendable es que se traten de explicar
         // todas las excepciones posibles con los catch aqui un ejemplo
         /*
         static void Main(string[] args)
         {
             int numero1 , numero2,Opcion;
            System.Console.WriteLine("Programa para sumar , restar o dividir");
            System.Console.WriteLine("Escriba alguna de las opciones");
            System.Console.WriteLine("1-Sumar");
            System.Console.WriteLine("2-Restar");
            System.Console.WriteLine("3-Dividir");
            try
            {
                Opcion= int.Parse(System.Console.ReadLine());
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex);
                Opcion= 0;
            }
            switch(Opcion)
            {
                case 1:
                System.Console.WriteLine("Usted escogio sumar");
                System.Console.WriteLine("Deme los 2 numeros que quiera sumar");
                try
                {
                    numero1 = int.Parse(System.Console.ReadLine());
                    numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(Exception ex)
                {
                    numero1= 0;
                    numero2= 0;
                    System.Console.WriteLine(ex);
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1+numero2}");
                break;

                case 2:
                 System.Console.WriteLine("Usted escogio restar");
                System.Console.WriteLine("Deme los 2 numeros que quiera restar");
                try
                {
                    numero1 = int.Parse(System.Console.ReadLine());
                    numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(Exception ex)
                {
                    numero1= 0;
                    numero2= 0;
                    System.Console.WriteLine(ex);
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1-numero2}");
                break;

                case 3:
                 System.Console.WriteLine("Usted escogio dividir");
                System.Console.WriteLine("Deme los 2 numeros que quiera dividir");
                try
                {
                     numero1 = int.Parse(System.Console.ReadLine());
                     numero2 = int.Parse(System.Console.ReadLine());
                }
                catch(Exception ex)
                {
                     numero1= 0;
                     numero2= 0;
                   System.Console.WriteLine(ex);
                }
                System.Console.WriteLine($"Resultado {numero1} + {numero2} = {numero1/numero2}");
                break;

                default:
                System.Console.WriteLine("Seleccione una opcion valida y vuelva a intentarlo");
                break;
            }
         }
         */

     }
 }
using System;
namespace HerenciaParte2
{
    //Lo que se vera ahora son como funcionan las herencias en los constructores de las superclases o subclases
    //Que heredan propiedades o toman propiedades dependiendo y para ello se usara una palabra reservada llamada
    //base que ira en el constructor de las subclases a las cuales se les hereda un constructor con parametros
    //Aqui un ejemplo
    class Parte2Herencia
    {
        static void Main(string[] args)    
        {
            //Tiene valores dependiendo el usuario
            numeros2 valorxd = new numeros2();
            double [] valorxdd = valorxd.ObtenerArray();
            numeros2 valorxddd = new numeros2(valorxdd);
            
        }
        
    }
    class numeros 
    {
        private double[] numeroslel;
        public numeros()
        {

        }
        public numeros(double[]Arrayxd)
        {
           double[] array= SumarArrays(Arrayxd);
            VerArray(array,Arrayxd);
             
            //Cierre Constructor

        }
        //Metodo o funcion para hacer un array personalizado
        public double [] ObtenerArray()
            {
                System.Console.WriteLine("De cuantos elementos sera su array");
                int elementosArray = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Bien su array es de: "+elementosArray);
                double[] Arrayxd= new double[elementosArray];
                for(int i =0; i< elementosArray; i++)
                {
                    System.Console.WriteLine("Ingrese el elemento: "+i+" del Array");
                    Arrayxd[i]=double.Parse(System.Console.ReadLine());
                    System.Console.WriteLine("Usted ingreso: "+Arrayxd[i]+" en el elemento "+i+" del array");
            
                }
                return Arrayxd;
            }
            public void VerArray(double[] valor1,double[] valor)
            {
                System.Console.WriteLine("Perfecto ahora se hara una suma de cada arreglo entre si");
                int i=0;
                int j=0;
                 foreach(double valorXd in valor1)
            {
                try
                {

                
                System.Console.WriteLine("La suma de "+valor[i]+" + "+valor[i+1]+" es igual a: "+valor1[j]);
                i++;
                i++;
                j++;
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine("La suma de "+valor[(valor.Length)-1]+" + "+0+" es igual a: "+valor[(valor.Length-1)]);
                }

            }
            }
            public double [] SumarArrays(double[] Arrayxdd)
            {
                double[] resultadoSuma;
                if((Arrayxdd.Length%2)>0)
                {
             resultadoSuma =new double[(Arrayxdd.Length+1)/2];
                }
                else{
            resultadoSuma =new double[(Arrayxdd.Length)/2];
             }
            int i;
            for(i =0;i<=((Arrayxdd.Length)/2)-1;i++)
            {
               int contador1;
               int contador2;
               if(i==0)
               {
                   contador1 = 0;
                   contador2 = 1;
               }
                else
               {
                   contador1 = 0;
                   contador2 = 0;
               }
               //Impar
               if((i%2)>0 && i>0 )
               {            
                   //con 3
                  int tomadorI = i*2;     //1,3,5,7,9  
                      
                   contador1 = tomadorI;//2,6,10,14,18
                   contador2 = tomadorI+1;//3,7,11,15,19

               }
               //Par
               if((i%2) == 0 && i>0)
               {
                   //con 4
                int tomadorI = i*2;//4,6,8
                   contador1 = tomadorI;//8,12,16
                   contador2 = tomadorI +1;//9,13,17
               }

                                                   //si es 1 = 3   //Si es 1 =4
                                                   //Si es 2 = 5  //Si es  2 =6
                                                   //Si es 3 = 7  //Si es  3 =8
                    resultadoSuma[i] = Arrayxdd[contador1] + Arrayxdd[contador2];
                   
                
                
            }
            if((Arrayxdd.Length%2)>0 && i>((Arrayxdd.Length)/2)-1)
            {
                resultadoSuma[i] = Arrayxdd[Arrayxdd.Length-1] + 0;
            }
             return resultadoSuma;

            }


        }
        //Herencia ejemplo
        class numeros2 : numeros
        {
            //Constructor que toma propiedades del constructor heredado de numeros
            public numeros2 (double[] valorxdddd) :base(valorxdddd)//Se tiene que usar :base para tomar propiedades
             {
                 System.Console.WriteLine("Programa para sumar arrays");
                 System.Console.WriteLine("--------------------------");
             }
             public numeros2()
             {
                 
             }
        }

    }
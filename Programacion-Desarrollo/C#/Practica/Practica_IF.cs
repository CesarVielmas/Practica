using System;

namespace PracticaIFS
{
    class PracticaDeIFS
    {
    
//un pequeño ejercicio utilizando IF y Else lo cual ya lo habia visto tambien usando un metodo para ahorrar un poco de trabajo
        /*
        static void Main(string[] args)
        {
            string huevo;
            System.Console.WriteLine("Este sera un programa para calcular el tiempo para que llegue a la temperatura maxima para un huevo a la copa");
            System.Console.WriteLine("Primeramente digame si es un huevo pequeño o uno grande");
            huevo = System.Console.ReadLine();
            if(huevo == "pequeño")
            {
     double M,P,C,K,Tiempo,cp,Pnueva,PIcuadrada,KPI,UltimoParentesis,UltimoParentesis1;
     byte TW,Ty,To;
     const float PI=3.1416F;
             M=47;
             P=1.038F;
             C= 3.7F;
             K=0.0054F;
             TW=100;
             Ty=70;
             To=0;
            Pnueva=Math.Pow(P,1/3);
            cp= C*Pnueva;
            PIcuadrada= Math.Pow(PI,2);
            KPI= K*PIcuadrada;
            UltimoParentesis1=(4*PI)/3;
            UltimoParentesis= Math.Pow(UltimoParentesis1,2/3);
             System.Console.WriteLine($"Perfecto usted eligio {huevo} ahora siguiendo con los procedimientos , tome temperatura acutal del huevo y diga cuanta tiene");
             To=byte.Parse(System.Console.ReadLine());
            ResolucionDelTiempo(M,P,C,K,TW,Ty,To,PI, cp,  Pnueva,PIcuadrada,KPI,UltimoParentesis1,UltimoParentesis);
            System.Console.WriteLine("Toque cualquier letra para salir del programa");
            System.Console.ReadLine();
            }
            else
            {
     double M,P,C,K,Tiempo,cp,Pnueva,PIcuadrada,KPI,UltimoParentesis,UltimoParentesis1;
     byte TW,Ty,To;
     const float PI=3.1416F;
             M=67;
             P=1.038F;
             C= 3.7F;
             K=0.0054F;
             TW=100;
             Ty=70;
             To=0;
            Pnueva=Math.Pow(P,1/3);
            cp= C*Pnueva;
            PIcuadrada= Math.Pow(PI,2);
            KPI= K*PIcuadrada;
            UltimoParentesis1=(4*PI)/3;
            UltimoParentesis= Math.Pow(UltimoParentesis1,2/3);
             System.Console.WriteLine($"Perfecto usted eligio {huevo} ahora siguiendo con los procedimientos , tome temperatura acutal del huevo y diga cuanta tiene");
             To=byte.Parse(System.Console.ReadLine());
            ResolucionDelTiempo(M,P,C,K,TW,Ty,To,PI, cp,  Pnueva,PIcuadrada,KPI,UltimoParentesis1,UltimoParentesis);
            System.Console.WriteLine("Toque cualquier letra para salir del programa");
            System.Console.ReadLine();
            }

           
        }
         static double ResolucionDelTiempo(double M,double P,double C, double K,byte TW,byte Ty,byte To,float PI, double cp,double  Pnueva,double PIcuadrada,double KPI,double UltimoParentesis1,double UltimoParentesis)
            {
                double Tiempo,PrimeraParte,SegundaParte,RestasT,RestasXD;
                System.Console.WriteLine("Perfecto entonces los datos quedarian de la siguiente manera");
                System.Console.WriteLine($"M={M} P={P} C={C} K={K} TW={TW} Ty={Ty} To={To} PI={PI}"); 
                M= Math.Pow(M,2/3);
                PrimeraParte=(M * cp)/(KPI * UltimoParentesis);
                RestasT=(To - TW)/ (Ty - TW);
                RestasXD=RestasT*0.76;
                SegundaParte=Math.Log(RestasXD);
                Tiempo = PrimeraParte * SegundaParte;
                System.Console.WriteLine($"El tiempo que debe esperar para que quede bien cocido su huevo es de {Tiempo} segundos aproximadamente");

                return Tiempo;
                
            }
            */
            //El else if lo que hace es que si se cumple un if dentro de su cadena de bloques , los demas else if exclusivamente 
            //solo los else if obedeceran y clausuraran la entrada y ahi acaba el programa 
            //ya no se ejecutaran basante util cuando se quiere entrar a un if sin tocar los demas else if
            /*
            static void Main(string[] args)
            {
                int edad;
             System.Console.WriteLine("ingresa tu edad para saber a que rango perteneces");
                edad = int.Parse(System.Console.ReadLine());

                if(edad < 10)
                {
                    System.Console.WriteLine("eres un niño");
                }
                 else if(edad < 18)
                {
                    System.Console.WriteLine("eres un joven");
                
                }
                else if(edad < 40)
                {
                    System.Console.WriteLine("eres un señor");
                }
                else if(edad < 90)
                {
                    System.Console.WriteLine("eres un viejito");
                }
                else 
                {
                    System.Console.WriteLine("ingresa un valor valido");
                }
                
            }
    */
    }

}
using System;
namespace xd
{
    class xd
    {
        static void Main(string[]args)
        {
            int i = 0;
            System.Console.WriteLine("Introduzca el valor de i");
            i = int.Parse(System.Console.ReadLine());
            if((i%2)==0 && i>0)
            {
                i = i%2;
                System.Console.WriteLine("Es un  numero par: "+i);
            }
            if((i%2)>0)
            {
                i = i%2;
                System.Console.WriteLine("Es un numero impar: "+i);
            }

        }
    }
}
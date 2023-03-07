using System;

namespace Metodos
{
class MetodosEjemplos

{
/*Ejemplo de un programa usando el metodo void , el cual solo ejecuta las acciones que esten dentro del metodo
//Tambien no guarda valores que esten dentro del metodo a variables que esten en el metodo principal , "main"
Ademas de que no guarda mas valores que no esten asignados en los parametros por ejemplo (masa,peso) solo guardara
los parametros masa y peso omitiendo alguna otra variable que utilize estos 2 , un metodo directamente para usarse en ahorrar
codigos que no necesiten guardar algo en alguna variable del metodo main solo ahorran el trabajo de escribir secuencias repetitivas
que no usen variables   

    static void Main(string[] args)
    {
    const float GRAVEDAD= 9.81F;
    float peso,velocidad,tiempo,masita,aceleracioncita,fuerzita;
    System.Console.WriteLine("Este es un programa para obtener su fuerza la cual pide su masa y su aceleracion con los datos que se le piden");
    System.Console.WriteLine("Primero deme su peso");
    peso=float.Parse(System.Console.ReadLine());
    masita= peso/GRAVEDAD;
    masa(peso,GRAVEDAD);
    System.Console.WriteLine("Ahora continuando como segunda instancia deme la velocidad a la que fue en la prueba");
    velocidad= float.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Ahora por ultimo digame el tiempo a la cual fue");
    tiempo= float.Parse(System.Console.ReadLine());
    aceleracioncita= velocidad / tiempo;
    aceleracion(velocidad,tiempo);
    fuerzita = masita * aceleracioncita;
    fuerza(masita,aceleracioncita);
    System.Console.WriteLine("Asi concluye el programa muchas gracias");
    }

    static void masa(float peso,float GRAVEDAD)
    {
    float masita= peso/GRAVEDAD;
    System.Console.WriteLine($"Mediante los datos de su peso el cual es {peso} y la gravedad la cual es siempre {GRAVEDAD} deducimos que su masa es de {masita}");
    }

    static void aceleracion(float velocidad,float tiempo)
    {
    float aceleracioncita= velocidad / tiempo;
    System.Console.WriteLine($"Mediante sus datos de su velocidad la cual fue {velocidad} en el tiempo de {tiempo} deducimos que su aceleracion es {aceleracioncita}");
    }
    static void fuerza(float masita,float aceleracioncita)
    {
    float fuerzita = masita * aceleracioncita;
    System.Console.WriteLine($"Bien todo fue deducido correctamente su fuerza seria de {fuerzita}");
    }

    */

    /*
    //Ejemplo usando metodos con return que no sean void , usando int o float etc en este se puede observar como
    los metodos con asignaciones devuelven el valor que sea retornado y se le puede asignar a una variable esto para que 
    algun otro metodo lo tome , los metodos de este tipo no pueden pedir valores ya que solo retornan un valor , es mejor usar
    un void con otro metodo int o float dentro de el para tomar estos valores , lo que si pueden hacer estos metodos es imprimir
    en pantalla 

    static void Main(string[] args)
    {
     const float GRAVEDAD= 9.81F;
     float masa , pesito,altura;
     System.Console.WriteLine("Este sera un programa para calcular su indice de masa corporal mediante su altura y su masa");
      System.Console.WriteLine("Bien empezemos por su masa porfavor ingresela");
      masa= float.Parse(System.Console.ReadLine());
     pesito = Peso(masa,GRAVEDAD);
    altura= float.Parse(System.Console.ReadLine());
    IMC(altura,pesito);
     System.Console.WriteLine("Perfecto el programa a terminado");

    }
    static float Peso(float masa, float GRAVEDAD)
    {
      float pesito = masa / GRAVEDAD;
      System.Console.WriteLine($"Perfecto su masa fue de {masa} y haciendo sus calculos su peso seria de {pesito}");
      System.Console.WriteLine("Ahora porfavor ingrese su altura");
      return pesito;

    }
    static float IMC(float altura, float pesito)
    {
      float IMCxd= pesito / altura;
      System.Console.WriteLine($"Perfecto su altura fue de {altura} y su peso de {pesito} dando como resultado un IMC de {IMCxd}");
      return IMCxd;
    }
    */
/*
    //ejemplo usando ambos metodos anidados
    static void Main(string[] args)
    {
    float area,bas,altura;
    Comienzo();
    }
    static void Comienzo()
    {
      float area,bas,altura;
      System.Console.WriteLine("Este sera un programa para calcular la base mediante la altura de un cuadrado y su area");
      System.Console.WriteLine("Primero deme el area del cuadrado");
      area=float.Parse(System.Console.ReadLine());
      altura= Alturaxd();
      bas = LaBase(area,altura);

    }
    static float LaBase(float area , float altura)
    {
      float bas = area/altura;
      System.Console.WriteLine($"perfecto su area fue de {area} y su altura de {altura} dando como resultado una base de {bas}");
      return bas;
    }
    static float Alturaxd()
    {
      System.Console.WriteLine("ahora ingrese su altura");
     float altura = float.Parse(System.Console.ReadLine());     
     return altura;
    }
    */
}

}
#include <iostream>
#include <fstream>
#include <cmath>
#include <math.h>
#include <algorithm>
std::fstream ArchivoDatos("5nodes.txt", std::ios_base::in);
int CantidadDeFilasMetodo()
{
    int Contador = 5;
  ArchivoDatos.seekg(Contador);
    int Filas;
    //Obteniendo la cantidad de filas en total
    ArchivoDatos >> Filas;
    return Filas;
}
void MostrarArray(float Posicion[],int CantidadFilas)
{
      for ( int j = 0; j < CantidadFilas; j++)
    {
      printf("Valores de la posicion X%i = %f\n",j+1,Posicion[j]);
    }

    printf("\n");
}
int main(int argc, char * argv[])
{
    int CantidadDeFilas = CantidadDeFilasMetodo();
    printf("Cantidad de filas : %i\n",CantidadDeFilas);
      int Contador = 25;
         ArchivoDatos.seekg(Contador);
         int i = 0;
         float CoordenadasX[CantidadDeFilas];
         float CoordenadasY[CantidadDeFilas];
         //Obteniendo los valores para el array de la posicion X
  while(CantidadDeFilas > i )
  {
        ArchivoDatos >> CoordenadasX[i];
         Contador = Contador+14;
         ArchivoDatos.seekg(Contador);
         i++;
  }
     //Obteniendo los valores para el array de la posicion Y
     i = 0;
     Contador = 30;
    ArchivoDatos.seekg(Contador);
  while(CantidadDeFilas > i )
  {
        ArchivoDatos >> CoordenadasY[i];
         Contador = Contador+14;
         ArchivoDatos.seekg(Contador);
         i++;
  }
    //Mostrar Datos
    MostrarArray(CoordenadasX,CantidadDeFilas);
    MostrarArray(CoordenadasY,CantidadDeFilas);
  //Obteniendo  distancias
  i = 0;
  int k = 0;
  int Distancias[CantidadDeFilas][CantidadDeFilas+1];
  float ResultadoCuadrado1,ResultadoCuadrado2;
  while (i < CantidadDeFilas )
  {

    while ( k < CantidadDeFilas)
    {
      float RestaX = CoordenadasX[i]-CoordenadasX[k];
      float RestaY = CoordenadasY[i]-CoordenadasY[k];
      ResultadoCuadrado1 = pow(RestaX,2);
      ResultadoCuadrado2 = pow(RestaY,2);

      Distancias[i][k+1] =lround(sqrt(ResultadoCuadrado1 + ResultadoCuadrado2));
      k++;
    }
    k = 0;
    Distancias[i][k] = i+1;
    i++;
  }
  //Mostrar Distancias
    int mostrarDistancias[CantidadDeFilas];
    int S = 0;
    while (S < CantidadDeFilas )
    {
        mostrarDistancias[S] = S+1;
        S++;
    }
    printf("Tabla De Distancias:\n\n");
    printf("Cliente   ");
    for (S = 0; S < CantidadDeFilas; S++)
    {
        printf("       %i",mostrarDistancias[S]);
    }
    printf("\n\n");
    printf("Cliente ");
  for (int A = 0; A < CantidadDeFilas; A++)
  {
      for (int T = 0; T < CantidadDeFilas+1; T++)
      {
          printf(" %i      ",Distancias[A][T]);
      }
      if (A == CantidadDeFilas -1)
      {
         printf("\n");
      }
      else
      {
      printf("\nCliente ");
     }
  }
  //Termina Mostrar Distancias
  //Nodo Arbitrario
  int nodoArbitrario;
  printf("Digame el nodo arbitrario de donde empezara el tour: ");
  scanf("%i",&nodoArbitrario);
  int nodoArbitrario1 = nodoArbitrario;
  nodoArbitrario = nodoArbitrario -1;
  int Minimo = Distancias[nodoArbitrario][1];
  i = 0;
  int j = 0;
  int VariableTour,NumeroCliente;
  int Costo[CantidadDeFilas+1];
  Costo[0] = Minimo;
   printf("T = %i-",nodoArbitrario1);
  while (CantidadDeFilas > i)
  {

    while (CantidadDeFilas > j)
    {
      if ((Distancias[nodoArbitrario][j+1] < Minimo) )
      {
        Minimo = Distancias[nodoArbitrario][j+1];
         Costo[i+1] = Minimo;
      }
      else
      {

      }
      
      j++;
    }
    while (j>0)
    {
      if (Distancias[nodoArbitrario][j]== Minimo)
      {
        NumeroCliente = j;
        j = 0;
      }
      else
      {
       
      } j--;
    }
       
    if (i == 0)
    {
       j = 0;
      while (CantidadDeFilas > j )
      {
        Distancias[j][nodoArbitrario+1] = 1000;
        j++;
      }
    }
    else
    {
    printf("%i-",NumeroCliente);
    }
      j = 0;
      while (CantidadDeFilas > j )
      {
        Distancias[j][NumeroCliente] = 1000;
        j++;
      }
    j = 0;
    i++;
    nodoArbitrario = NumeroCliente-1;
    Minimo = Distancias[nodoArbitrario][1];
  }
  //Costos
  //Termina Costos
  printf("%i",nodoArbitrario1);
   printf("\n-----------------------------------------------------------------------------------------------------\n");
 }
#include <iostream>
#include <fstream>
#include <cmath>
#include <math.h>
#include <algorithm>
float ValorMinimoArray(float ValorArray[],int CantidadColumnas)
    {
      for (int i = 0; i < CantidadColumnas; i++)
      {
        if (ValorArray[i] == 0)
        {
          ValorArray[i] = 10000000;
        }
        
      }
      float min;
 
    for (int j = 0; j < CantidadColumnas; j++)
    {
        if (j == 0 || min > ValorArray[j])
        {
            min = ValorArray[j];
         }
    }
      return min;
      
    }

int main(int argc, char * argv[])
{
    std::fstream ArchivoDatos("101nodes.txt", std::ios_base::in);
    int Contador = 5;
  ArchivoDatos.seekg(Contador);
    int CantidadDeFilas;
    //Obteniendo la cantidad de filas en total
    ArchivoDatos >> CantidadDeFilas;
        printf("Cantidad de filas : %i\n",CantidadDeFilas);

        Contador = Contador + 20;
         ArchivoDatos.seekg(Contador);
         int i = 0;
         float PosicionX [CantidadDeFilas];
         float PosicionY [CantidadDeFilas];
         //Obteniendo los valores para el array de la posicion X
  while(CantidadDeFilas > i )
  {
        ArchivoDatos >> PosicionX[i];
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
        ArchivoDatos >> PosicionY[i];
         Contador = Contador+14;
         ArchivoDatos.seekg(Contador);
         i++;
  }
  //Viendo Valores
    for ( int j = 0; j < CantidadDeFilas; j++)
    {
      printf("Valores de la posicion X%i = %f\n",j+1,PosicionX[j]);
    }

    printf("\n");

    for ( int p = 0; p < CantidadDeFilas; p++)
    {
      printf("Valores de la posicion Y%i = %f\n",p+1,PosicionY[p]);
    }
  
  //Obteniendo  distancias
  i = 0;
  int k = 0;
  int DistanciasCantidad = CantidadDeFilas * CantidadDeFilas;
  float RestaX,RestaY;
  double Distancias [DistanciasCantidad];
  float ResultadoCuadrado1,ResultadoCuadrado2;
  int ContadorDistancia1=0;
  while (i < CantidadDeFilas )
  {

    while (k < CantidadDeFilas)
    {
      RestaX = PosicionX[i]-PosicionX[k];
      RestaY = PosicionY[i]-PosicionY[k];
      ResultadoCuadrado1 = pow(RestaX,2);
      ResultadoCuadrado2 = pow(RestaY,2);
      Distancias[ContadorDistancia1] = sqrt(ResultadoCuadrado1 - ResultadoCuadrado2);
      k++;
      ContadorDistancia1++;
    }
    k = 0;
    i++;
  }
  printf("Contador Distancia =%i\n",ContadorDistancia1);
  int ContadorSustituto = 1;

  /*Distancias Valores
  for (int M = 0; M < DistanciasCantidad; M++)
  {
    if (M == CantidadDeFilas * ContadorSustituto )
    {
      printf("\n");
      ContadorSustituto++;
    }
    
    printf("%.3f\n",Distancias[M]);
  }
  */
 i = 0;
 int N = 0;
 int ContadorDistancias = 2;
 int Elementos = 0;
 int A;
 int ValorParaTerminar = 0;
 int ContadorParaFilas = CantidadDeFilas -(CantidadDeFilas-1);
 int ContadorParaSegundaFila = CantidadDeFilas+1;
 float DistanciasElementos[CantidadDeFilas-1];
 int UltimoContador = 1;
 int ContadorParaCicloEliminarFilas = 0;
 //Comparando Distancias entre si
 printf("\nEmpieza Del Elemento %i Al ",i+1);
  while (i< CantidadDeFilas)
  {
    while (N < CantidadDeFilas)
    {
      DistanciasElementos[N] = Distancias[Elementos];
  
      if (N == CantidadDeFilas -1)
      {
         A = 0;

        float ElementoTomado = ValorMinimoArray(DistanciasElementos,CantidadDeFilas);
        for (int Z = 0; Z <= N; Z++)
        {
          if (DistanciasElementos[Z] == ElementoTomado)
          {
            A = Z;
            Z = N+1;
          }
        }
        //Eliminando Filas
         for (int D = 0; D < DistanciasCantidad; D++)
      {
        if (Distancias[D]==ElementoTomado)
        {
          Distancias[D] =0;
        }
         else
         {

         }
      }
      //Verificar Tablas
     
      }
       if (ValorParaTerminar == DistanciasCantidad)
      {
       N = CantidadDeFilas;
       A = 0;
        float ElementoTomado = ValorMinimoArray(DistanciasElementos,CantidadDeFilas);
        for (int Z = 0; Z <= N; Z++)
        {
          if (DistanciasElementos[Z] == ElementoTomado)
          {
            A = Z;
            Z = N+1;
          }
        }

        UltimoContador = 0;
      }

       N++;
      Elementos++;
      ValorParaTerminar++;
    }

    if (UltimoContador == 0)
    {
      A = 1;
      printf("Por Ultimo El Elemento %i\n", A);
      i = CantidadDeFilas;
    }
    else
    {
      printf("Elemento %i Luego ",A+1);
    }
    Elementos = (CantidadDeFilas * A);
  N = 0;
   i++;
   ValorParaTerminar++;
   
   
  }
  printf("\nAhi Termina El Metodo\n");

    return 0;
}


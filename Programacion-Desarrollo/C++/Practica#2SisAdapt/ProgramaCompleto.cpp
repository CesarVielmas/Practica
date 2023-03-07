#include <iostream>
#include <fstream>
#include <cmath>
#include <math.h>
#include <algorithm>
std::fstream ArchivoDatos("MatrizDistancia.txt", std::ios_base::in);
int CantidadDeVerticesMetodo()
{
    int Contador = 5;
  ArchivoDatos.seekg(Contador);
    int Vertices;
    //Obteniendo la cantidad de vertices en total
    ArchivoDatos >> Vertices;
    return Vertices;
}

int main(int argc, char * argv[])
{
    int CantidadDeVertices = CantidadDeVerticesMetodo();
    printf("Valores Leidos : \n");
    //De 7 en 7 para obtener la matriz empezando por 89 luego +8 a la ultima posicion
      int Contador = 107;
         ArchivoDatos.seekg(Contador);
         int i = 0,k=0;
         int ValorEjemplo;
    int MatrizDistancias[CantidadDeVertices][CantidadDeVertices+1];
    while (i< CantidadDeVertices)
    {
        while (k < CantidadDeVertices)
        {
            if (k == 0)
            {
               ArchivoDatos >> ValorEjemplo;
               MatrizDistancias[i][k+1] = ValorEjemplo;
               Contador = Contador +8;
               k++;
            }
            else
            {
            ArchivoDatos.seekg(Contador);
            ArchivoDatos >> ValorEjemplo;
            MatrizDistancias[i][k+1] = ValorEjemplo;
            if (k == CantidadDeVertices-1)
            {
            Contador = Contador +12;
            }
            else
            {
            Contador = Contador+8;
            }
            k++;
            }
        }
        ArchivoDatos.seekg(Contador);
        MatrizDistancias[i][0] = i+1;
        k = 0;
        i++;

    }
    i = 0;
    k = 0;
    //Mostrar Matriz
    while (i< CantidadDeVertices)
    {
        printf("\n%i",MatrizDistancias[i][0]);
        while (k< CantidadDeVertices)
        {
            printf("      %i",MatrizDistancias[i][k+1]);
            k++;
        }
        k = 0;
        i++;
    }
    
    printf("\n");
    printf("Cantidad De Aristas:  %i\n",CantidadDeVertices*2);
    printf("Cantidad De Vertices: %i\n",CantidadDeVertices);
}
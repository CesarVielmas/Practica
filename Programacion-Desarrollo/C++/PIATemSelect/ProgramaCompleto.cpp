#include "LibXLS/OpenXLSX.hpp"
#include "string.h"
#include "stdio.h"
using namespace std;
using namespace OpenXLSX;
//Metodo Principal
int main(int argc, char * argv[])
{
    XLCellValue CantidadFilas,Valores;
    //Obteniendo el archivo
    XLDocument documento;
    documento.open("/home/cesarvielmas/Programacion-Desarrollo/C++/PIATemSelect/Distancias.xlsx");
    auto wks = documento.workbook().worksheet("Hoja1");
    //Obteniendo Cantidad De Filas
    auto row = wks.row(2);
    auto Columnas = wks.cell("C3");
        for (auto& valorEjemplo1 : vector<XLCellValue>(row.values())) 
        {
           CantidadFilas = valorEjemplo1;
        }
    
        cout<< "Cantidad de Filas: "<< CantidadFilas<< endl;
        wks.cell("A1").value() = "Cantidad de Filas ";
        wks.cell("A2").value() = CantidadFilas;
    //Implantando los valores de la tabla
    int Salida = 3,i=0,k,j=0;
    string SalidaCells = to_string(Salida);
    for ( k=0;k < CantidadFilas; k++)
    {

    }
    XLCellValue Matriz[k+12][k+19];
    while(Salida < k+3)
    {
        row = wks.row(Salida);
        for (auto& valorEjemplo2 : vector<XLCellValue>(row.values())) 
        {
            Matriz[i][j+1] =valorEjemplo2;
            j++;
        }
        Matriz[i][0] = i+1;
        Salida++;
        i++;
    }
    i = 0;
  
    //Viendo valores
    Salida = 3;
    j=1;
    i=0;
    int p = 0;
    int Salida1 = 3;
    //Valores
    cout<<endl;
    while(Salida < k+3)
    {
        row = wks.row(Salida);
        if (Salida == 3)
        {

           for (auto& valorEjemplo4 : vector<XLCellValue>(row.values())) 
        {
            if(i == 22)
            {

            }
            else
            {
            cout<<i+1<<"-"<<  Matriz[i][j]<< endl;
            j = j+24;
            i++;
            }
            
        }
        j = 0;
        i = 0;
        }
        else
        {

        }
        
        cout<<endl<< Matriz[i][0] <<"-";
        for (auto& valorEjemplo5 : vector<XLCellValue>(row.values())) 
        {
            cout<<" "<< Matriz[i][j];
            j++;
            cout<<"Valor j:"<<j;
            cout<<"Valor i:"<<i;

        }
       
        Salida++;
        i++;
    }
    Salida = 3;
    j=0;
    i=0;
    Salida1 = 3;
    int Salida2 = 0,ValorXD,Salida3=0;
    int a = 0;
    XLCellValue ValorGrande = 10000000000000,ValorPrueba1,ValorPrueba2,ValorPrueba3,ValorPrueba4;
    XLCellValue Numero = 999999999999999;
    XLCellValue Numero1 = 0;
     cout<<"Valor k:"<<k;
    //Obteniendo el Tour TSP
    cout<<"\nTour TSP Completo"<<endl<<"1";
    while (Salida < k+3)
    {
         row = wks.row(3);
         Salida2 = (k) * i;
        //Obteniendo el mejor valor de cercania
        ValorGrande = Numero;
         for (auto& valorEjemplo6 : vector<XLCellValue>(row.values())) 
        {
            ValorPrueba1 =  Matriz[i][Salida2+42];
            ValorPrueba2 = Matriz[i][Salida2+43];
            ValorPrueba3 =  Matriz[i][Salida2+3];
            ValorPrueba4 = Matriz[i][Salida2+4];

            if (i == 0)
            {
               if (Salida2 >  k-2 )
            {
                
            }
            else
            {
            if (ValorPrueba3 < ValorPrueba4)
            {
                if (ValorPrueba3>ValorGrande)
                {
                    ValorGrande = ValorGrande;
                }
                else
                {
                     ValorGrande = ValorPrueba3;
                }
            }
            else if(ValorPrueba4 < ValorPrueba3 )
            {
                if (ValorPrueba4 > ValorGrande)
                {
                    ValorGrande = ValorGrande;
                }
                else
                {
                    ValorGrande = ValorPrueba4;
                }
            }
             }
            }
            else if (i ==21)
            {
               if (Salida2 >  k-2 )
            {
                
            }
            else
            {
            if (ValorPrueba1 < ValorPrueba2)
            {
                if (ValorPrueba1>ValorGrande)
                {
                    ValorGrande = ValorGrande;
                }
                else
                {
                     ValorGrande = ValorPrueba1;
                }
            }
            else if(ValorPrueba2 < ValorPrueba1 )
            {
                if (ValorPrueba2 > ValorGrande)
                {
                    ValorGrande = ValorGrande;
                }
                else
                {
                    ValorGrande = ValorPrueba2;
                }
            }
             }
            }
            else 
            {
              if (Salida2 ==  k-1 )
            {
                if (ValorGrande > ValorPrueba1)
                {
                    ValorGrande = ValorPrueba2;
                }
                else
                {
                    ValorGrande = ValorGrande;
                }
            }
            else
            {
            if (ValorPrueba1 < ValorPrueba2)
            {
                if (ValorPrueba1>ValorGrande)
                {
                    ValorGrande = ValorGrande;
                }
                else
                {
                     ValorGrande = ValorPrueba1;
                }
            }
            else if(ValorPrueba2 < ValorPrueba1 )
            {
                if (ValorPrueba2 > ValorGrande)
                {
                    ValorGrande = ValorGrande;
                }
                else
                {
                    ValorGrande = ValorPrueba2;
                }
            }
             }
            }
            Salida2++;
        }
       Salida2 = (k) * i;
        ValorXD = 0;
        j= 0;
        //Comprobando en que posicion esta
        for (auto& valorEjemplo8 : vector<XLCellValue>(row.values()))
        {
            if (i == 0)
            {
                 if (ValorGrande == Matriz[i][Salida2+3])
            {
                ValorXD = j;
            }
            else
            {
             j++;
            Salida2++;
            }
            }
            else
            {
                 if (ValorGrande == Matriz[i][Salida2+45])
            {
                ValorXD = j;
            }
            else
            {
             j++;
            Salida2++;
            }
            }
        }
        cout<<"-"<<ValorXD+1;
        i = ValorXD;
        ValorXD = ValorXD+2;
        Salida2 = (k) * i;
        a = 3;
        p = 0;
        Salida1 = 3;
        Salida2 = 0;
        //Rellenando a ceros las demas posiciones
        while (Salida1 < k+3)
        {

            for (auto& valorEjemplo9 : vector<XLCellValue>(row.values()))
            {
                if (Matriz[p][a] == ValorGrande)
                {
                    Matriz[p][a] = 50000000;
                     a++;
                }
                else
                {
                a++;
                }
            }
            p++;
            Salida1++;
        }
        Salida++;
    }
    //Nueva Tabla
    cout<<"Nueva Tabla"<<endl;
    //Viendo valores
    Salida = 3;
    j=1;
    i=0;
    p = 0;
    Salida1 = 3;
    //Valores
    cout<<endl;
    while(Salida < k+3)
    {
        row = wks.row(Salida);
        if (Salida == 3)
        {

           for (auto& valorEjemplo4 : vector<XLCellValue>(row.values())) 
        {
            if(i == 22)
            {

            }
            else
            {
            cout<<i+1<<"-"<<  Matriz[i][j]<< endl;
            j = j+24;
            i++;
            }
            
        }
        j = 0;
        i = 0;
        }
        else
        {

        }
        
        cout<<endl<< Matriz[i][0] <<"-";
        for (auto& valorEjemplo5 : vector<XLCellValue>(row.values())) 
        {
            cout<<" "<< Matriz[i][j+3];
            j++;
        }
       
        Salida++;
        i++;
    }
    documento.save();
    documento.close();
    return 0;
}
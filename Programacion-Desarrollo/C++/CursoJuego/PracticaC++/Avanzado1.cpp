#include <iostream>
using namespace std;

int main() {
    //Punteros 
    int numero = 10;
    int* puntero = &numero; // Declaración y asignación de un puntero
    *puntero = 20; // Modificación del valor apuntado por el puntero
    cout<<"Puntero:"<<numero<<" :"<<puntero;
    //Los punteros lo que hacen es que modifican a la variable que estos toman , en este caso como puntero toma a numero  y como puntero es igualado a otro valor , entonces numero cambia su valor a la del puntero , el puntero toma el valor o la memoria que utiliza la variable , en este caso lo manda en codigo hexadecimal 
    
    //Referencias
    int numero2 = 10;
    int& referencia = numero2; // Declaración de una referencia
    referencia = 20; // Modificación del valor referenciado
    cout<<"Referencia:"<<numero2<<" :"<<referencia;
    //Las referencias son similares a los punteros , sin embargo los punteros guardan la direccion en memoria y modifican la variable a la que hicieron el puntero , las referencias toman el valor de la variable y tambien modifican el valor de la variable

    //Operaciones con punteros
    int numeros[5] = {1, 2, 3, 4, 5};//se le indica el tamaño del array y los valores que tomara
    int* punteros = numeros;//Se le asigna la direccion de memoria a puntero y se asigna como puntero

    for (int i = 0; i < 5; i++)//Ciclo for para recorrer numeros
     {
    std::cout <<"punteroArray:"<<*punteros << " "<<std::endl; // Acceso al valor apuntado por el puntero
    punteros++; // Avance al siguiente elemento del array
    }
    //En este caso toma el primer valor de numeros el puntero para ver la informacion de la variable guardada en puntero y no su direccion de memoria se usa "*" al inicio , por lo cual tiene la primer elemento de numeros y luego como se hace un "++" recorre y se va a la siguiente posicion 

    //Gestion de memoria dinamica
    int* numero = new int; // Asignación dinámica de memoria para un entero
    *numero = 42; // Asignación de un valor
    delete numero; // Liberación de memoria

    int* array = new int[10]; // Asignación dinámica de un array de enteros
    delete[] array; // Liberación de memoria del array
    //Es importante decir que si se requiere que sea asignacion dinamica de memoria debe contener "*" para que asi sea y ya con delete poder eliminarlo de la memoria

    //Arrays dinamicos con memoria dinamica
    int size;
    std::cout << "Ingrese el tamaño del array: ";   
    std::cin >> size;

    int* numeros = new int[size]; // Creación de un array de tamaño "size"
    // Realizar operaciones con el array

    delete[] numeros; // Liberar memoria del array

    return 0;
}
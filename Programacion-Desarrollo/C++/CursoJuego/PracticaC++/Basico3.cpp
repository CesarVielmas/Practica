#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;
//Funcion creada para sumar
int suma(int a, int b) {
    return a + b;
}

int main() {
    //Funcion y funciones para paso de parametros
    int resultado = suma(5, 3);
    std::cout << "La suma es: " << resultado << std::endl;
    //Arreglos en c++
    int numeros[5];  // Declaración de un arreglo de enteros de tamaño 5
// Inicializando los elementos del arreglo
numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;
numeros[3] = 40;
numeros[4] = 50;

// Accediendo a los elementos del arreglo
std::cout << "El primer número es: " << numeros[0] << std::endl;
std::cout << "El segundo número es: " << numeros[1] << std::endl;

//Cadena de caracteres en c++
  char nombre[] = "Juan";  // Declaración de una cadena de caracteres

    std::cout << "El nombre es: " << nombre << std::endl;

    // Recorriendo la cadena de caracteres
    for (int i = 0; nombre[i] != '\0'; i++) {
        std::cout << nombre[i] << " ";
    }
    std::cout << std::endl;
    return 0;
};

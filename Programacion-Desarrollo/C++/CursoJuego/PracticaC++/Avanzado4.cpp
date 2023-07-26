#include <iostream>
#include <vector>
#include <map>
#include <algorithm>
using namespace std;
int main() {
    // Uso de vector para almacenar una lista de números
    std::vector<int> numeros = {1, 2, 3, 4, 5};

    // Uso de mapa para almacenar un conjunto de clave-valor
    std::map<std::string, int> edad = {{"Juan", 25}, {"María", 30}, {"Pedro", 22}};

    // Acceso a elementos del vector
    std::cout << "Primer número: " << numeros[0] << std::endl;

    // Acceso a elementos del mapa
    std::cout << "Edad de María: " << edad["María"] << std::endl;
    
     
     
     //Algoritmos
     td::vector<int> numeros = {5, 2, 8, 3, 1};

    // Ordenar el vector en orden ascendente
    std::sort(numeros.begin(), numeros.end());

    // Buscar un elemento en el vector
    int numeroBuscado = 3;
    bool encontrado = std::binary_search(numeros.begin(), numeros.end(), numeroBuscado);

    if (encontrado) {
        std::cout << "Número " << numeroBuscado << " encontrado en el vector." << std::endl;
    } else {
        std::cout << "Número " << numeroBuscado << " no encontrado en el vector." << std::endl;
    }
    //Iteradores 
    std::vector<int> numerosEjemplo = {1, 2, 3, 4, 5};

    // Uso de iteradores para recorrer el vector
    for (std::vector<int>::iterator it = numerosEjemplo.begin(); it != numerosEjemplo.end(); ++it) {
        std::cout << *it << " ";
    }
    
    return 0;
}

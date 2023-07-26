#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    //Entradas y salida de datos
    int edad;
    std::cout << "Ingrese su edad: ";
    std::cin >> numero;//Le pide un numero al usuario por terminal
    std::cout << "El número ingresado es: " << numero << std::endl;
    //Condicionales en c++
if (edad >= 18) {
    std::cout << "Eres mayor de edad" << std::endl;
} else {
    std::cout << "Eres menor de edad" << std::endl;
}
    //bucles en c++
for (int i = 1; i <= 5; i++) {
    std::cout << i << " ";
}
std::cout << std::endl;

int j = 1;
while (j <= 5) {
    std::cout << j << " ";
    j++;
}
std::cout << std::endl;
    return 0;
};

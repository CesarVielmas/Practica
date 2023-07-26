#include <iostream>
using namespace std;

    //Funcion llamada sumar
    int Sumar(int a, int b) 
    {
    return a + b;

    }
    //Creacion de la template , esta misma es una funcion la cual se llama T la template , luego se crea la funcion justo debajo utilizando la template que se llamara T, esta misma tiene como parametros T a y T b , esto quiere decir que acepta cualquier tipo de dato en la variable "a" y en la variable "b" 
    template <typename T>
    T Maximo(T a, T b) {
    return (a > b) ? a : b;//operador ternario , el cual verifica si a es mayor de b si es mayor a que b entonces devuelve a y si no devuelve b
    }

int main(){
    int (*punteroFuncion)(int, int) = Sumar; // Declaración de puntero a función como se puede apreciar , debe copiar la misma cantidad de parametros y igualarla a la funcion
    int resultado = punteroFuncion(5, 3); // Llamada indirecta a la función
    cout<<resultado;
    //uso de las templates
    int num1 = 10, num2 = 20;
    double d1 = 3.14, d2 = 2.71;

    std::cout << "Máximo de enteros: " << Maximo(num1, num2) << std::endl;//uso de la template
    std::cout << "Máximo de doubles: " << Maximo(d1, d2) << std::endl;//uso de la template

    return 0;
}
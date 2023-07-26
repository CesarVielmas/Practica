#include <iostream>
#include <vector>
#include <algorithm>
#include <thread>
#include <mutex>

using namespace std;

std::mutex mtx;//declaracion del mutex

void HiloFuncion() {
    std::cout << "Este es un hilo" << std::endl;
}
void HiloFuncion2(){
    mtx.lock();
    std::cout << "Este es un hilo" << std::endl;
    mtx.unlock();
}

int main() {
    std::vector<int> numeros = {1, 2, 3, 4, 5};

    // Uso de función lambda para imprimir el doble de cada número
    std::for_each(numeros.begin(), numeros.end(), 
    //Funcion lambda dentro del mismo foreach
    [](int num) {
        std::cout << num * 2 << " ";
    });
    //Uso de los hilos 
    std::thread hilo(HiloFuncion);
    hilo.join(); // Esperar a que el hilo termine antes de salir del programa

    //Uso de los hilos y comunicacion entre ellos
    std::thread hilo(HiloFuncion2);
    hilo.join();
   
    return 0;
}

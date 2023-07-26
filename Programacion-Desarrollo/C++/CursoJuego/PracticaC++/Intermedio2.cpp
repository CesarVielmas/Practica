#include <iostream>
using namespace std;
//Creacion de la clase cuenta bancaria
class CuentaBancaria {
private:double saldo;

//Metodo publico para asignarle a el campo salario una cantidad
public:void depositar(double cantidad) {
        saldo += cantidad;
    }
//Metodo publico para asignarle a saldo otra cantidad
public:void retirar(double cantidad) {
        saldo -= cantidad;
    }
//Metodo publico para obtener el campo saldo el cual es privado y retornarlo
public:double obtenerSaldo() {
        return saldo;
    }
};
// Clase base
class Animal {
public:void comer() {
        std::cout << "El animal está comiendo." << std::endl;
    }
};

// Clase derivada la cual hereda de animal y obtiene sus campos y metodos
class Perro : private Animal {
public:void ladrar() {
        std::cout << "¡Guau, guau!" << std::endl;
    }
};
int main() {
    CuentaBancaria cuenta;//Creacion de instancia de objeto
    cuenta.depositar(1000);//utiliza metodo
    cuenta.retirar(500);
    std::cout << "Saldo actual: " << cuenta.obtenerSaldo() << std::endl;
    //Herencia
    Perro perro;
    perro.ladrar();
    perro.comer();//obtiene comer por la clase animal
    return 0;
}

#include <iostream>
using namespace std;
// Clase base abstracta
class Animal {
public:
    virtual void hacerSonido() = 0;
};

// Clases derivadas
class Perro : public Animal {
public:
    void hacerSonido() override {
        std::cout << "¡Guau, guau!" << std::endl;
    }
};

class Gato : public Animal {
public:
    void hacerSonido() override {
        std::cout << "¡Miau, miau!" << std::endl;
    }
};

int main() {
    Animal* animal1 = new Perro();//Se indica que sera de tipo animal , pero especificamente de tipo Perro
    Animal* animal2 = new Gato();

    animal1->hacerSonido(); // Polimorfismo y ligadura dinámica
    animal2->hacerSonido(); // Polimorfismo y ligadura dinámica

    delete animal1;
    delete animal2;

    return 0;
}

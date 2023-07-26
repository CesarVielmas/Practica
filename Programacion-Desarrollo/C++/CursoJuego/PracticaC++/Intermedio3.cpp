#include <iostream>
using namespace std;

//Creacion de la clase persona
class Persona {
public:std::string nombre;

    // Constructor de la clase persona se llama cuando se crea la clase
    Persona(const std::string& nombre) {
        this->nombre = nombre;//uso de this en c++
        std::cout << "Se creó un objeto de Persona. Nombre: " << nombre << std::endl;
    }

    // Destructor de la clase persona se llama cuando se deja de utilizar una clase o objeto o instancia
    ~Persona() {
        std::cout << "Se destruyó el objeto de Persona. Nombre: " << nombre << std::endl;
    }
};
class Circulo {
    private:double radio;

    public:void establecerRadio(double r) {
        radio = r;
    }

    public:double obtenerArea() {
        return 3.14159 * radio * radio;
    }
};

int main() {
    Persona persona("Juan"); // Se llama al constructor al crear el objeto

    Circulo circulo;
    circulo.establecerRadio(5.0);
    double area = circulo.obtenerArea();
    std::cout << "El área del círculo es: " << area << std::endl;

    // Al finalizar el ámbito, se llama al destructor al destruir el objeto
    return 0;
}

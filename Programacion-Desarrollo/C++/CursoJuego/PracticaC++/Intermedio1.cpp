#include <iostream>
using namespace std;
// Definición de la clase
class Persona {
public:std::string nombre;//Campo publico de persona
public:int edad;//Campo publico de edad 
    //metodo vacio de la clase persona
    void saludar() {
        std::cout << "¡Hola! Mi nombre es " << nombre << " y tengo " << edad << " años." << std::endl;
    }
};
class Estatico {
public:static std::string nombre1;

   public:static void saludarPaco(){
        std::cout << "Hola"<<nombre1;
    }
};
std::string Estatico::nombre1 = "Paco";//Se debe inicializar la variable estatica del campo de una clase por fuera y con su respectivo valor en este caso es un std::string
int main() {
    // Creación de objetos de la clase Persona
    Persona persona1;
    persona1.nombre = "Juan";
    persona1.edad = 25;
    persona1.saludar();

    Persona persona2;
    persona2.nombre = "María";
    persona2.edad = 30;
    persona2.saludar();

    Estatico::saludarPaco();
    return 0;
}


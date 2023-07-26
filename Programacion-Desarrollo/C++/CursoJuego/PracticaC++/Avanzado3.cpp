#include <iostream>

using namespace std;

//Creacion de la plantilla
template <typename T>
//Metodo vacio que toma T valor de variable , osease que usa la plantilla
void MostrarInfo(T valor) {
    std::cout << "Valor int: " << valor << std::endl;//Si la variable es diferente de string entonces mandara esto
}

// Especialización para el tipo std::string
template <>//Se indica a la plantilla
void MostrarInfo<std::string>(std::string valor) //Si lo que recibe dentro de la funcion es un string entonces hara algo diferente
{
    std::cout << "Cadena: " << valor << " - Longitud: " << valor.length() << std::endl;
}
//Especializacion para el tipo double , personalizado
template<>
void MostrarInfo<double>(double valor){
    std::cout<<"Valor mandado como float: "<<valor;
}

template <typename J>
class MiClase {
public:
    J dato;//Dato publico de tipo generico puesto por la template
    //Constructor el cual toma un valor T osease cualquiera , ya que la template lo admite y le pasa o sobrescribe la propiedad publica dato con dicho dato pasado al constructor
    MiClase(J valor) : dato(valor) {

    }

    void MostrarInfo() {
        std::cout << "Valor: " << dato << std::endl;
    }
};

int main() {
    int num = 42;
    std::string cadena = "Hola, mundo";
    double numDouble = 40.56;
    MostrarInfo(num); // Llamada a la versión genérica
    MostrarInfo(cadena); // Llamada a la versión especializada string
    MostrarInfo(numDouble);//Llamada a la version especializada int

    //Uso de la clase generica 
    MiClase<int> objeto1(42);//Aqui se le indica y envia un entero y e crea el objeto 1
    MiClase<std::string> objeto2("Hola, mundo");//Aqui se le indica que sera de tipo string y se le envia un string y se crea objeto 2

    objeto1.MostrarInfo(); // Llamada al método genérico con int
    objeto2.MostrarInfo(); // Llamada al método genérico con std::string
    return 0;
}

#include <iostream>
using namespace std;

//Creacion de la clase Vector2D
class Vector2D {
public:double x, y;//Propiedades privadas de la clase

    //Sobrecarga de operador +
    Vector2D operator+(const Vector2D& otro) {
        Vector2D resultado;
        resultado.x = x + otro.x;
        resultado.y = y + otro.y;
        return resultado;
    }
};

int main() {
    Vector2D v1 {2.0, 3.0};
    Vector2D v2 {1.0, 5.0};
    Vector2D suma = v1 + v2;
    std::cout << "La suma de los vectores es: (" << suma.x << ", " << suma.y << ")" << std::endl;

    return 0;
}

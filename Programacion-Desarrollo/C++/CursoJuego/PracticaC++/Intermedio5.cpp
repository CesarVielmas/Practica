// Clase abstracta
class Figura {
public:virtual double calcularArea() = 0;//Se le indica que debe contener un metodo al que debe override o sobrescribir que debe ser de tipo double
};

// Clases derivadas
class Rectangulo : public Figura {
public:
    double base, altura;
    //Como se hereda entonces debe contener dicho metodo
    double calcularArea() override {
        return base * altura;
    }
};

class Circulo : public Figura {
public:
    double radio;
    //Como se hereda entonces debe contener dicho metodo
    double calcularArea() override {
        return 3.14159 * radio * radio;
    }
};

int main() {
    Rectangulo rectangulo {5.0, 3.0};
    Circulo circulo {2.5};

    Figura* figura1 = &rectangulo;
    Figura* figura2 = &circulo;

    std::cout << "Área del rectángulo: " << figura1->calcularArea() << std::endl;
    std::cout << "Área del círculo: " << figura2->calcularArea() << std::endl;

    return 0;
}

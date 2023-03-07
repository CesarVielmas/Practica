using System;
//Pendiente saber como incluir el archivo PooParte5(2).cs para que funcione la clase imprimir numeros
namespace PooParte5
{
//Lo que se vera ahora es dividir las clases o el codigo en varios archivos fuente , en este caso se dividio 
//en otra clase llama imprimirNumeros la cual esta alojada en el otro archivo fuente PooParte5(2).cs para ver
//el funcionamiento de la misma , es bastante bastante util hacer este procedimiento pues ayuda a dividir de
//manera eficiente el codigo
//Ejemplo ver parte 2 en PooParte5(2)
class PooParte5
{
    static void Main(string[] args)
    {
     usoClase();
    }
    static void usoClase()
    {
    imprimirNumeros numeros = new imprimirNumeros();//Aqui se manda a llamar la clase desde el archivo fuente
    imprimirNumeros numeroSobrecargados = new imprimirNumeros(3,4,5);//y aqui el constructor de sobrecarga
    }
}
}
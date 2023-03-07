using System;
namespace Parte4POO
{
//Lo que se vera aqui es el metodo setter y getter tambien lo que es this solo una pequeña parte
//y como dividir una clase con partial
//Primero empezando por lo que es setter y getter , esto ya se medio vio en la anterior parte de Poo pero se
//podria definir setter como el asignador de un campo de clase o propiedad el cual se le puede asignar mediante
//otra clase , aun que la propiedad o el campo de clase este encapsulada y por otro lado getter es para obtener
//el valor de una propiedad o campo de clase que este encapsulada, tambien es muy importante aunque es opcional
//poner siempre a el nombre del metodo "set" si es setter o "get" si es getter 
//ahora "this" tiene varias funciones pero por ejemplo en este ejemplo se vera que sirve para diferenciar 
//variables dentro del metodo con sus parametros en el ejemplo quedara claro
//y por ultimo partial es para dividir una clase en varios pedazos , ya que es muy util cuando se trata 
//de codigo bastante extenso en dicha clase de objeto
    class PooParte4
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Primero se vera el getter acontinuacion para obtener el valor de una propiedad de campo");
            animal caracteristica = new animal();
            System.Console.WriteLine(caracteristica.getInformacionAnimal());
            System.Console.WriteLine("Ahora el setter modificando ese valor traido");
            caracteristica.setInformacionAnimal(3,2);
            System.Console.WriteLine("Revise el codigo para ver el this el cual es acontinuacion");
            caracteristica.setInformacionAnimalThis(4,4);

        }
        
    }
    //Ahora aqui se divio la clase animal en 2 partes con la llamada partial la cual puede dividirse cuantas
    //veces se quiera ,dependiendo que tanto necesites dividir y que tan grande sea el programa y funcionaran
    //exactamente igual como si el programa estuviera junto , mas que todo sirve para no desviarse y encontrar
    //mas rapido las cosas

    partial class animal//primera parte de la clase
    {
    //Campos de clase o propiedades
        private int ojos;
        private int nariz;

    //Constructor    
    public animal ()
    {
        ojos = 2;
        nariz= 1;
    }
 }

partial class animal //segunda parte de la clase
{
        //getter
        public string getInformacionAnimal()
        {
            return $"El animal tiene {ojos} ojos y {nariz} nariz";
        }
        //setter
         public void setInformacionAnimal(int ojosxd,int narizxd)
        {
            ojos=ojosxd;
            nariz=narizxd;
            System.Console.WriteLine($"El animal tiene {ojos} ojos y {nariz} nariz");
        }

    //uso del this en esta ocacion
    //en esta ocacion el uso del this es para diferenciar las variables de los parametros con
    //los campos de clase asi mismo el this lo que esta haciendo es que el que lleva el this lo referencia a
    //los campos de clase o propiedades , para que se puedan sobreescribir con los datos de los parametros 
    //el this le proporciona los valores dentro de una clase y no lo de los parametros primero
    public void setInformacionAnimalThis(int ojos,int nariz)
    {
        this.ojos = ojos;
        this.nariz = nariz;
        System.Console.WriteLine($"El animal tiene {ojos} ojos y {nariz} nariz");
    }

    }
}
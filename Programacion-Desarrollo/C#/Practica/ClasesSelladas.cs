using System;
namespace ClasesSelladas
{
//Ahora lo que se vera son las clases selladas y los metodos sellados ,esto de cierta manera tambien es muy
//Importante y util , lo que hacen empezando las clases selladas , cuando se sella una clase con la palabra
//Reservada "sealed" lo que hace es que no permite que esa clase en especifico creada sellada , la puedas
//heredar , no permite que la heredes , mientras que al hacer un metodo "sealed" lo que hace es que no permite
//Que si ese metodo es heredado a otra clase la sobreescriba , no deja que se sobreescriba ese metodo y para
//eso son las clases selladas y los metodos sellados
//Ejemplo
    class SelladasClases
    {
        static void Main(string[] args)
        {
            //Llamando a las clases mediante la creacion de objetos
            ClaseSellada objeto1 = new ClaseSellada();
            ClaseConMetodoSellado objeto2 = new ClaseConMetodoSellado();
            objeto2.MensajeQueNoPuedeSerSobreescrito();
        }
    }
    //Clase que no puede ser heredada pues esta sellada
    sealed class ClaseSellada
    {
        public ClaseSellada()
        {
            System.Console.WriteLine("Esta clase no puede ser heredada");
        }

    }
    //Si se ejecutara esto daria error pues no se puede heredar una clase que esta sellada
    /*
    class clasexdd : ClaseSellada
    {

    }
    */
    class hola
    {
        public virtual void MensajeQueNoPuedeSerSobreescrito()
        {
            System.Console.WriteLine("Hola");
        }
    }
    class ClaseConMetodoSellado : hola
    {
        public ClaseConMetodoSellado()
        {
            System.Console.WriteLine("Esta clase tiene un metodo sellado que no podra ser sobreescrita");

        }
        //Es importante que solo se puede poner un metodo sellado siempre y cuando haya sobreescrito 
        //un metodo de una superclass en cuyo caso no sea asi , no dejara hacerlo
        public override sealed  void MensajeQueNoPuedeSerSobreescrito()
        {
            System.Console.WriteLine("Mensaje que no puede ser sobreescrito");
        }
    }
    //Subclase 
    class Clasexd : ClaseConMetodoSellado
    {
        /* Si esto se pusiera daria error pues no puede ser sobreescrito un metodo con sealed ya que esta
        //Sellada
        public override void MensajeQueNoPuedeSerSobreescrito()
        {

        }
        */

    }
}
using System;
namespace PropiedadesParte1
{
//Las Propiedades son importantes y interesantes , estas mismas ayudan mucho a la hora de querer modificar
//O Obtener el valor de un campo de clase mediante la creacion de su objeto en la clase principal , onviamente
//No se puede modificar directamente un campo de clase o propiedad de clase , ya que siempre estan encapsuladas
//Ademas de ser una buena practica de programacion tambien es bueno encapsularla para que no puedan modificar
//El valor , para ello las propeties o propiedades , se crearon , para poder modificar ese valor o traer ese
//Valor de el campo de clase , pero con un metodo de regla , que debe seguir la propiedad para que no se pueda
//Modificar y poner lo que sea , si no siguiendo esa regla en automatico que hara la propiedad
//Ejemplo
    class Parte1Propiedades
    {
        static void Main(string[] args)
        {
            //Creacion del objeto
            ConPropiedad objeto1 = new ConPropiedad();
            //Uso de la propiedad asignandole 1200 a la propiedad del campo de clase y entrando al setter
            //Mandando el mensaje "El valor es mayor que 0"
            objeto1.PROPIEDAD = 1200;
            //Para mandar a llamar a la propiedad es como si mandaras a llamar al campo de clase 
            //Gracias a la propiedad de ahorras mas codigo y lo reduces
        }
    }
    //Creacion de clase con una propiedad
    class ConPropiedad
    {
        //Campo de clase
        private int variablePropiedad;
        //Constructor de la clase
        public ConPropiedad()
        {
            System.Console.WriteLine("Objeto el cual tiene una propiedad");
        }
        //Metodo creado para que vaya dentro de el setter de la propiedad creada , a este metodo se le considera
        //Como una regla que debe seguir la propiedad en este caso no hay alguna regla , solo retorna el mismo
        //Valor que se le dio a la variable pero mas que todo es para asignar reglas , solo se le dio instruccion
        //De que mostrara si era mayor o menor que 0
        private int MetodoDeReglaPropiedad(int variable)
        {
            if(variable < 0)
            {
                System.Console.WriteLine("El valor es menor que 0");
                return variable;
            }
            else
            {
                System.Console.WriteLine("El valor es mayor que 0");
                return variable;
            }
        }
        //Creacion de la propiedad, las propiedades no pueden contener zona de parametros como los metodos
        //Estas deben de ir sin ellas pues el valor que se le de a la propiedad ya se le da por defecto
        //Y se inyecta dentro de value que se ve en el codigo dentro de la propiedad
        //Deben incluir un get , el cual retorna el valor que se le dio a la propiedad y un setter el cual
        //Es el encargado de darle o asignarle las reglas , en este caso como el metodo no tiene como tal , solo
        //Le dice al usuario si es menor o mayor a 0 pero es para asignar reglas
        public int PROPIEDAD
        {
            //El getter para retornar el valor ya sea a alguna variable para la clase principal
            get { return this.variablePropiedad; }
            //El setter el cual le asigna el valor a la variable de el campo de clase, dandole reglas
            set{this.variablePropiedad = MetodoDeReglaPropiedad(value);}
        }

    }
}
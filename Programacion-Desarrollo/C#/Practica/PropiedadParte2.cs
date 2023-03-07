using System;
namespace PropiedadesParte2
{
//Ahora se vera lo que es en las propiedades las de tipo escritura y las de tipo lectura , algo muy importante
//A la hora de desarrollar , por ejemplo una contraseña debe de ser unicamente de tipo escritura mas no de 
//Lectura , tambien se vera una cosa que puede simplificar aun mas el codigo el cual es el lamda o funcion
//iteral el cual es "=>" poner este simbolito sirve para ya no poner el "return" pues con esa expresion queda
//Implicito que iterara el valor osease retornara el valor
//Ejemplo
    class Parte2Propiedades
    {
        static void Main(string[] args)
         {
             //Llamamos a la clase y se crea el objeto
             usuario objeto1 = new usuario("Pepe Cuenca");
             System.Console.WriteLine("Ingrese una contraseña");
             string contraseñaxd = System.Console.ReadLine();
             //Se le asigna la contraseña que ponga el usuario y se detecta si es buena o no con la propiedad
             objeto1.CONTRASEÑA = contraseñaxd;
             //Aqui solo se muestra el nombre pues es solo lectura
             string nombrexd = objeto1.USUARIO;
            
         }
    }
    //Creacion de la clase
    class usuario 
    {
        //Campos de clase
        private string contraseña;
        private string nombre;
        //Constructor
        public usuario(string usuario)
        {
            nombre = usuario;
        }
        //Creacion del metodo de regla que se aplica a la propiedad
        private string EscribirContraseña(string contraseña)
        {
            this.contraseña = contraseña;
            if(contraseña !="123456789")
            {
                System.Console.WriteLine("Contraseña Segura");
                return contraseña;
            }
            else
            {
                System.Console.WriteLine("Contraseña insegura se le asignara una contraseña");
                return "hola1234567";
            }
        }
        //Creacion de la propiedad de tipo escritura
        public string CONTRASEÑA
        {
            //Uso de lambda o iteracion
            set =>contraseña = EscribirContraseña(value);
        }
        //Creacion del metodo para la escritura
        private string nombreUsuario()
        {
            System.Console.WriteLine("Su nombre de usuario es: "+nombre);
        return nombre;
        }
        //Creacion de la propiedad de tipo solo lectura
        public string USUARIO
         {
             //uso de lambda o iteracion
             get=> nombre = nombreUsuario();
         }
    }
}
using System;
namespace HerenciaParte5
{
    //Aqui se vera lo que es el metodo de acceso de tipo "protected" ademas de la public y private la cuales ya
    //Fueron vistas anteriormente, el metodo de acceso tipo protected , lo que hace es que protege un metodo
    //O funcion o tambien a un campo de clase o propiedad de esta misma , pero solamente la protege de llamadas
    //de objetos mediante su clase principal , osease que si hereda esa clase de tipo protected a otras clases
    //Lo podran usar sin problemas y aunque sea llamada desde el objeto y eso tiene de diferencia protected
    //Aqui se vera un ejemplo 
    class Parte5Herencia
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escriba el medio de transporte por el cual manejara");
            System.Console.WriteLine("1-Avion\n2-Coche");
            int Seleccion = int.Parse(System.Console.ReadLine());
            Seleccionxd(Seleccion);
            System.Console.WriteLine("El programa a finalizado");
        }
        static void Seleccionxd(int seleccionxddd)
        {
            string respuestaObvia;
            switch(seleccionxddd)
            {
                case 1:
            System.Console.WriteLine("¿Quiere ingresar ya al vehiculo?");
            respuestaObvia = System.Console.ReadLine();
            if(respuestaObvia == "si"){
            avion objetoAvion = new avion(respuestaObvia);
             }
             else{
                 System.Console.WriteLine("No Ingreso al vehiculo");
             }
                break;

                case 2:
            System.Console.WriteLine("¿Quiere ingresar ya al vehiculo?");
            respuestaObvia = System.Console.ReadLine();
            if(respuestaObvia == "si"){
            Coche objetoCoche = new Coche(respuestaObvia);
             }
             else
             {
                System.Console.WriteLine("No Ingreso al vehiculo");
             }
                break;

                default:
                System.Console.WriteLine("Seleccione una opcion valida");
                break;

            }
        }
    }
    //Superclass llamada vehiculo
    class vehiculo
    {
         private string respuesta;
        public vehiculo(string respuesta)
        {
            System.Console.WriteLine("¿Desea manejar ya?");
            respuesta = System.Console.ReadLine();
            this.respuesta = respuesta;
            ArrancarMotor(respuesta);



        }
        protected void ArrancarMotor(string respuestaxd)
        {
            System.Console.WriteLine("Se esta arrancando el motor");
            Conducir();
            int i=5;
            while(respuestaxd != "no"){
                
                int contador =0;
                while(contador<= i)
                {
                System.Console.WriteLine("Rum Rum Rum\n Rum Rum Rum");
                contador++;
                }
                i+=4;
              respuestaxd =  PararMotor(respuestaxd);
            }
        }
        protected string PararMotor(string respuesta )
        {
            System.Console.WriteLine("¿Desea continuar manejando?");
            respuesta = System.Console.ReadLine();
            this.respuesta = respuesta;
            return respuesta;
        }
        public virtual void Conducir()
        {
            System.Console.WriteLine("Usted esta conduciendo");
        }
    }
    //Subclass llamada avion
    class avion : vehiculo
    {
        public avion(string respuestitaxd) :base(respuestitaxd)
        {
             System.Console.WriteLine("Usted paro de manejar el avion");
        }
        public override void Conducir()
        {
            System.Console.WriteLine("Usted esta conduciendo un avion");
        }
    }
    //Subclass llamada Coche
    class Coche : vehiculo
    {
        public Coche(string respuestaxdxd):base(respuestaxdxd)
        {
             System.Console.WriteLine("Usted paro de manejar el coche");
        }
        public override void Conducir()
        {
             System.Console.WriteLine("Usted esta conduciendo un coche");
        }
    }
}
using System;
namespace FuncionEnumParaConstantes
{
    //Comumente los enum se hacen en los namespace para que las clases lo adquieran
    //pero podrian hacerse en donde sea
    enum Meses{ENERO=10,FEBRERO=20,MARZO=30,ABRIL=40,MAYO=50,JUNIO=60,JULIO=70,AGOSTO=80,SEPTIEMBRE=90,OCTUBRE=100,NOVIEMBRE=110, DICIEMBRE=120};

    //Ahora lo que se vera es un tema algo pequeño pero igual de importante , son las funciones constantes enum
    //Estas tienen como proposito almacenar varias constantes en un tipo objeto , para no desarrollar cada una
    //Ademas tiene como ventajas brindar 2 valores , el string de el nombre de la constante y el valor de
    //Dicha constante , pero haciendo un cansting pasando el valor string a double pidiendole ese valor o
    //A int dependiendo la necesidad tambien se pueden usar como parametros para los metodos que pida un
    //Objeto de tipo enum , tambien se usa para eso , aqui se vera un ejemplo de como funciona
    //Ejemplo
    class EnumParaConstantes
    {
        static void Main(string[] args)
        {
            //Haciendo el cansting para obtener el numero que fue asignado en enero del turismo
            Meses Mesxd =Meses.ENERO;
            int TurismoEnEnero = (int)Mesxd;
            //Haciendo el cansting para obtener el nombre del primer mes del año
            Meses PrimerMes=Meses.ENERO;
            PrimerMes.ToString();
            //Creacion para el objeto de la instancia a enum
            Meses ParaObjeto = Meses.JULIO;
            //Imprimiendo en pantalla
            System.Console.WriteLine("Turismo en el mes de "+PrimerMes+":"+TurismoEnEnero);
            //Creando objeto o instancia de la clase
            Turismo objeto1 = new Turismo(ParaObjeto,ParaObjeto);
            //Imprimiendo el resultado con el metodo creado en la clase 
            System.Console.WriteLine("-----------------Con Objeto------------");
            objeto1.InfoMeses();
        }
    }
    //Clase
    class Turismo
    {
        //Campos de clase
        private Meses Turismoxd; 
        private Meses NombreMes;
        private int turismoxdd;
        //Constructor que pide 2 parametros de tipo meses de el enum
        public Turismo(Meses Turismoxd,Meses NombreMes)
        {
            //Casting para obtener el nombre del mes osease su string
            this.NombreMes = NombreMes;
            NombreMes.ToString();
            //Casting Para obtener el valor de el mes tipo enum osease el valor
            this.Turismoxd = Turismoxd;
             turismoxdd = (int) Turismoxd;
        }
        //Netodo para ver la informacion
        public void InfoMeses()
        {
           System.Console.WriteLine("Turismo en el mes de "+NombreMes+":"+turismoxdd);
        }
    }
}
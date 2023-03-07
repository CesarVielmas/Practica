using System;
namespace StructFuncion
{
//Ahora se vera lo que es las structs estas estructuras son muy similares a las clases solo que no pueden heredar
//clases ,solo se pueden heredar entre ellas osease entre struct y si pueden heredar interfaces , estas struct
//Funcionan en una memoria llamada stack , la cual ahi van todas las variables primitivas , existen 2 memorias
//La stack anteriormente dicha y la heap , estas 2 memorias , empezando por la stack es donde se guarda el
//Struct , la cual al crear un objeto hecho con instancia en struct lo que hace es que hace una copia de esta
//Misma en la memoria stack y solo toma las funciones a las cuales se estan llamando , no modifica el struct
//Como tal como lo hacen las clases, este solo modifica en la funcion o metodo que se llama y lo que contenga
//Dentro de este , mientras que las clases se guardan en la memoria heap , estas al guardarse cuando se crea
//Un objeto o se instancia este objeto toma de la memoria stack la memoria heap para poder obtener las propiedades
//Y comportamientos de esta clase y cualquier cosa que se modifique dentro de esta afectara a la clase 
//Dependiendo que haga el metodo  ambas son muy similares solo que la diferencia ahi esta , en las memorias que
//Usan , cuando se quiere hacer por temas de rendimiento y cuando se tienen muchisimas variables , osea que
//Consume mucha memoria , se recomienda mucho usar struct  para rendimiento
//Ejemplo
    class FuncionStruct
    {
        static void Main(string[] args)
         {
             //Creacion de las instancias para ver sus funcionamientos
             Empresario1 objeto1 = new Empresario1("CesarinPinguin",85000);//De la clase
             Empresario2 objeto2 = new Empresario2("FlorPepelinguin",30000);//De la estructura
             //Modificando valores aumentando los mismos
             objeto1.AumentarSueldo(objeto1,10000);//De la clase
             objeto2.AumentarSueldo(objeto2,20000);//De la estructura
             //Instancia para ver informacion
            objeto1.InfoEmpresario();//De la clase
            objeto2.InfoEmpresario();//De la estrucutra
            
            //Como se puede ver los valores de un objeto de tipo estructura no pueden cambiar , ya que la memoria
            //Stack hace una copia del objeto creado y este mismo no puede ser modificado a menos , que se haga
            //Otro objeto para que se pueda modificar los valores y ese objeto creado con las modificaciones
            //no se podra modificar a menos que hagas otro con modificaciones, esto hace que la memoria no se
            //Sobrecargue tanto como lo que sucede con las clases y sus objetos , que las clases crean la instancia
            //En la memoria stack pero crean el objeto como tal en la memoria hep , entonces al ser llamados 
            //Y modificados el objeto que tomo de instancia , pues si se modifica , para ese objeto y se puede
            //Modificar cientos de veces porque no es una copia que toma siempre los valores que fueron de la copia
            //Este es dinamico y esta separado en las clases ya que no toma la clase y crea una copia , toma la clase
            //Como tal y si le modifica , crea una copia de la clase con las modificaciones , en si tiene las 2 clases
            //La de las modificaciones y la princial algo que los structs no tienen solo tienen una copia de esta misma
            //Sin embargo ahorran recursos mas que las clases y esa son las diferencias
         }
    }
    //Creacion de clase
    class Empresario1
    {
        //Campos de clase
        private double sueldo;
        private string nombre;
        //Constructor
        public Empresario1(string nombre,double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }
        //Metodo para ver informacion
        public void InfoEmpresario()
        {
            System.Console.WriteLine( "El nombre es: "+nombre+" y el sueldo es: "+sueldo);
        }
        //Metodos para las propiedades

        private double modificarSueldo(double sueldo)
        {
            this.sueldo = sueldo;
            return sueldo;
        }
         private string modificarNombre(string nombre)
        {
            this.nombre = nombre;
            return nombre;
        }
        //Propiedades
        public string EMPRESARIO_NOMBRE
        {
            get{return nombre;}
            set{this.nombre = modificarNombre(value);}
        }
        public double EMPRESARIO_SUELDO
        {
            get{return sueldo;}
            set{this.sueldo = modificarSueldo(value);}
        }
        //Metodo tomando el objeto para modificarlo
        public void AumentarSueldo(Empresario1 emp,double aumento)
        {
            emp.nombre = "Juanito";
            emp.sueldo += aumento;
        }
    }
    //Creando la estructura
    struct Empresario2
    {
        //Campos de estructura
        private double sueldo;
        private string nombre;
        //Constructor
        //Nota no se puede modificar el constructor por defecto de las estructuras , solo en las clases
        //Y tampoco hacer sobrecarga de constructores en las estructuras
        public Empresario2(string nombre,double sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            
        }
        //Metodo para la informacion
        public void InfoEmpresario()
        {
              System.Console.WriteLine( "El nombre es: "+nombre+" y el sueldo es: "+sueldo);
        }
        //Metodos para las propiedades
        private double modificarSueldo(double sueldo)
        {
            this.sueldo = sueldo;
            return sueldo;
        }
         private string modificarNombre(string nombre)
        {
            this.nombre = nombre;
            return nombre;
        }
        //Propiedades
        public string EMPRESARIO_NOMBRE
        {
            get{return nombre;}
            set{this.nombre = modificarNombre(value);}
        }
        public double EMPRESARIO_SUELDO
        {
            get{return sueldo;}
            set{this.sueldo = modificarSueldo(value);}
        }
        //Metodo para tratar de cambiar los valores de un objeto tomado o bueno estructura tomada
         public void AumentarSueldo(Empresario2 emp,double aumento)
        {
            emp.nombre = "Juanito";
            emp.sueldo += aumento;
        }
    }
}
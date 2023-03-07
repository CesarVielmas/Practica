using System;
using System.IO;//Necesaria para usar la clase streamreader
namespace Destructoresxd
{
//Ahora lo que se vera son los destructores , esto como su nombre lo dice destruye , pero destruye los procesos
//De la memoria hep, cuando el recolector de basura o garbage collector , entra en ejecucion, el garbage collector
//En c# se activa en automatico y lo que hace es que los processo que ya no estan siendo utilizados de la 
//Memoria hep , los elimina , para liberar memoria , en C# esto ya lo hace automaticamente , aunque en lenguajes
//De programacion mas viejos como java o C el garbage collector debe de implementarlo el programador ya que
//No lo implementa solo el compilador 
//Un ejemplo usando el destructor
    class Destructores
    {
        static void Main(string[] args)
         {
             //Creacion de la instancia hacia la clase pasandole el parametro para el constructor
             LeerArchivo objeto1 = new LeerArchivo(@"/home/cesarvielmas/Programacion-Desarrollo/C#/Practica/ParteParaExcepcionesParte3.txt");
         }
    }
    //Creacion de la clase leer archivo
    class LeerArchivo
    {
        //Campos de clase
        //creando tambien una instancia hacia la clase streamReader , para la creacion de su objeto
        private StreamReader Lector;
        private string linea;
        private int contador = 0;
        private string ruta;
        //Creacion de el constructor
        public LeerArchivo(string ruta)
         {
             this.ruta = ruta;
             //Se le pasa la ruta de el archivo
             Lector = new StreamReader(ruta);
             //Se hace el ciclo para que linea tome las lineas de el objeto lector y que las pueda imprimir
             //En pantalla 
             while((linea = Lector.ReadLine())!=null)
             {
                 System.Console.WriteLine(linea);
                 contador++;
             }
         }
         //Destructor
         //Lo que hace un destructor es matar a un proceso que ya no es necesario cuando el garbage collector
         //O recolector de basura se activa , en este caso mata el proceso lector y cierra el archivo leido
         //Ya que el garbage collector solo mata los procesos de la clase , pero no de archivos externos
         //Y Para ello es el destructor
         ~LeerArchivo()
         {
             Lector.Close();
         }
    }
}
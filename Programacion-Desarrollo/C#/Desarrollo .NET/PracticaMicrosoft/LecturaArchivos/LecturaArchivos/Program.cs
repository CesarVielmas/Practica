using System;
using System.IO;
using System.Collections.Generic;//IEnumerable viene de aqui
//Para enumerar los directorios de una carpeta
IEnumerable<string> directorio = Directory.EnumerateDirectories("../../../Archivos");
//Para enumerar los archivos de una carpeta
//Esta a su vez puede recibir 2 o 3 parametros el primero es la carpeta el segundo el tipo de archivos que buscara dentro de la carpeta y el tercero la opcion de busqueda y en este caso le indica que bussque en todos los directorios que tenga la carpeta
IEnumerable<string> directorio2 = Directory.EnumerateFiles("../../../Archivos", "*.txt",SearchOption.AllDirectories);


//Funcion IEnumerable
IEnumerable<string> funcionDirectorios(string carpeta)
{

   //Se crea una lista con los txt que vaya a encontrar en los directorios
   List<string> listaTxt = new List<string>();
    //Se obtendran dichos archivos
    IEnumerable<string> archivos = Directory.EnumerateFiles(carpeta, "*", SearchOption.AllDirectories);
    //ForEach para asignar los valores a la lista
    foreach(string archivo in archivos)
    {
        listaTxt.Add(archivo);
    }
    return listaTxt;
}
//Mandando a llamar dicha funcion
IEnumerable<string> archivosJson =  funcionDirectorios("../../../Archivos");
foreach (var item in archivosJson)
{
    Console.WriteLine("Items JSON:"+item);
}

//Obtener directorio actual
Console.WriteLine(Directory.GetCurrentDirectory());
//Environment.specialfolder.desktop lo que hace es que va directamente al sistema a buscar el directorio y con GetFolderPath
//Obtiene su path
Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
//Obtener el hash especial del sistema , en windows"\" en mac "/" etc 
Console.WriteLine(Path.DirectorySeparatorChar);
//Con este comando hace un path dinamico combinando ambos strings y le añade su directory separator char
Console.WriteLine(Path.Combine("Estrella", "Patricio"));
//Con este comando se puede obtener la extension del archivo de path
Console.WriteLine(Path.GetExtension("Hola.json"));
//Con la clase directory se pueden crear directorios elimnarlos , moverlos etc
Directory.CreateDirectory("Directorio creado");
//Comprueba si ya existe un directorio mandando un valor ooleano si existen o no
Console.WriteLine(Directory.Exists("Directorio creado"));
//Para crear archivos se usa File.WriteAllText , el primer parametro es la ruta donde se creara y el segundo su contenido
File.WriteAllText("Hola.json", "Soy un archivo json");
//Para leer un archivo se usa el metodo de File ReadAllText el cual arrojara lo que contiene en un string de return
Console.WriteLine(File.ReadAllText("Hola.json"));
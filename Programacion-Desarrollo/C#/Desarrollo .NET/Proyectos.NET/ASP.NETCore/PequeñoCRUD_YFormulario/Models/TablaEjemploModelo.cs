namespace Tabla.Models;

//Aqui lo que se hace en los modelos es hacer propiedades o clases o metodos para poder usarlos en los controladores y asi mismo en la pagina
public class ParaTabla 
{
    //Creacion de propiedades para los objetos de tipo paratabla
    public int ID { get; set; }
    public string? NombreEmpleado { get; set; }
    public string? AreaEncargada { get; set; }
    public int Edad { get; set; }
    public string? Ambiguedad { get; set;}
}
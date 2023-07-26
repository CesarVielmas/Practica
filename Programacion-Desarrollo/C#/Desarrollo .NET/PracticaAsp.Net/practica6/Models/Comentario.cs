namespace practica6.Models;

public class Comentario
{
    public int Id { get; set; }

    public string? Nombre {get; set;}
    public DateTime? Fecha{get;set;}
    public string? Texto{get;set;}
    //Aqui se hace la conexion de comentario a publicacion , el cual se hace la llave foranea con publicacion para que esten conectados
    public int PublicacionId{get;set;}
    public Publicacion? Publicacion{get;set;}

}
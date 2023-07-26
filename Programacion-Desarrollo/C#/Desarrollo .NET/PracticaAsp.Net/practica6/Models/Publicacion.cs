using System.Collections.Generic;
namespace practica6.Models;
public class Publicacion
{
    public int Id { get; set; }

    public string? Titulo{get;set;}
    public string? Texto {get; set;}
    //Publicacion haciendo la conexion o el enlace hacia los comentarios para obtener una lista de estos mismos
    public List<Comentario> Comentarios{get;set;}
    public Publicacion(){
        Comentarios = new List<Comentario>();
    }
}
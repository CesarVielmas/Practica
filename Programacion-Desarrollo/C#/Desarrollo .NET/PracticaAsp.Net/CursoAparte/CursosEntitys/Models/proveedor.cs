using System;
using System.ComponentModel.DataAnnotations;
namespace CursosEntitys.Models;

public class Proveedor{
   // [Key]//Se indica que esta es la llave primaria de dicha tabla para el modelo , pues toma dicha informacion de ahi en este caso no se usa pues por defecto cuando se pone "id" en el primer elemento lo toma como primary key
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
}
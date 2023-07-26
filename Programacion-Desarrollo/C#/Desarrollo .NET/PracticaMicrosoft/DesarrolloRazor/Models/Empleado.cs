using System.ComponentModel.DataAnnotations;

namespace DesarrolloRazor.Models;
//se hace un modelo donde almacenara cada empleado con sus datos usando DataAnnotations para hacer requerido o para dar un rango etc
public class Empleado
{
    //Propiedad Id con get y set
    public int Id { get; set; }
    //El nombre es requerido
    [Required]
    //Con "?" se le indica que su valor inicial es null para no generar errores
    public string? Nombre { get; set; }
    //Aqui se hizo un enum el cual tiene 3 propiedades la cual es , empleado , gerente, lider entonces la propiedad debe escoger entre esas 3 para el puesto
    public Puesto Cargo { get; set; }
    //Propiedad contratado booleana
    public bool Contratado { get; set; }
    //Acepta numeros solo de un rango de 0.01 y 99999.99
    [Range(0.01, 99999.99)]
    public decimal Salario { get; set; }
}

public enum Puesto { Empleado, Gerente, Lider }
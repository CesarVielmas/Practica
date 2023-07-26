//El modelo usuario el cual contiene algunas validaciones para que sea obligatorio llenarlo
using System.ComponentModel.DataAnnotations;
namespace practica7.Models;

public class Usuario
{
    
    public int Id { get; set; }
    [Required(ErrorMessage ="Campo Nombre Obligatorio")]//Validacion que necesita ser requerido
    [RegularExpression(@"^[a-zA-Z\s]+$",ErrorMessage ="Nombre no valido")]//Utiliza una expresion regular para validar
    [StringLength(30,ErrorMessage ="Nombre muy extenso")]//Verifica que un string no pase de cierto numero de caracteres en este caso 30
    [DataType(DataType.Text)]//Valida que el tipo de dato enviado sea del tipo especificado por DataType
    public string? Nombre {get;set;}

    [Required(ErrorMessage ="Campo Correo Obligatorio")]
    [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage ="Correo no valido")]
    [DataType(DataType.Text)]
    public string? Correo {get;set;}
    [Required(ErrorMessage ="Campo Domicilio Obligatorio")]
    [StringLength(80,ErrorMessage ="Domicilio muy extenso")]
    [DataType(DataType.Text)]
    public string? Domicilio {get;set;}
    [Required(ErrorMessage ="Campo Edad Obligatorio")]
    [Range(0,100,ErrorMessage ="Edad incorrecta")]
    [DataType(DataType.Currency)]
    public int? Edad {get;set;}
    [Required(ErrorMessage ="Campo CURP Obligatorio")]
    [DataType(DataType.Text)]
    public string? Curp {get;set;}
}
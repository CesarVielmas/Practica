using System;
using System.ComponentModel.DataAnnotations;
namespace Validaciones.Models
{
    public class Validacionesxd
    {
        //Ahora lo que se vera son las validaciones o restricciones para poder crear formularios , estas mismas son restricciones o avisos que no dejaran pasar al usuario
        //Hasta lo complete de manera satisfactoria demasiado utiles y casi obligatorias para hacer bien un formulario

        [Required(ErrorMessage ="Ingrese su nombre")] //Lo que hace required es hacer que requiera llenar en el formulario dicha propiedad
        [MinLength(6,ErrorMessage ="Ingrese su nombre completo")] //MinLength lo que hace es reducir el valor minimo de caracteres que se pueden poner , por ejemplo aqui no se pueden poner menos de 6 caracteres
        [MaxLength(18,ErrorMessage ="Ingrese su nombre sin apellido")]//MaxLength hace casi lo mismo que MinLength pero al reves ahora el usuario no puede poner mas de 18 caracteres en este ejemplo
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="Ingrese su Apellido")]
        [MinLength(6,ErrorMessage ="Ingrese su Apellido completo")]
        [MaxLength(18,ErrorMessage ="Maximo 18 caracteres")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage ="Ingrese su edad")]
        [Range(18,100,ErrorMessage ="Ingrese una edad valida")]//Range lo que hace es mas que todo en los int que da un rango que el primero es el minimo y el siguiente el maximo los cuales no pueden ser pasados
        public int Edad { get; set; }
        [Required(ErrorMessage ="Ingrese su CURP")]
        [RegularExpression("2910346",ErrorMessage ="Ingrese un CURP Valido")]//Regular expression es muy util ya que con el apuntas que palabras debe contener como requerimiento
        public string? CURP { get; set; }
        [Required(ErrorMessage ="Ingrese su correo")]
        [EmailAddress(ErrorMessage ="Escriba un correo valido")]//Email addres es algo que ya viene incluido hace un regular expression ya que tambien contiene uno pero ya viene incluido en la libreria de validaciones
        public string? Correo { get; set; }

    }
}
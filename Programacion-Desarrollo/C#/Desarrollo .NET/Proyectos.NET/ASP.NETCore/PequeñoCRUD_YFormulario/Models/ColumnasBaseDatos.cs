using System;
using System.ComponentModel.DataAnnotations; //Se le da estas 2 librerias para poder hacer las validaciones respectivas
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Models;


    [Table ("Formulario")] //Lo que hace esta validacion es buscar la Tabla especificamente llamada formulario y se lo otorga a la clase para evitar problemas ocn el nombre
    public class ColumnasBaseDatos
    {
        [Column("IdEdad")]
        public  int? IdEdad { get; set; }
        //Aqui se le asigna que es una llamada o la principal la entity key
        //[Column("Nombre")] //Aqui lo mismo con  la validacion de buscar la tabla pero ahora con las columnas y busca la columna llamada especificamente Nombre en la tabla
        //En este caso formulario para evitar problemas con el nombre
         [Key]
        [Column("Nombre")]
         public string? Nombre { get; set; }
         [Column("Apellido")]
        public string? Apellido { get; set; }
         [Column("CURP")]
        public string? CURP { get; set; }
         [Column("Correo")]
        public string? Correo { get; set; }

        [ForeignKey("IdEdad")]
        public virtual Id Edad {get; set;}

    }

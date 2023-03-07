using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Base.Models;

    [Table("Id")]
    public class Id
    {
        [Key]
        [Column("IdEdad")]
        public int IdEdad {get; set;}
        [Column("Ciudad")]
        public string? Ciudad {get; set;}
        
        

    }

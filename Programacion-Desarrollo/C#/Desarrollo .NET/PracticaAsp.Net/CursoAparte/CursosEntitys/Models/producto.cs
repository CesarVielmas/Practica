using System;
using System.ComponentModel.DataAnnotations;
namespace CursosEntitys.Models;

public class Producto{

    public int Id { get; set; }
    public string? Descripcion { get; set; }
    public float? Precio { get; set; }
    //Foreign key , por defecto al poner el Id de dicho modelo o tabla con la que se va a relacionar lo hace por defecto
    //Pero si no se usa asi [ForeignKey("Customers", "CustomerId")] como ejemplo
    public int CategoriaId { get; set; }
    public Categoria? Categoria {get;set;}

    //Segundo Foreign Key muchos productos pueden tener un proveedor y una categoria
     public int ProveedorId { get; set; }
    public Proveedor? Proveedore {get;set;}

}
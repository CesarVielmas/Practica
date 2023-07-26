using System;

namespace CursosEntitys.Models;

public class Venta{

    public int Id { get; set; }
    public int? Cantidad { get; set; }
    //Es importante recalcar que como puede ser IEnumerable puede ser List o puede ser ICollection , etc 
    //Foreign key Productos
    public int ProductoId {get;set;}
    public IEnumerable<Producto>? Productos {get;set;}
    //Foreign key Facturas
    public int FacturaId{get;set;}
    public IEnumerable<Factura>? Facturas{get;set;}
    //una venta puede tener muchos productos o muchas facturas

}
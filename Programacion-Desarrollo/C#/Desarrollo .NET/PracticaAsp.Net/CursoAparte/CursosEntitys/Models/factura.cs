using System;

namespace CursosEntitys.Models;

public class Factura{

    public int Id { get; set; }
    public DateTime Fecha { get; set; }

    //Foreign key 
    public int ClienteId { get; set; }
    public Cliente? Cliente{get;set;}

}
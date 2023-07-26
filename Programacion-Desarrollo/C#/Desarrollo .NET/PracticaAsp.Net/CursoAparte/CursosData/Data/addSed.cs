using System;
using Microsoft.EntityFrameworkCore;
using CursosEntitys.Models;
namespace CursosData.Data;

public static class AddSed{

    //Metodo donde se hara el paso de parametros , para lo cual necesita de un model builder del objeto ModelBuilder
    public static void Seed(this ModelBuilder modelBuilder){
        //Con dicho model builder se llenaran los datos con datos de ejemplo para que sean transportados a la base de datos , para hacerlo se usa.Entity<nombre del modelo> y despues se usa el .HasData() para llenar ahi mismo los datos

        //Llenando de datos clientes
        modelBuilder.Entity<Cliente>()
        .HasData(
            new Cliente{Id=1,Nombre="Cesar Alejandro",Direccion="Mision Real",Telefono="10668239"},
            new Cliente{Id=2,Nombre="Flor Abigail",Direccion="Juan Carlos",Telefono="10673239"},
            new Cliente{Id=3,Nombre="Pedrito Solano",Direccion="San Javier",Telefono="12039489"}
        );
        //Llenando de datos Facturas
        modelBuilder.Entity<Factura>()
        .HasData(
            new Factura{Id=1,Fecha=DateTime.Now,ClienteId=2},
            new Factura{Id=2,Fecha=DateTime.Now,ClienteId=1},
            new Factura{Id=3,Fecha=DateTime.Now,ClienteId=3}
        );
        //Llenando de datos Ventas
        modelBuilder.Entity<Venta>()
        .HasData(
            new Venta{Id=1,FacturaId=2,ProductoId=3,Cantidad=20},
            new Venta{Id=2,FacturaId=3,ProductoId=1,Cantidad=40},
            new Venta{Id=3,FacturaId=1,ProductoId=2,Cantidad=60}
        );
        //Llenando de datos Productos
        modelBuilder.Entity<Producto>()
        .HasData(
            new Producto{Id=1,Descripcion="Producto numero 1 dispuesto a luchar contra el crimen",Precio=50.43f,CategoriaId=2,ProveedorId=1},
            new Producto{Id=2,Descripcion="Producto numero 2 dispuesto a luchar contra el crimen",Precio=110.673f,CategoriaId=1,ProveedorId=3},
            new Producto{Id=3,Descripcion="Producto numero 3 dispuesto a luchar contra el crimen",Precio=80.142f,CategoriaId=3,ProveedorId=2}
        );
        //Llenando de datos Categorias
        modelBuilder.Entity<Categoria>()
        .HasData(
            new Categoria{Id=1,Descripcion="Categoria 1 activada"},
            new Categoria{Id=2,Descripcion="Categoria 2 activada"},
            new Categoria{Id=3,Descripcion="Categoria 3 activada"}
        );
        //Llenando de datos Proveedores
        modelBuilder.Entity<Proveedor>()
        .HasData(
            new Proveedor{Id=1,Nombre="Proveedor Carlos",Direccion="Villa de juan luis",Telefono="1381274"},
            new Proveedor{Id=2,Nombre="Proveedor Juan",Direccion="San luis potosi",Telefono="7150293"},
            new Proveedor{Id=3,Nombre="Proveedor Cesar",Direccion="Coahuila",Telefono="8149712"}
        );
        //Despues de haber llenado todos los datos es importante ir ahora al dbContext y en el OnModelCreating hacer la semilla para que se guarden los datos
    }

}
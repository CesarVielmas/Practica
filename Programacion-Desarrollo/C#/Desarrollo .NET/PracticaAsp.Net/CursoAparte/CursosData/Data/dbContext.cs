using Microsoft.EntityFrameworkCore;
using CursosEntitys.Models;
namespace CursosData.Data;
    public class dbContext : DbContext {
        public dbContext(DbContextOptions<dbContext> options) : base (options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedors { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    //Si hay una relacion de muchos a muchos utilizar la clase OnModelCreating la cual es override , pues con ella es donde se hacen las relaciones muchos a muchos
    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    */
    //En este caso se usara OnModelCreating para hacer la semilla de datos de addSed a la base de datos
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();//Se hace la semilla para que cargue los datos a la base de datos en la migracion

        //Despues de hacer esto es importante volver a hacer una migracion y actualizarlo para que se reflejen los datos de la semilla en la base de datos
    }

    }

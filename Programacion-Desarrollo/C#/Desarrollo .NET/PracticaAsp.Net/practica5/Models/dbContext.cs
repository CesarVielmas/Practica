using Microsoft.EntityFrameworkCore;
//Usando el dbContext para hacer el contexto y obtener los datos o hacer migrations , lo cual es que mediante los modelos se creen las tablas en la base de datos
namespace practica5.Models {
    public class dbContext : DbContext {
        //En el constructor el objeto options se le pasara mediante la inicializacion del programa
        public dbContext(DbContextOptions<dbContext> options) : base (options) {

         }

        //Bases de datos para hacer la migracion
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
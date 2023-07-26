using Microsoft.EntityFrameworkCore;
//El contexto para poder hacer la conexion
namespace practica6.Models;
    public class dbContextRel : DbContext {
        public dbContextRel(DbContextOptions<dbContextRel> options) : base (options) {

         }

        public DbSet<Publicacion> Publicacions { get; set; }
        public DbSet<Comentario> Comentarios {get;set;}
    }

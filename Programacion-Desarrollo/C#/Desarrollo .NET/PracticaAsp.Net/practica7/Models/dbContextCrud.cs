//El dbContext para conectar a la base de datos 
using Microsoft.EntityFrameworkCore;
namespace practica7.Models;

    public class dbContextCrud : DbContext {
        public dbContextCrud(DbContextOptions<dbContextCrud> options) : base (options) {}

        public DbSet<Usuario> Usuarios { get; set; }
    }

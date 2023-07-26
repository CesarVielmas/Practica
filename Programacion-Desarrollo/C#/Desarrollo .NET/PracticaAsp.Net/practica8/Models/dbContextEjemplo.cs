//El dbContext de ejemplo , nada mas , nada funcional, solo es de ejemplo
using Microsoft.EntityFrameworkCore;
namespace practica8.Models;

    public class dbContextEjemplo : DbContext {
        //Toma de datos desde la clase dbContext
        public dbContextEjemplo(DbContextOptions<dbContextEjemplo> options) : base (options) {}

        //Manera 1 para hacer el dbSet para la migracion
        public DbSet<Usuario> Usuarios { get; set; }
        //Manera 2 para hacer el dbSet para la migracion
        //public DbSet<Usuario> Usuarios => Set<Usuario>();

        //Ahora para utilizar el API afluent se puede utilizar la clase que deriva de DbContext la cual debe ser sobrescrita y que necesita de un override , en dicha clase se pedira el modelBuilder el cual estaran nuestros diferentes modelos y donde se podra dar dichas restricciones antes de mandarlo a la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);//Importante poner esto para evitar errores

            //Dando restricciones a los modelos mediante api afluent
            modelBuilder.Entity<Usuario>().Property(user=>user.Nombre).HasMaxLenght(150);//Aqui se le indica que la propiedad nombre de la entidad o modelo Usuario nunca debe sobrepasar la cantidad de 150 caracteres
            
            //Y asi se podria ir con las demas propiedades , para saber mas se podria ver en la documentacion para hacerlo

            //Para aplicar las configuraciones al proyecto
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Con esta configuracion ya se aplicaran las configuraciones y asi mismo se aplicaran las restricciones
        }
        //Ahora tambien existe otra manera para no modificar de 1 por 1 cada caracteristica de cada entidad , se puede hacer que todas las entidades con cierto patron en sus propiedades , tomen ciertas restricciones , englobandolas a todas , para esto se usa el metodo ConfigureConventions , el cual recibe un ModelConfigurationBuilder
        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder){
            //Ahora aqui con el ModelConfigurationBuilder se le puede indicar a que propiedades y de que tipo , tomaran dicha restriccion y valor
            modelConfigurationBuilder.Properties<string>().HaveMaxLenght(150);//Se le indica que todas las propiedades de tipo string de todas las entidades , no pueden superar los 150 caracteres
        }
}

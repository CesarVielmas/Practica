
namespace practica8.Models.Configuraciones;

public class UsuarioConfig:IEntityTypeConfiguration<Usuario> //Debe de heredar de dicha interfaz para poder utilizar la Api afluent
{
   public void Configure(EntityTypeBuilder<Usuario> builder)//Metodo necesario por la interfaz , donde aqui mismo se haran todas las restricciones 
   {
    //Como se puede ver dentro de la configuracion se hace mas corto
    
    //  modelBuilder.Entity<Usuario>().Property(user=>user.Nombre).HasMaxLenght(150);
        builder.Property(user=> user.Casado).HasPrecision(10,2);//Ejemplo de restriccion
   }
}
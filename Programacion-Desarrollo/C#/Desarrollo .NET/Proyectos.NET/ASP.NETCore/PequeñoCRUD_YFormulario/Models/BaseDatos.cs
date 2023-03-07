using System;
using Microsoft.EntityFrameworkCore; //No olvidar poner esta libreria para poder utilizar los comandos necesarios
namespace Base.Models
{
    public class BaseDatos : DbContext //Siempre debe de heredar de dbcontext para obtener la base de datos
    {
        //En el constructor obtiene un dbcontextoptions y se pone el nombre de la clase respectiva osease esta creada y se restringe con base
        public BaseDatos(DbContextOptions<BaseDatos> options):base(options)
        {

        }
        //Aqui se hace un dbset para setear lo que se tiene en la clase columnasBaseDatos para obtener los valores mediante la base de datos y se le da el nombre de formulario
        public DbSet <ColumnasBaseDatos>Formulario {get; set;}
        public DbSet <Id>Edad {get; set;}
        
    }
}
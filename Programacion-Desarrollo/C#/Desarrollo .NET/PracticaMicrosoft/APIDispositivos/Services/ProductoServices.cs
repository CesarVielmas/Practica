//Utiliza el modelo para poder hacer su servicio
using APIDispositivos.Models;
using System.Xml.Linq;

namespace APIDispositivos.Services
{
    //debe ser una clase estatica para poder usarla sin instanciarla
    public static class ProductoServices
    {
        //Ahora aqui se hace una lista de objetos de tipo empleado el cual solo podra ser obtenida esa informacion
        //Ya que no contiene su set
        static List<Producto> Productos { get; }
        //el siguiente id sera 3?
        static int nextId = 15;
        //Aqui su constructor
        static ProductoServices()
        {
            //Aqui lo que hace es que se crean empleados de ejemplo para inyectarlos en empleados que acepta
            //Una lista de empleado
            Productos = new List<Producto>{
            new Producto { Id = 1, Nombre = "Serrucho",Precio = 290.34f,Tipo="Herreria",Cantidad=20,fecha="05/03/07"},
            new Producto { Id = 2, Nombre = "Tijeras",Precio = 390.34f,Tipo="Arquitectura",Cantidad=15,fecha="05/03/16"},
            new Producto { Id = 3, Nombre = "Mano Hidraulica",Precio = 450f,Tipo="Tornillos",Cantidad=17,fecha="12/06/20"},
            new Producto { Id = 4, Nombre = "Poderosa Mano De jose",Precio = 245.24f,Tipo="Desechos",Cantidad=40,fecha="12/06/21"},
            new Producto { Id = 5, Nombre = "Guantes",Precio = 212.334f,Tipo="Arquitectura",Cantidad=80,fecha="30/03/16"},
            new Producto { Id = 6, Nombre = "Mascarillas",Precio = 223.312f,Tipo="Herreria",Cantidad=90,fecha="28/03/09"},
            new Producto { Id = 7, Nombre = "Desarmador",Precio = 242.123f,Tipo="Tornillos",Cantidad=230,fecha="05/03/05"},
            new Producto { Id = 8, Nombre = "Afloja Todo",Precio = 34.334f,Tipo="Herreria",Cantidad=30,fecha="05/03/04"},
            new Producto { Id = 9, Nombre = "Pinzas Mecanicas",Precio = 120.33f,Tipo="Desechos",Cantidad=50,fecha="05/03/02"},
            new Producto { Id = 10, Nombre = "Pintura",Precio = 221.31f,Tipo="Comida",Cantidad=60,fecha="05/03/01"},
            new Producto { Id = 11, Nombre = "Pantalones",Precio = 223.54f,Tipo="Ropa",Cantidad=70,fecha="05/03/01"},
            new Producto { Id = 12, Nombre = "Tornillos",Precio = 420.344f,Tipo="Herreria",Cantidad=10,fecha="05/03/04"},
            new Producto { Id = 13, Nombre = "Llaves",Precio = 590.674f,Tipo="Herreria",Cantidad=20,fecha="05/03/10"},
            new Producto { Id = 14, Nombre = "Casqueria",Precio = 235.674f,Tipo="Comida",Cantidad=30,fecha="05/03/12"}
            
        };

        }
        //Metodo para hacer get?
        public static List<Producto> GetAll() => Productos;

        public static Producto? Get(int id) => Productos.FirstOrDefault(p => p.Id == id);
        //Metodo para hacer create
        public static void Add(Producto producto)
        {
            producto.Id = nextId++;
            Productos.Add(producto);
        }
        //Metodo para hacer delete
        public static void Delete(int id)
        {
            var producto = Get(id);
            if (producto is null)
                return;

            Productos.Remove(producto);
        }
        //Metodo para hacer update
        public static void Update(Producto producto)
        {
            var index =Productos.FindIndex(p => p.Id == producto.Id);
            if (index == -1)
                return;

           Productos[index] = producto;
        }
    }
}

//El servicio creado el cual es el que usara la pagina para agregar quitar o poner nuevos empleados en formulario

using DesarrolloRazor.Models;

namespace DesarrolloRazor.Services;
public static class EmpleadoService
{
    //Lista de empleados donde almacenara los empleados
    static List<Empleado> Empleados { get; }
    static int nextId = 3;
    //Constructor de la clase el cual creara 2 nuevos empleados de ejemplo al iniciar
    static EmpleadoService()
    {
        //Creacion de emplados mediante el modelo
        Empleados = new List<Empleado>
                {
                    new Empleado { Id = 1, Nombre = "Cesar Vielmas", Salario=80000.00M, Cargo=Puesto.Gerente, Contratado = true },
                    new Empleado { Id = 2, Nombre = "Flor Abigail", Salario=30000.00M, Cargo=Puesto.Empleado, Contratado = true }
                };
    }
    //Para obtener todos los empleados
    public static List<Empleado> GetAll() => Empleados;
    //Para obtener a 1 empleado
    public static Empleado? Get(int id) => Empleados.FirstOrDefault(p => p.Id == id);
    //Para añadir 1 empleado
    public static void Add(Empleado empleado)
    {
        empleado.Id = nextId++;
        Empleados.Add(empleado);
    }
    //Para borrar 1 empleado
    public static void Delete(int id)
    {
        var empleado = Get(id);
        if (empleado is null)
            return;

        Empleados.Remove(empleado);
    }
    //Para actualizar un empleado
    public static void Update(Empleado empleado)
    {
        var index = Empleados.FindIndex(p => p.Id == empleado.Id);
        if (index == -1)
            return;

        Empleados[index] = empleado;
    }
    //Como se puede apreciar son los metodos de un CRUD
}
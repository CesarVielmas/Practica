using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CursosData.Data;
using CursosEntitys.Models;
using Microsoft.EntityFrameworkCore;

namespace CursosApp.Controllers;
    //Creacion de la clase del controlador
    public class CursosAppController : Controller
    {
        private readonly ILogger<CursosAppController> _logger;//Creacion del logger
        private readonly dbContext _dbContext;//Creacion de el contexto para la instancia
        public CursosAppController(ILogger<CursosAppController> logger,dbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        //Metodo para la vista index , el cual es asincrono pues utiliza el contexto o la base de datos
        public async Task<IActionResult> Index()
        {
           foreach (var item in await _dbContext.Productos.ToListAsync())
           {
                item.Categoria = await _dbContext.Categorias.FindAsync(item.CategoriaId);//FindAsync para buscar solo 1 registro
                item.Proveedore = await _dbContext.Proveedors.FindAsync(item.ProveedorId);
           }
            //Se guardan los datos , en este caso de los clientes , aunque podria ser de cualquier otra cosa
            var datos = await _dbContext.Productos.ToListAsync();
            //Se mandan los datos a la vista para controlarlos mediante el modelo
            return View(datos);
        }
        //Metodo para realizar un POST , desde un controlador sin la necesidad de un metodo Http, pues el method se indica dentro del formulario
        public async Task<IActionResult> CrearDato([Bind("Descripcion","Precio")] Producto producto)//El Bind lo que hace es que especifica los parametros que necesitan ser mandados para la accion , junto con el modelo que tomara dicho Bind , en este caso para crear un producto necesita de una descripcion y precio , pues lo demas se rellena aqui mismo o automaticamente
        {
            if (!ModelState.IsValid)//Verifica si el modelo mandado es valido
                return RedirectToAction(nameof(Index));//si el modelo no es valido lo redirijira a la accion Index , dado por nameof()
            Random random = new Random();//Instancia para un numero random
            producto.CategoriaId = random.Next(4);//Genera un numero aleatorio del 0 al 3
            producto.ProveedorId = random.Next(4);//Genera un numero aleatorio del 0 al 3
            //Lo ultimo que falta seria el Id del producto , pero como es su primary key se rellena automaticamente en la base de datos
            _dbContext.Add(producto);//Añade dicho producto a la base de datos
            await _dbContext.SaveChangesAsync();//Despues de agragarlo se salvan los cambios y se sube a la base de datos , debe ser de manera asincrona , pues se debe esperar a lo dicho

            return NoContent();
        }
        //Ahora se hara un PUT y para eso , se creara una nueva pagina para modificar dicho dato tomando sus valores
        public async Task<IActionResult> Editar([Bind("Id")]Producto producto){

            var _producto = await _dbContext.Productos.FindAsync(producto.Id);
            if (_producto != null)
            {
                return View(_producto);
            }
           
          return NotFound();
        }
        //Metodo que hara el PUT completo
        public async Task<IActionResult> EditarCompleto([Bind("Id","Descripcion","Precio","CategoriaId","ProveedorId")]Producto producto){
            if (!ModelState.IsValid)
                return NotFound();
            _dbContext.Update(producto);//Update el cual es el encargado de hacer el PUT o update a la base de datos
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Ahora se hara un Delete y para esto solo se usara una accion o metodo del controlador
        [ActionName("Eliminar")]//Aqui se le indica el nombre de la accion , que predeterminadamente si no se indica obtiene el nombre del metodo 
        public async Task<IActionResult> DeleteCampo([Bind("Id")]Producto producto){
            if (producto == null)
                return NotFound();
            var _producto = await _dbContext.Productos.FindAsync(producto.Id);//Se encuentra el producto por su Id
            _dbContext.Productos.Remove(_producto);//Con remove se hace el Delete a dicho apartado para la base de datos , obviamente pide el objeto completo para hacer el delete
            await _dbContext.SaveChangesAsync();//Para guardar los cambios hechos a la base de datos
            return NoContent();

        }
    }
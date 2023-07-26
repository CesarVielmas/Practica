using Microsoft.AspNetCore.Mvc;
using ApiMicrosoft.Models;
using ApiMicrosoft.Services;

namespace ApiMicrosoft.Controllers
{
    //Ahora en los controladores es donde se usaran los modelos y los servicios para dicho controlador que ya
    //Fueron hechos

    //El apiController para darle la funcionalidad necesaria a la clase
    [ApiController]
    //La ruta que tomara la url por defecto controller , osease el nombre del controlador
    [Route("[controller]")]
    //Debe de heredar de la clase ControllerBase para poder obtener sus metodos y propiedades varias
    public class ProductosController : ControllerBase
    {
        //Contructor
        public ProductosController()
        {

        }
        // GET all action
        [HttpGet]
        //Lo que hace es usar el GetAll de el servicio el cual mandara una lista de objetos de tipo Empleado
        //El ActionResult es como la clase base para mandar dichos datos a la web api o ejecutarlo, es obligatorio
        public ActionResult<List<Producto>> GetAll() => ProductoServices.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        //Metodo para poder obtener un empleado con get pero obteniendo como parametro el id
        public ActionResult<Producto> Get(int id)
        {
            var producto = ProductoServices.Get(id);

            if (producto == null)
                return NotFound();

            return producto;
        }

        // POST action
        [HttpPost]
        //Ahora con HttpPost lo que hara es que ya no obtendra la informacion como get , si no ahora
        //Le pasara informacion a la Api en un objeto de tipo IActionResult para poder ponerlas en la pagina
        public IActionResult Crear(Producto producto)
        {
            //Aqui se le añade el empleado a el servicio de empleados para añadirlo y que sean varios mas
            ProductoServices.Add(producto);
            //En el return siempre debe mandarse un CreaedAtAction el cual recibe como parametros
            /*
             El primer parámetro de la llamada al método CreatedAtAction representa un nombre de acción. Se usa la palabra clave nameof para evitar codificar de forma rígida el nombre de la acción.
            CreatedAtAction usa el nombre de la acción para generar un encabezado de respuesta HTTP location con una dirección URL a el empleado recién creada, como se ha explicado en la unidad anterior.
             */
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }

        // PUT action
        [HttpPut("{id}")]
        //Lo mismo que post , pero como es un put y es de actualizar algun empleado recibira un id ara hacer
        //Dicha accion y tambien debe retornar un objeto de tipo IActionResult para enviarla a la pagina pues
        //Get mandaba datos a la pagina y ahora este manda datos a el servidor para añadirselos o actualizarlo
        public IActionResult Actualizar(int id, Producto producto)
        {
            /*
            Responde solo al verbo HTTP PUT, tal y como indica el atributo [HttpPut].
Requiere que se incluya el valor del parámetro id en el segmento de URL después de pizza/.
Devuelve IActionResult porque no se conoce el tipo de valor devuelto ActionResult hasta el tiempo de ejecución. 
Los métodos BadRequest, NotFound y NoContent devuelven los tipos BadRequestResult, NotFoundResult y NoContentResult, respectivamente. 
             
             */
            if (id != producto.Id)
                return BadRequest();

            var existeProducto = ProductoServices.Get(id);
            if (existeProducto is null)
                return NotFound();

            ProductoServices.Update(producto);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        //Con delete lo mismo , enviara datos al servidor pero tomara un id para eliminar dicho empleado
        //En especifico
        public IActionResult Eliminar(int id)
        {

            var producto = ProductoServices.Get(id);

            if (producto is null)
                return NotFound();

            ProductoServices.Delete(id);

            return NoContent();
        }
    }
}

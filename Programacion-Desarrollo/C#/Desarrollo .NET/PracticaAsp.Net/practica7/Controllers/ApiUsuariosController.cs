using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using practica7.Models;
//Controlador para manejar las acciones por defecto de CRUD
namespace practica7.Controllers;
    [Route("api/usuarios")]//La ruta que tomara dicho controlador para que se active o para entrar a este mismo
    [ApiController] //Se le indica que sera un ApiController , pues este funcionara como API para sus acciones
    public class ApiUsuariosController : ControllerBase //Como es un API controller debe de heredar de ControllerBase
    {
        private readonly dbContextCrud _context;//Propiedad privada para el contexto , osea la base de datos

        public ApiUsuariosController(dbContextCrud context)//Constructor el cual llenara los datos de la base de datos al contexto
        {
            _context = context;
        }
        [HttpGet] //Accion por defecto GET del controlador 
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()//Aqui como debe ser asincrono el metodo para la peticion , envia una lista de usuarios el cual sera tomada por el context
        {

          if (_context.Usuarios == null)//Si no hay ningun usuario , entonces se manda un NotFound
          {
              return NotFound();
          }
            return await _context.Usuarios.ToListAsync();//Si si hay , entonces se manda una lista con los usuarios
        }

        
        [HttpGet("{id}")]//Ahora esta seria la accion GET por defecto del controlador , pero esperando un parametro , el cual es el "id" en la url para que acceda a dicho usuario en especifico
        public async Task<ActionResult<Usuario>> GetUsuario(int id)//este es otro metodo asincrono el cual espera un id pues es el id de la url y con dicho id , devolvera un objeto de tipo usuario del modelo , pues se espera solo recibir 1
        {

          if (_context.Usuarios == null)//Si no hay usuarios entonces devuelve un notfound
          {
              return NotFound();
          }
            var usuario = await _context.Usuarios.FindAsync(id);//Si hay usuarios entonces , que encuentre asincronamente dicho usuario mediante su id , esta es una manera para encontrarlo pero podria ser de otra

            if (usuario == null)//Si el usuario encontrado no existe entonces retorna un notfound
            {
                return NotFound();
            }

            return usuario;//Si existe el usuario entonces retorna el usuario
        }

        
        [HttpPut("{id}")]//Este es el metodo PUT el cual espera un parametro , en este caso el id , pues necesita dicho id para saber a que usuario va a editar o modificar
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)//Este es un metodo vacio asincrono , el cual no devolvera nada , pero sin embargo modificara al usuario mandado en sus parametros , este mismo mediante el method , en este caso el method de fetch de javascript , pero podria ser otro , para mandarle dichos datos , este mismo encontrara el id y el usuario mandado lo modificara a el usuario buscado
        {
            if (id != usuario.Id)//si el id es diferente del usuario mandado , entonces no tiene sentido y se manda un badRequest , pues ambos deben de coincider
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;//establece el estado de la entidad usuario en Modified (Modificado). Esto le indica a Entity Framework que la entidad ha sido modificada y que los cambios deben guardarse en la base de datos cuando se llame al método SaveChanges en el contexto.

            //cuando se llama a SaveChanges, Entity Framework generará automáticamente una sentencia SQL UPDATE para aplicar los cambios en la base de datos. Esto significa que se actualizarán los valores de los campos modificados de la entidad en la tabla correspondiente en la base de datos.

            //En resumen, al establecer EntityState.Modified, le estás indicando a Entity Framework que la entidad ha sido modificada y que los cambios deben guardarse en la base de datos cuando se llame a SaveChanges.

            try//Intenta guardar los cambios para la base de datos y guardalo
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)//Si no se puede entonces ,toma la excepcion y enviala al usuario
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();//Como el metodo no debe enviar nada , se retorna un NoContent pues es un metodo vacio y ya se habra modificado dicho elemento en la base de datos
        }

        
        [HttpPost]//Ahora el POST , este mismo puede ser un metodo vacio o no , dependiendo la necesidad, con esta linea se le indica que hara un POST a la base de datos en especifico
        public async Task<ActionResult> PostUsuario(Usuario usuario)//Aqui este sera un metodo asincrono vacio , pues solo se enviara dicho usuario tomado para el post por el method y este se guardara en la base de datos
        {
            if (!ModelState.IsValid)//Verifica si el modelo enviado es valido a lo que se espera y si no manda un problema
                return Problem("Datos enviados invalidos");

            _context.Usuarios.Add(usuario);//Si es valido entonces lo añade a la base de datos y hace el post correspondiente
            await _context.SaveChangesAsync();// y guarda los cambios a la base de datos

            return NoContent();//No manda nada pues , solo se postea
        }

        
        [HttpDelete("{id}")]//Ahora la accion Delete , para ello se necesita un id en la url , pues este mismo se necesita para saber a que usuario se tendra que eliminar
        public async Task<IActionResult> DeleteUsuario(int id)//metodo asincrono vacio , pues solo eliminara a el usuario que fue seleccionado , mediante el id que se le pide
        {
            if (_context.Usuarios == null)//Si no hay usuarios en la base de datos , entones no tiene sentido y manda un notFound
            {
                return NotFound();
            }
            var usuario = await _context.Usuarios.FindAsync(id);//Encuentra al usuario mediante la base de datos y lo guarda en una variable
            if (usuario == null)//Si el usuario , no existe entonces tambien se retorna un notFound
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);//Ahora despues , se remueve el usuario de la base de datos 
            await _context.SaveChangesAsync();//despues se guarda la base de datos y sus dichos cambios

            return NoContent();//Se retorna un not content pues es un mtodo vacio y lo que se queria hacer se hizo
        }

        private bool UsuarioExists(int id)//Metodo opcional , para saber si el usuario existe o no , usado en el update
        {
            return (_context.Usuarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }


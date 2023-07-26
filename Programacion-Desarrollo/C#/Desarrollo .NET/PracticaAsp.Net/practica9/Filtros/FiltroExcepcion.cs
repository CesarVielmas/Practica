using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using practica9.Models;

namespace practica9.Filtros;
//Se crea la clase la cual hara cada uno de los filtros personalizados que sucedan en la aplicacion
public class FiltroExcepcion : IExcepcionFilter
{
    private readonly IWebHostEnvironment _webHostEnvironment;//Para obtener el servidor o nombre de la aplicacion donde se esta usando
    private readonly IModelMetadataProvider _modelMetaDataProvider;//PAra obtener los datos de los modelos

    public FiltroExcepcion(IWebHostEnvironment webHostEnvironment,IModelMetadataProvider modelMetaDataProvider){
        _webHostEnvironment = webHostEnvironment;//Esto es para que al iniciar el constroctor se guarden los datos
        _modelMetaDataProvider = modelMetaDataProvider;
    }
    public void OnException(ExceptionContext context){
       /* if ()
        {
            
        }
    Esto es para poder manejar mas excepciones personalizadas
    */
        context.Result = new JsonResult("Fallo garrafal en la aplicacion personalizado");//Mandara una respuesta json si hay error 
    }
}
using Microsoft.AspNetCore.Mvc;

namespace ApiMicrosoft.Controllers
{
    /*
     [ApiController] habilita comportamientos fundamentados que facilitan la compilaci�n de API web. 
     Algunos comportamientos incluyen inferencia de origen de par�metros, 
     enrutamiento de atributos como un requisito y mejoras en el control de errores de validaci�n de modelos.
     */
    [ApiController]
    /*
   [Route] define el patr�n de enrutamiento [controller]. 
    El token [controller] se sustituye por el nombre del controlador 
   (no distingue may�sculas de min�sculas ni tiene el sufijo Controller).
    Este controlador controla las solicitudes a https://localhost:{PORT}/weatherforecast.  

    La ruta podr�a contener cadenas est�ticas, como en api/[controller]. 
    En este ejemplo, este controlador controlar�a una solicitud a https://localhost:{PORT}/api/weatherforecast.
     */
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
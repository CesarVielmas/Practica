using System;
using System.Text.RegularExpressions;
namespace ExpresionesRegulares
{
//Ahora lo que se vera son las expresiones regulares estas mismas sirven para buscar alguna palabra o numero
//Dentro de una linea de caracteres o letras o numeros , es muy util al hacer busquedas en las bases de datos
//Y es uno de los pilares para la busqueda mas que todo en bases de datos
//Ejemplo
//Para ver cada sintaxis de busqueda ver la documentacion oficial de microsoft en .net
    class ExpresionesRegularesxd
    {
        static void Main(string[] args)
        {
            //Cadena a evaluar
            string cadenaEvaluar = "Cesar 129  20 años vielmassalais023@gmail.com";
            //Buscar 3 numeros dentro de esa cadena para mas informacion consultar la sintaxis en la documentacion
            //Oficial de .net
            string patron = @"\d[3]";
            //Aqui se le da el patron ya que toma el patron para evaluar con Regex
            Regex hola = new Regex(patron);
            //Aqui se evalua completamiente y asigna un valor si es verdadero o no asigna nada si es falso
            //Con MatchCollection
            MatchCollection match = hola.Matches(cadenaEvaluar);
            if(match.Count > 0)
            {
                System.Console.WriteLine("Se a encontrado un numero asi");
            }
            else
            {
                System.Console.WriteLine("No se a encontrado un numero asi");
            }
        }
    }
}
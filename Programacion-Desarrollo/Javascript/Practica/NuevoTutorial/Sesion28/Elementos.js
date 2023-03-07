export const valorPI = Math.PI,
valor2 = window.prompt("Ingrese el valor de la rueda"),
valor3 = window.confirm("¿Desea confirmar y seguir?");
//Se exportan las cosas que se van a usar con la palabra export 

//Tambien otra de las cualidades es el default export el cual se usa para
//Exportar en automatico cualquier valor pero solo puede ser usado una vez
//Ejemplo
//     export default function hola()
//     {
//     console.log("Hola");
//     }
//Aunque para usarla en constantes o variables , omitiendo funciones no expresadas y variables de tipo var
//Deben de exportarse despues de haber sido declaradas 
//Ejemplo
const variable2 = "";
export default variable2;
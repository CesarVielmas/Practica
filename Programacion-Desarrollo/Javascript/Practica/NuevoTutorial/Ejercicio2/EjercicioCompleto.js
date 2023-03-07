/*
5) Programa una función que invierta las palabras de una cadena de texto, pe. miFuncion("Hola Mundo") devolverá "odnuM aloH".
6) Programa una función para contar el número de veces que se repite una palabra en un texto largo, pe. miFuncion("hola mundo adios mundo", "mundo") devolverá 2.
7) Programa una función que valide si una palabra o frase dada, es un palíndromo (que se lee igual en un sentido que en otro), pe. mifuncion("Salas") devolverá true.
8) Programa una función que elimine cierto patrón de caracteres de un texto dado, pe. miFuncion("xyz1, xyz2, xyz3, xyz4 y xyz5", "xyz") devolverá  "1, 2, 3, 4 y 5.
                    <  >
*/
//Problema 5
export const problema5 = (cadena = "")=>
{
    let elemento;
    if(!cadena) return console.warn("Usted no ingreso ninguna cadena");
    cadena.split("").reverse();
    for (let i = cadena.length-1; i > -1; i--) {
        (i === cadena.length-1)
        ?elemento = cadena[i]
        :elemento = elemento + cadena[i];
    }
    return elemento;
}
//Split como ya conocemos convierte en un arrreglo la cadena de texto con un separador
//En este caso no se quiso poner separador para que fuera todo junto
//reverse es un metodo de los arreglos y lo que hace es invertir el texto "Hola" = "aloH" 
//join lo que hace es juntar todas las posiciones de un arreglo y convertilo en texto
const elemento = problema5("Hola buenas noches");
console.log(elemento);
//Problema 6
const problema6 = (cadena = "",busqueda = null)=>
{
    if(!cadena) return console.warn("Usted no ingreso ninguna cadena");
    if(!busqueda) return console.warn("Usted no ingreso ninguna busqueda");
    let i=0,contador=0;    
    while(i!== -1)
    {
       i = cadena.indexOf(busqueda,i);//indexOf lo que hace es buscar el valor que se le de como referencia en el primer parametro y asignar un numero ya sea -1 si no esta o 1 si esta en la cadena de texto
       //El segundo parametro es para indicar en que posicion buscar la palabra
        if (i !== -1) {
         i++;   
         contador++;
        }
    }

}
console.log(problema6("Hola Hola","Hola"));
//Problema 7 
const problema7 = (cadena = "")=>
(!cadena)
?console.warn("No ingreso ninguna cadena")
:(problema5(cadena) === cadena)
?console.info("Es un palindromo")
:console.info("No es un palindromo");
problema7("salas");
//Problema 8
const problema8 = (valorAQuitar,...cadena)=>
{
    const arrayEjemplo = [];
    let i=0;
    if(!cadena)return console.warn("Alguna cadena esta vacia");
    if(!valorAQuitar) return console.warn("No dio ningun patron");
    cadena.forEach((elemento)=>
    {
    console.log(elemento.replace(new RegExp(valorAQuitar,"ig"),""));
});
//En el problema 8 lo que se hace es crear una expresion regular para buscar si esta dicho valor a quitar en la cadea
//si esta en la cadena le va a seguir hasta que encuentre otra si es que lo hay , gracias a las banderas "ig" las cuales
//Pueden buscarse en wikipedia 
}
//Replace lo que hace es que toma un valor a remplazar dentro de una cadena y lo sistituye por su segundo parametro
problema8("a","Hola","Hola gustavo","Hola juan");

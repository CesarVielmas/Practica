/* Ejercicios
1) Programa una función que cuente el número de caracteres de una cadena de texto, pe. miFuncion("Hola Mundo") devolverá 10.
2) Programa una función que te devuelva el texto recortado según el número de caracteres indicados, pe. miFuncion("Hola Mundo", 4) devolverá "Hola".
3) Programa una función que dada una String te devuelva un Array de textos separados por cierto caracter, pe. miFuncion('hola que tal', ' ') devolverá ['hola', 'que', 'tal'].
4) Programa una función que repita un texto X veces, pe. miFuncion('Hola Mundo', 3) devolverá Hola Mundo Hola Mundo Hola Mundo.
*/
//Problema 1
function problema1(cadena)
{
    console.log(cadena.length);
}
const cadena1 = "Hola mundo";
problema1(cadena1);
//Problema 2
function problema2(texto,cantidadTexto)
{
    const arregloEjemplo = new Array(cantidadTexto);
    let textoEjemplo ="";
    let i = 0;
    while(i<cantidadTexto)
    {
        arregloEjemplo[i]=texto.charAt(i);
        i++;
    }
    for (let k = 0; k < arregloEjemplo.length; k++) {
         textoEjemplo = textoEjemplo + arregloEjemplo[k];
        
    }
    return console.log(textoEjemplo);
}
const cadena2 = "Mauri mundo";
problema2(cadena2,4);
//O tambien puede ser de otra manera la cual puede ser asi
const segundoProblema2 = (texto = "",cantidadTexto=null)=>
(!texto)
?console.warn("Usted no ingreso ningun texto")
:(!cantidadTexto)
?console.warn("Usted no ingreso ninguna cantidad de texto a evaluar")
:console.log(`Usted ingreso ${texto} y elijio la cantidad de ${cantidadTexto} quedando asi: ${texto.slice(0,cantidadTexto)}`);//El metodo slice lo que hace es cortar un texto el cual se le da de parametro un inicio y un final donde lo cortara
segundoProblema2(cadena2,4); 
//Problema 3
const problema3 =(texto = "",separador = null) => 
(!texto)
?console.warn("No se ingreso ningun texto")
:(!separador)
?console.warn("No se dio ningun separador")
:console.info(texto.split(separador));//el metodo split lo que hace es hacer un array con dicho separador como parametro
const textoEjemplo = "Pedro picapiedra";
const problema3Array = new Array();
problema3(textoEjemplo," ");
//Problema 4
function problema4(texto,repeticiones) {
    let i = 0;
    while (i<repeticiones) {
        console.log(texto);
        i++;
    }
}
problema4("Hola esteban",4);
/*
12) Programa una función que determine si un número es primo (aquel que solo es divisible por sí mismo y 1) o no, pe. miFuncion(7) devolverá true.
13) Programa una función que determine si un número es par o impar, pe. miFuncion(29) devolverá Impar.
14) Programa una función para convertir grados Celsius a Fahrenheit y viceversa, pe. miFuncion(0,"C") devolverá 32°F.
                                <  >
*/
//Problema 12
const problema12 = (numero = null)=>
(numero === null)
?console.warn("No a puesto ningun numero")
:((numero%2)===1)
?console.info(`El numero ${numero} si es un numero primo`)
:(numero === 2)
?console.info(`El numero ${numero} si es un numero primo`)
:console.info(`El numero ${numero} no es un numero primo`);

problema12(2);
//Problema 13
const problema13 = (numero = null)=>
(numero === null)
?console.warn("No a puesto ningun numero")
:((numero%2)===1)
?console.info(`El numero ${numero} es un numero impar`)
:console.info(`El numero ${numero} es un numero par`);

problema13(2);
//Problema 14
const problema14 = (medicion,...grados)=>
{
    medicion.toUpperCase();
    if (!medicion) return console.warn("Usted no ingreso ningun valor de medicion");
    if (typeof(medicion)!== "string") return console.warn("Usted no ingreso ningun valor de medicion valido");
    if (medicion.length >1) return console.warn("Usted no ingreso de manera correcta el caracter de medicion");
    if (medicion === "C" || medicion === "F")
    {

    }
    else return console.warn("Solo se aceptan grados farenheit o centigrados");
    grados.forEach((grado)=>
    {
        if (medicion === "F") {
            console.log(`Conversion de ${grado}ºF a centigrados = ${grado-32}ºC`)
        }
        else
        {
            console.log(`Conversion de ${grado}ºC a farenheit = ${grado+32}ºF`)
        }
    });

}
problema14("F",-12,0,2,3,4,5,6,12,23,45,64);
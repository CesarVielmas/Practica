/*
9) Programa una función que obtenga un numero aleatorio entre 501 y 600.
10) Programa una función que reciba un número y evalúe si es capicúa o no (que se lee igual en un sentido que en otro), pe. miFuncion(2002) devolverá true.
11) Programa una función que calcule el factorial de un número (El factorial de un entero positivo n, se define como el producto de todos los números enteros positivos desde 1 hasta n), pe. miFuncion(5) devolverá 120.
                            <  >
*/
import { problema5 as voltearValor } from "../Ejercicio2/EjercicioCompleto.js";

//Problema 9
const problema9 = ()=>
{
    let contador = 0,variableAleatoria;
    while(contador<1)
    {
        variableAleatoria = Math.random()*1000;
        variableAleatoria = Math.round(variableAleatoria);
        if (variableAleatoria >500 && variableAleatoria < 601) {
            contador++;
        }

    }
    return variableAleatoria;
}  
const variableAleatoria = problema9();
console.log(variableAleatoria);
//Problema 10
const problema10 = (numeroEvaluar = null)=>
(numeroEvaluar===null)
?console.warn("Usted no dio ningun numero")
:(numeroEvaluar == voltearValor(numeroEvaluar.toString()))
?console.info(`El numero ${numeroEvaluar} es capicua`)
:console.info(`El numero ${numeroEvaluar} no es capicua`);
problema10(2002);
//Problema 11
const problema11 = numero=>
{
    numero = numero || null;
    if (numero === null) {
        return console.warn("Usted no dio ningun numero");
    }
    let contador=numero,factorial;
    while(contador !== 1)
    {
        (contador === numero)
        ?factorial =numero * (contador-1)
        :factorial = factorial * (contador-1);
        contador--;
    }
    return factorial;
}
let factorial = problema11(7);
console.info(factorial);


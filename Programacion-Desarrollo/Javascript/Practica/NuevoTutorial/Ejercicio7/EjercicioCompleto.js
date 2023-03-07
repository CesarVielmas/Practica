/*
21) Programa una función que dado un array numérico devuelve otro array con los números elevados al cuadrado, pe. mi_funcion([1, 4, 5]) devolverá [1, 16, 25].
22) Programa una función que dado un array devuelva el número mas alto y el más bajo de dicho array, pe. miFuncion([1, 4, 5, 99, -60]) devolverá [99, -60].
23) Programa una función que dado un array de números devuelva un objeto con 2 arreglos en el primero almacena los números pares y en el segundo los impares, pe. miFuncion([1,2,3,4,5,6,7,8,9,0]) devolverá {pares: [2,4,6,8,0], impares: [1,3,5,7,9]}.
                             <  >
*/
//Problema 21
const problema21 = (array = null)=>
{
    const arrayCuadrado = [];
    let contador = 0;
    if (array === null) return console.warn("No ingreso nada");
    if (array instanceof Array === false) return console.error("Lo que ingreso no es un array");
    array.forEach(elemento => {
      arrayCuadrado[contador] = Math.pow(elemento,2);
      contador++;     
    });
    return console.info(arrayCuadrado);
}
problema21([1,4,5]);
//Problema 22
const problema22 = (array = null)=>
{
    let arrayMaximo = 0,
    arrayMinimo = 0;
    const arrayCompleto = [];
    let contador = 0;
    if (array === null) return console.warn("No ingreso nada");
    if (array instanceof Array === false) return console.error("Lo que ingreso no es un array");
    array.forEach(elemento=>
    {
        if(contador===0)
        {
            arrayMaximo = elemento;
            arrayMinimo = elemento;
            contador++;
        }
        else
        {
            if (arrayMaximo>elemento) arrayMaximo = arrayMaximo;
            else if(elemento>arrayMaximo) arrayMaximo = elemento;
            if (elemento>arrayMinimo) arrayMinimo = arrayMinimo;
            else if(arrayMinimo>elemento)arrayMinimo = elemento;
        }
        
    })
    arrayCompleto[0]=arrayMaximo;
    arrayCompleto[1]=arrayMinimo;

    return console.info(arrayCompleto); 
}
problema22([1,4,5,99,-60]);
//Problema 23
const problema23 = (array = null)=>
{
    const arrayPar = [],
    arrayImpar=[];
    let contador = 0;
    if (array === null) return console.warn("No ingreso nada");
    if (array instanceof Array === false) return console.error("Lo que ingreso no es un array");
    array.forEach(elemento=>
        {
            ((elemento%2)===1)
            ?arrayImpar[contador] = elemento
            :arrayPar[contador] = elemento;
            contador++;
        })
    return console.info(arrayPar,arrayImpar);
}
problema23([1,2,3,4,5,6,7,8,9,0]);
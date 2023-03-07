/*
24) Programa una función que dado un arreglo de números devuelva un objeto con dos arreglos, el primero tendrá los numeros ordenados en forma ascendente y el segundo de forma descendiente, pe. miFuncion([7, 5,7,8,6]) devolverá { asc: [5,6,7,7,8], desc: [8,7,7,6,5] }.
25) Programa una función que dado un arreglo de elementos, elimine los duplicados, pe. miFuncion(["x", 10, "x", 2, "10", 10, true, true]) devolverá ["x", 10, 2, "10", true].
26) Programa una función que dado un arreglo de números obtenga el promedio, pe. promedio([9,8,7,6,5,4,3,2,1,0]) devolverá 4.5.
                                 <  >
*/
//Problema 24
const problema24 = (arreglo = null)=>
{
    if (arreglo === null) return console.warn("No ingreso ningun arreglo");
    if (arreglo instanceof Array === false) return console.warn("Lo que usted ingreso no es un arreglo");
    for (const elementos of arreglo) {
        if(typeof(elementos)==="string")return console.error(`El elemento ingresado "${elementos}" no es un numero`)
        else "";
    }
    //For of lo que hace es inspeccionar cada elemento de un objeto o ver cada elemento de un array o string 
    //For in es como un for pero simplificado nada mas
    let contador =0,contadorRellenar = 0,arrayEjemplo = new Array(),repetitivo =0;
    for (const elemento of arreglo) {
        arrayEjemplo[contador] = elemento;
        contador++;
    }
    contador = 0;
    return console.info({
        ascendente: arreglo.map((elementos)=>
        {
            let valorEjemplo = Math.min(...arrayEjemplo);
            for (const elemento of arrayEjemplo) {
               if (elemento === valorEjemplo)
               {
                arrayEjemplo[contador] = 10000000;
                break;
               }
               contador++;
            }
            contador = 0;
            return valorEjemplo;
        })
        ,
        descendente:arreglo.map(()=> 
        {
            let valorEjemplo = Math.max(...arreglo);
            for (const elemento of arreglo) {
               if (elemento === valorEjemplo)
               {
                arreglo[contador] = 0;
                break;
               }
               contador++;
            }
            contador = 0;
            return valorEjemplo;
        })

    });
}   
problema24([2,45,41,2,1,3,2]);
//Otra forma mas sencilla de resolver el problema es la siguiente
const problema24SegundaOpcion = (arreglo = null)=>
{
    if (arreglo === null) return console.warn("No ingreso ningun arreglo");
    if (arreglo instanceof Array === false) return console.warn("Lo que usted ingreso no es un arreglo");
    for (const elementos of arreglo) {
        if(typeof(elementos)==="string")return console.error(`El elemento ingresado "${elementos}" no es un numero`)
        else "";
    }
    return console.info({
        ascendente:arreglo.map(elemento => elemento).sort()
        ,
        descendente:arreglo.map(elemento => elemento).sort().reverse()
    })
}
//Sort lo que hace es ordenar demanera ascendente valores numericos ._.
//Y con reverse el cual los ordena al reves obviamente si estan ordenados de manera ascendente al reves seria descendente
problema24SegundaOpcion([2,45,41,2,1,3,2]);
//Problema 25
const problema25 = (arreglo = null)=>
{
    if (arreglo === null) return console.warn("No ingreso ningun arreglo");
    if (arreglo instanceof Array === false) return console.warn("Lo que usted ingreso no es un arreglo");

    const arregloCompleto1 = arreglo;
    const arregloCompleto = [];
    let contador = 0,repetitivo = 0;
    for (const elemento of arreglo) {
        if (repetitivo>1) {
            arregloCompleto1[contador] = 0;
            repetitivo = 0;
        }
        if(elemento === arregloCompleto1[contador])
        {
            repetitivo++;
        }
        
        contador ++;
    }
    contador=0;
    for (const elemento of arregloCompleto1) {
        if(elemento ===0) "";       
        else {
                arregloCompleto[contador] = elemento;
                contador++;
             }
       
    }
    return console.info(arregloCompleto);
}
problema25(["x", 10, "x", 2, "10", 10, true]);
//Otra manera de solucionar el problema 25
const problema25SegundaOpcion = (arreglo = null)=>
{
    if (arreglo === null) return console.warn("No ingreso ningun arreglo");
    if (arreglo instanceof Array === false) return console.warn("Lo que usted ingreso no es un arreglo");
    return console.info(
        {
            sinDuplicados:arreglo.filter((valor,index,self)=> self.indexOf(valor)=== index)
        }
    )
}
//Ahora aqui con el metodo filter de los arreglos puede tener 3 parametros el cual el primero es el valor , el segundo la posicion en el arreglo
//y la tercera poder pasarle el mismo arreglo que se esta filtrando
//Ahora ahi lo que se hizo con pasarle el mismo arreglo que se esta filtrando se usa el metodo indexOf el cual evalua si existe un valor
//en sus parametros y si encuentra ese valor por ejemplo aqui en la posicion index entonces se pasa una vez y si vuelve a salir se ignora
problema25SegundaOpcion(["x", 10, "x", 2, "10", 10, true,true]);
//Problema 26
const problema26 = (arreglo=null)=>
{
    if (arreglo === null) return console.warn("No ingreso ningun arreglo");
    if (arreglo instanceof Array === false) return console.warn("Lo que usted ingreso no es un arreglo");
    for (const elementos of arreglo) {
        if(typeof(elementos)==="string")return console.error(`El elemento ingresado "${elementos}" no es un numero`)
        else "";
    }
    let resultado1=0,resultadoCompleto;
    arreglo.forEach(elemento => resultado1 = resultado1 + elemento);
    resultadoCompleto = resultado1/arreglo.length;
    return console.info(resultadoCompleto);
}
problema26([9,8,7,6,5,4,3,2,1]);
//Otra opcion para hacerlo
const problema26SegundaOpcion = (arreglo = null)=>
{
    if (arreglo === null) return console.warn("No ingreso ningun arreglo");
    if (arreglo instanceof Array === false) return console.warn("Lo que usted ingreso no es un arreglo");
    for (const elementos of arreglo) {
        if(typeof(elementos)==="string")return console.error(`El elemento ingresado "${elementos}" no es un numero`)
        else "";
    }

    return console.info(
        arreglo.reduce(
            (total,numero,index,arreglo)=>
            {
                total+=numero
                if (index === arreglo.length-1) {
                    return `promedio: ${total/arreglo.length}`
                }
                else{
                    return total;
                }
            }
        )
    )
}
//En esta segunda opcion se uso el metodo reduce el cual tiene 4 parametros
//El primero total este parametro inicializa a 0 y vuelve a 0 si no se retorna de nuevo a la funcion reduce
//numero son los elementos que contiene el arreglo dependiendo de la posicion
//index es el numero en el que se encuentra el arreglo 
//Y el arreglo es pasar directamente el arreglo que se esta reduciendo 
problema26SegundaOpcion([9,8,7,6,5,4,3,2,1]);

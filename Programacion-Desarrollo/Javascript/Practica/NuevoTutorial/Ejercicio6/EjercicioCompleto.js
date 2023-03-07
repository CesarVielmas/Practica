/*
18) Programa una función que dada una cadena de texto cuente el número de vocales y consonantes, pe. miFuncion("Hola Mundo") devuelva Vocales: 4, Consonantes: 5.
19) Programa una función que valide que un texto sea un nombre válido, pe. miFuncion("Jonathan MirCha") devolverá verdadero.
20) Programa una función que valide que un texto sea un email válido, pe. miFuncion("jonmircha@gmail.com") devolverá verdadero.
                         <  >
*/
//Problema 18
const problema18 = (texto = null)=>
{
    let consonantes=0,vocales=0;
    if (texto === null) return console.warn("No ingreso ningun texto");
    if (typeof(texto)!== "string") return console.error("No ingreso texto");
    
    texto.split("").forEach((elemento)=>
    {
        console.info(elemento);
        (elemento.includes("a") === true||elemento.includes("e") === true||elemento.includes("i") === true||elemento.includes("o") === true||elemento.includes("u") === true)
        ?vocales++
        :(elemento.includes(" ")===true)
        ?""
        :(elemento.includes("1")==true||elemento.includes("2")==true||elemento.includes("3")==true||elemento.includes("4")==true||elemento.includes("5")==true||elemento.includes("6")==true||elemento.includes("7")==true||elemento.includes("8")==true||elemento.includes("9")==true||elemento.includes("0")==true)
        ?""
        :consonantes++;
    })
    return console.info(`Numero de vocales fue de ${vocales} y numero de consonantes fue de ${consonantes}`);
}
problema18("Hola Mu32ndo ");
//Problema 19
const problema19 = (nombreEvaluar = null)=>
{
    if (nombreEvaluar === null) return console.warn("No ingreso ningun texto");
    if (typeof(nombreEvaluar) !== "string") return console.warn("Lo que ingreso no fue un texto");
    const expresionRegular1 = new RegExp("[0-9]","ig"),
    expresionRegular2 = new RegExp(" ","ig"),
    expresionRegular3 = new RegExp("[@,-,\,ª,#,~,!]","ig");

    return (expresionRegular1.test(nombreEvaluar)===true)
    ?console.info("El nombre evaluado no es valido ya que contiene numeros")
    :(expresionRegular2.test(nombreEvaluar)===false)
    ?console.info("El nombre evaluado no es valido pues no contiene ninguna separacion")
    :(expresionRegular3.test(nombreEvaluar)===true)
    ?console.info("El nombre evaluado no es valido pues contiene simbolos")
    :console.info("El nombre evaluado es valido");
}
problema19("Cesar Alejandro");
//Problema 20
const problema20 = (correoEvaluar = null)=>
{
    if (correoEvaluar === null) return console.warn("No ingreso ningun texto");
    if (typeof(correoEvaluar) !== "string") return console.warn("Lo que ingreso no fue un texto");
    const expresionRegular1 = new RegExp(" ","ig"),
    expresionRegular2 = new RegExp("@gmail|@hotmail","ig"),
    expresionRegular3 = new RegExp(".com","i");
    
    return(expresionRegular1.test(correoEvaluar)===true)
    ?console.info("Correo no valido ya que contiene espacios")
    :(expresionRegular2.test(correoEvaluar)===false)
    ?console.info("Correo invalido no contiene ningun arroba")
    :(expresionRegular3.test(correoEvaluar)===false)
    ?console.info("Correo invalido no contiene ningun dominio")
    :console.info("Correo Valido");
}
problema20("vielmassalais023@gmail.com");

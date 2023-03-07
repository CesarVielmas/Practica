/*
15) Programa una función para convertir números de base binaria a decimal y viceversa, pe. miFuncion(100,2) devolverá 4 base 10.
16) Programa una función que devuelva el monto final después de aplicar un descuento a una cantidad dada, pe. miFuncion(1000, 20) devolverá 800.
17) Programa una función que dada una fecha válida determine cuantos años han pasado hasta el día de hoy, pe. miFuncion(new Date(1984,4,23)) devolverá 35 años (en 2020).
                         <  >
*/
//Problema 15
const problema15 = (valor = null,base = null)=>
{
    let resultado = 0,contador = 0,valorEjemplo = 0,noDarBinario=true;
    if (valor === null) {
        return console.warn("Usted no dio ningun valor a evaluar");
    }
    if (base === null) {
        return console.warn("Usted no dio ninguna base");
    }
    if (typeof(valor)!=="number")  {
        return console.error("El valor a evaluar no es un numero");
    }
    if (typeof(base)!=="number") {
        return console.error("La base no es un numero");
    }
    if (base === 2) {
        valor.toString().split("").forEach((elemento)=>
        {
        if(elemento == 1 || elemento == 0)return "";
        else
        {
            noDarBinario = false
            return console.error("Usted dio un valor no en binario");

        } 
        })
    }
    if (base <2 || base >10 || (base>2 && base<10)) {
        return console.error("El programa solo acepta base binaria o decimal");
    }
    //Convertidor binario a decimal
    if (base === 2 && noDarBinario === true) {
        contador = valor.toString().length-1;
        valor.toString().split("").forEach((elementos)=>
        {
            resultado = resultado +(elementos * Math.pow(2,contador))
            contador--;
        })
        return console.info(resultado);
    }
    //Convertidor decimal a binario
    else if (base === 10) {
        const valorDecimal = [];
        let i = valor.toString().length + 10000000;
        valorEjemplo = valor;
        while (contador === 0) {
            if (valorEjemplo ===1) {
                valorDecimal[i]=1;
                contador = 1;
            }
            else if((valorEjemplo%2)===1)
            {
                valorDecimal[i]=1;
                i--;
                valorEjemplo = Math.floor(valorEjemplo/2);
            } 
            else if((valorEjemplo%2)===0)
            {
                valorDecimal[i]=0;
                i--;  
                valorEjemplo = Math.floor(valorEjemplo/2);
            }
        }
        return console.info(valorDecimal.join(""));
    }
}
problema15(10129,10);
//Problema 16
const problema16 = (monto = null,porcentaje = null)=>{
    let resultado,valorAQuitar;
    if (monto === null) return console.warn("Usted no ingreso un monto");
    if (porcentaje === null) return console.warn("Usted no dio ningun porcentaje"); 
    if (typeof(monto)!=="number")return console.warn("El monto debe ser un numero"); 
    if (typeof(porcentaje)!=="number")return console.warn("El porcentaje debe ser un numero"); 
    if (porcentaje>100||porcentaje<0)return console.warn("El porcentaje no puede ser negativo ni exceder el valor del monto");
    if (monto<0)return console.warn("El monto no puede ser negativo");
    valorAQuitar = (monto * porcentaje)/100;
    resultado = monto - valorAQuitar;
    return console.info(`El monto de ${monto} quitando el ${porcentaje}% daria como resultado = ${resultado}`); 
    //Sacando porcentaje
    
}
problema16(1000,20);
//Problema 17
const problema17 = (fecha = null)=>
{
    if (fecha === null)return console.warn("Usted no ingreso ninguna fecha");
    if (fecha instanceof Date ===false) return console.warn("Usted no dio una fecha de manera correcta");
    let fechaActualSeg = (Date.now() - fecha.getTime())/1000;
    fechaActualSeg = ((((fechaActualSeg / 60)/60)/24)/365);
    console.log(`Desde ${fecha.getFullYear()} a el año actual ${new Date().getFullYear()} han pasado ${Math.round(fechaActualSeg)} años`);
}
//Instanceof lo que hace es que evalua un objeto para ver a la instancia a la que pertenece
//Por ejemplo "fecha instanceof Date" este lo que hace es que toma el objeto fecha y pregunta si es de la instancia Date
//Si es de la instancia Date osease si es un objeto de tipo Date entonces mandara un true , si no es un objeto
//De tipo Date mandara un false
problema17(new Date(1986,21,5));
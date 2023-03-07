//Aqui se mostrara un ejemplo practico usando funciones para crear una calculadora con operaciones muy basicas

function opcion(opcion,valor1,valor2)
{
    var respuesta;
    do
    {
    if(opcion == "sumar")
    {
        sumar(valor1,valor2);
        respuesta = prompt("¿Desea volver a ejecutar?")
    }
    else if(opcion == "restas")
    {
        restar(valor1,valor2);
        respuesta = prompt("¿Desea volver a ejecutar?")
    }
    else if(opcion == "multiplicar")
    {
        multiplicar(valor1,valor2);
        respuesta = prompt("¿Desea volver a ejecutar?")
    }
    else if(opcion == "dividir")
    {
        dividir(valor1,valor2);
        respuesta = prompt("¿Desea volver a ejecutar?")
    }
    else
    {
        alert("Ingrese una opcion valida vuelva a intentarlo");
        respuesta = "si";
    }
    
    }while(respuesta =="si");
}
function sumar(numero1,numero2)
{
    alert("Resultado de la suma: "+(numero1+numero2));
}
function restar(numero1,numero2)
{
    alert("Resultado de la resta: "+(numero1-numero2));
}
function multiplicar(numero1,numero2)
{
    alert("Resultado de la multiplicacion: "+(numero1*numero2));
}
function dividir(numero1,numero2)
{
    alert("Resultado de la division: "+(numero1/numero2));
}
var opcionxd = prompt("Ingrese la opcion a realizar");
var valor1xd =parseInt( prompt("Ingrese el primer valor"));
var valor2xd =parseInt( prompt("Ingrese el segundo valor"));
opcion(opcionxd,valor1xd,valor2xd);
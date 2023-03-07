//Se vera primero lo que es los ifs y los else ,estos funcionan comunmente como en cualquier lenguaje de 
//Programacion ,tienen como objetivo darle inteligencia a la pagina o lo que se quiera crear es muy muy
//Util y uno de los pilares escenciales de la programacion
//Ejemplo se pedira al usuario que ingresa 2 valores y se compararan para decir si son del mismo tipo o no
//Para ello se utilizara un operador aritmetico nuevo en javascript el cual es "===" el cual significa 
//Estrictamente igual a y esto quiere decir que si es estrictamente el tipo de valor y que si tambien tiene
//Los mismos atributos entonces seguira el programa y el otro es "!==" estrictamente diferente de , el cual
//Significa que todo absolutamente todo es diferente , los valores ,el tipo, el parametro y si se cumple
//Seguira el programa mediante ahi
//Ejemplo
var valor1 = prompt("Bienvenido se tomaran 2 valores y se compararan si son estrictamente iguales o no ingrese el primer valor a comparar");
var valor2 = prompt("ingrese el segundo valor a comparar");
if(valor1 === valor2)
{
    document.write("<p><h1> el valor es estrictamente igual al que se comparo</h1></p>")
}
else
{
    document.write("<p><h1> el valor no es estrictamente igual al que se comparo</h1></p>")
}
var valor3=prompt("Ahora se comparara por consiguiente otros 2 valores para ver si son estrictamente diferentes deme el valor de la primera variable");
var valor4=prompt("Ahora el valor de la segunda variable");
if(valor3 !== valor4)
{
    document.write("<p><h1> el valor es estrictamente diferente al que se comparo</h1></p>")
}
else
{
    document.write("<p><h1> el valor no es estrictamente diferente al que se comparo</h1></p>")
}
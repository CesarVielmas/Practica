//Aqui se vera lo que es un else if , esta estructura de control de flojo lo que hace es que siempre va 
//En medio de entre un if y else , lo que hace es que si se cumple algun if else cerrara automaticamente todos
//Los if o else que sigan posteriormente
//Ejemplo
var color = prompt("Ingrese el color de la pagina que desea, Rojo/Cafe/Verde").toUpperCase();
//Sintaxis para convertir una variable a lowercase osease minusculas
color.toLowerCase();
//Sintaxis para convertir una variable a Upercase osease mayusculas
color.toUpperCase();
//Sintaxis para ver que tipo de valor retorna una variable
typeof(color);
//Sintaxis para convertir un string a un valor de tipo entero
//Ejemplo parseInt(color);
//Sintaxis para saber si es un numero 
//Ejemplo isNaN(color);
var cuerpo = document.getElementById("cuerpoxd");
if(color == "ROJO")
{
cuerpo.style.backgroundColor ="red";
}

else if(color == "CAFE")
{
cuerpo.style.backgroundColor = "brown";
}
else if(color == "VERDE")
{
    cuerpo.style.backgroundColor = "green";
}
else
{
alert("Elija una opcion valida")
}
//Para Imprimir en pantalla se usa una funcion que se llama prompt es util , es como la sentencia alert
//Pero esta te deja escribir para guardarla en las variables
//Ejemplo
var nombre,apellido,edad;
nombre = prompt("Ingrese su nombre");
apellido = prompt("Ingrese su apellido");
edad = prompt("Ingrese su edad");
//Algo bastante util en javascript es que con la sentencia document.write(); se puede escribir codigo html
//Asi mismo funcionando como si fuera html , aqui en el ejemplo se vera mas claro
document.write("<p>");
document.write("<h1>");
document.write("Hola "+nombre+" "+apellido+" usted tiene "+edad+" años");
document.write("</h1>")
document.write("</p>");
//Arrays
//Los arrays en javascript tambien conocidos como arreglos o matrices son bastante similares a otros lenguajes
//El funcionamiento es el mismo , pero lo que mas destaca en javascript es que a diferencia de varios otros
//Lenguajes en javascript se pueden poner valores enteros o boleanos o de cadena , dentro de un mismo array
//Algo que en otros lenguajes no se puede ya que necesita declarar el tipo de array y poner solo valores 
//Validos de ese tipo de array declarado
//Ejemplo
//Una forma de declarar un array vacio
var array1 = new Array();
//Otra forma de declarar un array vacio
var array2 = [];
//Una forma de declarar un array
var array3 = ["Segundo Valor del array 3",20,true,"Juan","Antepenultimo valor del array 3"];
//Otra forma de declarar un array
var array4 = new Array("Pepito",18,true,"Magdalena");
//Algunas funciones importantes o metodos importantes para los arrays
//Obtener el valor de el largo de un array
alert("El array 3 tiene: "+array3.length+" valores");
//Poniendole un valor nuevo al final del array
array3.push("Valor Nuevo Agregado Al Array 3 Al Final De Este");
//Poniendole un valor nuevo al principio del array
array3.unshift("Valor nuevo agregado al principio de el array 3");
document.write("<p>");
document.write("Primer valor del array 3: <br/><h1>"+array3[0]+"</h1>");
document.write("</p>");
document.write("<p>");
//Se usa length y se le resta 1 para que de el ultimo valor posible del array 3
document.write("Ultimo valor del array 3: <br/><h1>"+array3[(array3.length)-1]+"</h1>");
document.write("</p>");
//Eliminar un valor de el array
//Eliminando el ultimo valor del array
array3.pop();
//Eliminando el primer valor del array
array3.shift();
document.write("<p>");
document.write("Primer valor del array 3: <br/><h1>"+array3[0]+"</h1>");
document.write("</p>");
document.write("<p>");
//Se usa length y se le resta 1 para que de el ultimo valor posible del array 3
document.write("Ultimo valor del array 3: <br/><h1>"+array3[(array3.length)-1]+"</h1>");
document.write("</p>");
//Tambien se pueden agregar valores al array puestos por el usuario ejemplo
//Se agrega un elemento al principio del array
array3.unshift(prompt("Ingrese el primer elemento del array 3"));
//Se agrega un elemento al final del array
array3.push(prompt("Ingrese el ultimo elemento del array 3"));
//Imprimirlo en el html
document.write("<p>");
document.write("El primer elemento del array 3 agregado: "+array3[0]);
document.write("<br/>"+"El ultimo elemento del array 3 agregado: "+array3[array3.length-1]);
document.write("</p>");

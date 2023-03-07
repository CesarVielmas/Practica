//Ahora lo que se veran son las funciones , las funciones funcionan muy similar a como funcionan en los demas
//Lenguajes , las funciones , en una breve explicacion son aquellas que nos ayudan a ahorrar codigo pues
//Repiten el codigo que se encuentran almacenadas dentro de estas y que necesitan ser llamadas para que
//Se ejecute , aqui se vera un ejemplo mejor a diferencia de otros lenguajes , como en javascript
//Ejemplo
//Una funcion vacia tambien llamados metodos
function ObtenerFecha()
 {
     //Se le da a una variable un objeto de tipo fecha , que ya viene implicito en la super clase cosmica
     //Del lenguaje
     var fecha = new Date()
     //Aqui se usa una funcion de la clase fecha la cual es to date string la cual acorta 
     //A poner solo una pequeña parte de el dia de hoy
    document.write("<p><h1>El dia de hoy es:"+fecha.toDateString()+"</h1></p>");
 }
 //Llamamos a la funcion para que nos entregue lo que tiene dentro
 ObtenerFecha();
 //Tambien ahora lo que se vera son las funciones con parametros o metodos que requieren parametros es lo mismo
 //Que una funcion pero esta misma necesita de parametros para que funcione los cuales se los da el usuario
 //O el programador
 //Ejemplo
 //Funcion que requiere del parametro nombre para funcionar
function Saludar(nombre)
{
    //Imprime su nombre
    document.write("<p><h3>Hola bienvenido "+nombre+"</h3></p>");
}
//Ingresa el nombre el usuario
var nombrexd = prompt("Ingrese su nombre");
//Llamamos a la funcion y le pasamos el parametro ingresado al usuario
Saludar(nombrexd); 
//Nota , no se puede hacer sobrecarga de funciones en javascript

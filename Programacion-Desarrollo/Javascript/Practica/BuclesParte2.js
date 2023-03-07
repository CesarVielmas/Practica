//Ahora veremos el bucle for y es un bucle determinado ya que le asignas cuantas veces se va a ejecutar
//No como los indeterminados como while y do while que hasta podrian ser infinitos ya que no se sabe
//cuantas veces se va a correr
//Ejemplo de un for el cual mostrara el arreglo que genere el usuario
var arrayxd = new Array();
var contador = 0;
var ContenidoArray;
while(ContenidoArray != "salir")
{
    ContenidoArray = prompt("Ingrese Los valores del array o ingrese (salir) para salir","Valores");
    arrayxd[contador] = ContenidoArray;
    contador++;

}
arrayxd.pop();
for(var i = 0; i<arrayxd.length; i++)
{
    document.write("<p>Valor de array: "+arrayxd[i]+"</p>")
}

//Aqui se vera lo que es el bucle while el cual no cambia tanto en comparacion a otros lenguajes de programacion
//El bucle while tiene su zona de parametros donde si se cumple iniciara el bucle y hasta que la condicion
//De los parametros de el bucle sea falsa parara el programa casi igual que en otros lenguajes de programacion
//Ejemplo
//Ingresando parametros a un arreglo con el bucle while y mostrandolos con otro bucle while
var cantidad = prompt("Cuantas variables quiere que tenga el arreglo");
cantidad =Number(cantidad);
var arregloxd = new Array(cantidad);
var contador =0;
while(contador<= (arregloxd.length)-1)
{
    arregloxd[contador] = prompt("Ingrese el valor "+contador+" de su array");
    contador++;
}
contador = 0;
    document.write("<h1>Su arreglo fue el siguiente</h1> <br/>")
while(contador < arregloxd.length)
{
    document.write("<h2>"+arregloxd[contador]+"</h2> <br/>")
    contador++;
} 
//Usando Do while el do while es exactamente casi igual que while pero no necesita entrar al bucle para que
//Al menos se ejecute una vez
//Ejemplo
var numeroAleatorio,numeroAcertador
//Math.round() esta funcion del objeto math lo que hace es redondear un numero con decimales
//Math.random() esta funcion lo que hace es que crea un numero aleatorio entre 0 y 1 , usando decimales
//Y como se puede ver como dara un decimal , se multiplicara por 100 para que de un numero entero
//Y luego se redondea para que sea un numero entero completamiento sin decimales
numeroAleatorio = Math.round(Math.random()*100);
do
{
    numeroAcertador = prompt("Ingrese el numero que cree que sea del 0 al 100");
    if(numeroAcertador<numeroAleatorio)
    {
        alert("El numero es mas alto");
    }
    if(numeroAcertador>numeroAleatorio)
    {
        alert("El numero es mas bajo")
    }

}while(numeroAcertador!=numeroAleatorio);
alert("Correcto");

//Ahora aqui se vera lo que es Poo o programacion orientada a objetos , el cual es lo mismo que en cualquier
//Otro lenguaje de programacion ya que funciona igual , que cada objeto tiene sus propiedades y comportamientos
//Ejemplo donde se vera como toma el objeto boton creado en el html y modificara sus propiedades , de altura
//Y de ancho de este objeto boton
//Creacion de la variable para tomar el boton y guardar el objeto en la variable
var mibotoncito = document.getElementById("boton1");
//Modificando sus propiedades
//Obteniendo el ancho mediante una ventana ingresado por el usuario
var anchoBoton = prompt("De el ancho del boton");
//Obteniendo el largo mediante una ventana ingresado por el usuario
var LargoBoton = prompt("De ahora el largo del boton");
//Ancho agregando el "px para que lo convierta a pixeles"
mibotoncito.style.width=anchoBoton+"px";
//Largo agreando el "px" para que lo convierta a pixeles
mibotoncito.style.height=LargoBoton+"px";
//En javascript como cualquier otro lenguaje hay una cantidad enorme de metodos y propiedades para cada objeto
//En este caso cada objeto de html
//Ejemplo de algunos
//Propiedades del cuadro de texto
var cuadrotexto = document.getElementById("texto1");
//Obtener color del cuadro de texto
var colortexto = prompt("Ingrese el color del campo de texto en codigo de color");
//Color se le agrego el "#" pues asi debe empezar el codigo de colores
cuadrotexto.style.background ="#"+colortexto;
//Focus del cuadro de texto metodo
//Lo que hace focus es seleccionar desde el inicio este cuadro de texto o lo que sea 
cuadrotexto.focus();
$(document).ready(function()
{
 //Lo que se vera es AddClass(); tambien  ToggleClass(); y RemoveClass();
 //Empezando primero por AddClass(); Esta funcion exclusiva de JQuery , lo que hace es añadir una clase
 //A alguna parte de html la cual sea llamadada mediante su id o su clase puede ser de varias maneras
 //Esto mismo hace que el añadir una clase haga que se pueda ejecutar codigo CSS Mas que todo se usa
 //Para eso y que tome un formato distinto , aunque podria ser para varias cosas
 //Ahora RemoveClass(); es exactamente casi lo mismo que addClas(); pero este lo que hace es eliminar
 //Si es que hay una clase , la cual se le pasa los parametros para eliminarla
 //Ahora ToggleClass(); este lo que hace es que funciona como addClass(); y como removeClass();
 //Ya que es un sistema On/Off si detecta que se pico una vez se va a true y si no se va a false
 //Y cuando esta en true se pone el atributo y si es false se remueve el atributo
 //Ejemplo
 //Aqui se guarda un array de botones , los cuales contienen su id, ya que lso toma del html creado
 var botones = document.querySelectorAll("button");
 document.getElementById("checkboxxd").addEventListener("click",checkbox,false);
 //Aqui se hace un ciclo for para cada boton creado 
 for(var i =0;i<botones.length;i++)
 {
     //Aqui algo interesante cuando se tienen varios objetos de botones por ejemplo aqui y se uso for
     //Lo que hace aqui es añadirle un evento a cada boton ya que manda a llamar a todos los botones
     //Tambien se le asigna que debe ser dando click y , se le asigna un metodo el cual retorna
     //Un valor de tipo evento , el cual toma y es necesario para la funcion
     //Esto lo toma implicitamente y no se ocupa ponerlo en los parametros de el metodo o funcion
     //Al añadir el evento
 botones[i].addEventListener("click",Botonesxd,false);
 }
});
//Creacion de funcion para evento
function Botonesxd(numero)
{
    //Se utiliza la etiqueta target para obtener su id y se compara con el nombre del id
    //Si es igual a Boton1 se sigue por consiguiente
 if(numero.target == Boton1)
 {
     //Aqui se usa el addClass(); para añadir la clase cambiar color y que tome las propiedades
     //Al presionar el botoon asi mismo haciendo que cambie de color
 $("#h1").addClass("ClaseCambiarColor");
 //Aqui se eliminarn las clases cambiar color si es que las tienen los h2 y h3 para que solo salga
 //H1 con ese atributo y que solo cambie de color este mismo 
 $("#h2").removeClass("ClaseCambiarColor");
 $("#h3").removeClass("ClaseCambiarColor");
 }
 //Lo demas es lo mismo que lo anterior solo que se usa else if
 else if(numero.target == Boton2)
 {
 $("#h2").addClass("ClaseCambiarColor");
 $("#h1").removeClass("ClaseCambiarColor");
 $("#h3").removeClass("ClaseCambiarColor");
 }
 else if(numero.target == Boton3)
 {
 $("#h3").addClass("ClaseCambiarColor");
 $("#h2").removeClass("ClaseCambiarColor");
 $("#h1").removeClass("ClaseCambiarColor");
 }
}
//Creacion de el metodo para el checkbox
function checkbox()
{
    //Uso del toggle class
 $("#h2").toggleClass("ClaseCambiarColor");
 $("#h1").toggleClass("ClaseCambiarColor");
 $("#h3").toggleClass("ClaseCambiarColor");
}
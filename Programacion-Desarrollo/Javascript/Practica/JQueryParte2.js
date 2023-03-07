//Inicializacion de JQuery
$(document).ready(function(){
    //Ahora lo que se vera son las diferentes etiquetas de agregacion de texto en JQuery el cual 
    //Ayudan mucho y facilitan el trabajo para diferentes funciones importantes 
    //Funcion html(); Esta lo que hace es que remplaza todo el texto html de una etiqueta para cambiar
    //De un titulo a un parrafo o etc
    //Ejemplo
    $(".Campo1").html("<h1>html</h1>");
    //Funcion append(); lo que hace es que sirve para agregar codigo html una linea abajo del que ya
    //Se tiene en el programa
    //Ejemplo
    $(".Campo2").append("<h2>append</h2>");
    //Funcion text(); sirve mucho ya que con el modifica el texto mas no puede modificar las estructuras
    //Html ni agregar estructuras html
    //Ejemplo
    $(".Campo3 p").text("text");
    //Funcion prepend(); casi lo mismo que append solo que agrega la estructura html arriba y no abajo
    //Del texto ya definido
    $(".Campo4").prepend("<strong>prepend</strong>");
    //Funcion after(); esta funcion lo que hace es que se puede añadir una estructura html
    //Pero despues de la etiqueta o id o clase , no dentro ni fuera si no despues
    $(".Campo5").after("<u>after</u>");
    //Funcion before(); es casi lo mismo que after solo que en vez de añadirlo despues , lo hace antes
    //De la estructura html del id o clase
    $(".Campo6").before("<h3>before</h3>");
});
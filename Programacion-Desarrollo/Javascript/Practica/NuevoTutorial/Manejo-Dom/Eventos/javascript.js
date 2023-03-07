//Ahora lo que se vera seran los 3 tipos de manejadores de eventos en javascript con html , esto es muy importante para poder desarrollar varias acciones para el usuario y asi mismo que sea interactivo

//Forma 1 de hacer eventos , la cual es mediante html , se pone el atributo en el html del evento y dentro de javascript tomara dicha funcion y la usara , la cual no es muy recomendable usar esta forma , es bastante mejor las siguientes
const funcion1 = evento =>{
    window.alert("Esta es la funcion 1");
    console.log(evento)
},
funcion2 = evento =>{
    window.alert("Esta es la funcion 2");
    console.log(evento);
},
funcion3 = evento =>{
    window.alert("Esta es la funcion 3");
    console.log(evento);
};

//Forma 2 de hacer eventos, esta forma si es recomendable , pero lo malo que tiene esta forma es que solo puede usar 1 funcion y un evento , no puede reproducir multiples eventos pero igual es recomendable para un solo evento

//Para hacer eventos de un solo evento se debe tomar a la etiqueta mediante su id o clase pero es muy recomendable id , sin usar el querySelector , ya que ese es para multiples eventos
const $boton2 = document.getElementById("boton2");
//Despues se usa el metodo del evento en cuestion y se iguala la funcion que hara al usar dicho evento , es importante no usar parentesis en el evento ya que si se usa parentesis , al ingresar a la pagina se activaria automaticamente sin usarlo
$boton2.onclick = funcion2;
//Ya que solo acepta un evento en cuestion hara cascada y ignorara los eventos anteriores
$boton2.onclick = evento =>
{
    window.alert("Remplazo de funcion 2");
}

//Forma 3 de hacer eventos , esta forma si es recomendable y es usada para añadir 1 o mas eventos , ya que se activara primero un evento y luego otro

//Para hacer que los eventos sean multiples se debe buscar la etiqueta con querySelector 
const $boton3 = document.querySelector("#boton3");
//Despues se desbloqueara el metodo addEventListener el cual lo que hace es añadir eventos , en este caso todos los eventos que pueda tomar como primer parametro y como segundo parametro la funcion que hara al ejecutar dicho evento
$boton3.addEventListener("click",funcion2);
$boton3.addEventListener("click",funcion3);
//Y como se puede ver acepta y hace varias funciones en los eventos por ello es multiple


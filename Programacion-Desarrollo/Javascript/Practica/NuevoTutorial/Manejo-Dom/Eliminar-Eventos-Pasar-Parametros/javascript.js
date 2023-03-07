//Ahora lo que se vera sera el como eliminar eventos , exclusivo para los addEventListener y el como pasar parametros entre eventos lo cual es bastante importante para desarrollar diferentes eventos

//Funciones a usar
const eventoPasarParametro = (nombre ="Sin nombre")=>{
    console.log(nombre);
    window.alert(`Hola ${nombre} como estas`);
},
eventoEliminarEvento = (e) =>{
    //eliminacion del evento
    window.alert("Se eliminara el evento del boton 3");
    //Funcion para eliminar dicho evento
    $boton3.removeEventListener("click",eventoEliminarEvento);
    window.alert("Evento eliminado")
},//Botones del html para eventos
$boton1 = document.getElementById("boton1"),
$boton2 = document.getElementById("boton2"),
$boton3 = document.querySelector("#boton3");

//Lo primero sera el como pasar parametros en los eventos , por su propia cuenta no es posible pasar parametros si se usa la propia funcion como evento pero sin embargo cuando se usa una funcion anonima o una arrow function , se puede poner dicha funcion dentra de esa funcion anonima y asi mismo pasar parametros

//Ejemplo de paso de parametros mal hecho
$boton1.onclick = eventoPasarParametro;

//Ejemplo de paso de parametros bien hecho
$boton2.onclick = (e)=>{
    eventoPasarParametro();
    eventoPasarParametro("Cesar");
};

//Ahora por ultimo , esta la eliminacion de eventos , esto es sencillo y se hace con la funcion removeEventListener el cual contiene en sus parametros el nombre del evento a eliminar y como segundo parametro la funcion del evento en cuestion para asi mismo eliminarlo

//Ejemplo eliminacion de evento
$boton3.addEventListener("click",eventoEliminarEvento);
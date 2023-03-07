$(document).ready(function(){
    //Ahora lo que se vera es la funcion bind() la cual es demasiado util y una de las mejores funciones de JQuery
    //Esta misma sirve para poner uno o mas eventos a la vez ademas de que se puede pasar el parametro especifico de objeto para alguna funcion
    //Esto en la segunda restriccion aunque se puede poner o no y ya por ultimo la funcion a la cual llamara al hacer el evento
    //Esta funcion puede ser anonima o no anonima
    //Aqui un ejemplo
    //Primero se toma el attr de el src de la imagen osease obtener el link de la iamgen y guardarlo en una variable
    var valorSRC = $("#ImagenConSRC").attr("src");
    //Despues se hace el bind para hacer un evento doble donde si se clickea o se pone el mouse por encima activara el evento
    //De esta misma manera se le da como segundo parametro el valor del cual se le dara a la funcion que es llamada osease se le da el objeto
    //A la funcion llamada y ya por ultimo parametro la funcion llamada que puede ser anonima
    $("#ImagenConSRC").bind("click mouseover",valorSRC,mostrarImagen);
}); 
//Funcion llamada con parametro del objeto dado por bind
function mostrarImagen(e)
{
    //Funcion de el objeto e para que no se propague , osease que solo tendra 1 solo evento el objeto de la imagen en este caso
    //Si se le da otro evento el cual incluya esta imagen otra vez no servira pues detiene la propagacion
    e.stopPropagation();
    //Aqui se le da el codigo html con replaceWith el cual le da el src guardado en la variable valorSRC que en este caso es e
    //Y se usa la funcion e.data para obtener sus respectivos datos
    $("#ImagenSinSRC").replaceWith("<img src ='"+e.data+"' width='400px' height='450px'/>");
}
//Aqui se le asigna a todo el dcumento una funcion de click que al hacer click se crea un src vacio y una alerta de hola
//Si se clickea a imagenConSRC no funcionara ya que tiene el stopPropagation el cual detiene esto y solo se le puede dar un evento
//El cual ya fue dado por ello es muy importante esa funcion
$(document).click(function(){
    $("#ImagenSinSRC").replaceWith("<img src ='' width='400px' height='450px'/>");
    alert("hola");
})
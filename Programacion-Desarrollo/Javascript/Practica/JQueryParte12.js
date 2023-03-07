$(document).ready(function(){
    //Ahora lo que se vera es animate(),esta funcion es demasiado util como su nombre lo dice para animar modificando el codigo css
    //Que pueda tener , asi mismo creando animaciones , durante mas conocimiento en css mas complejas las animaciones y mejores animadas
    //Pueden quedar
    //Ejemplo
    //Primero se crea un evento de dar click a la imagen
    $("#Carroxdd").click(function(){
        //Ahora dentro de la funcion anonima se hace el animate el cual cambia codigo css o de estilo de la imagen
        //Ya que con this selecciona la imagen en la que esta y le da una opacidad de 1 con un delay de 1 segundo
        //O 1000 milisegundos para que aparezca la animacion
    $(this).animate(
        {
        opacity:1
        }
    ,1000);

});

});
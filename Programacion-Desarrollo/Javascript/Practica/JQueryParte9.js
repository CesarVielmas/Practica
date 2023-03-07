$(document).ready(function(){
    //Ahora lo que se vera es la funcion next la cual es bastante util para apuntar a un elemento en especifico que se encuentre en un contenedor
    //Para poder modificarlo o hacer lo que se requiera de este mismo
    //Ejemplo
    $("#Respuesta Button").hide();
    //En teoria se tienen ambas imagenes en el hover lo cual hace con funciones anonimas que tome la primera imagen y que despues en el next
    //Se muestre el boton de respuesta y como hay 2 ids llamados respuestas por eso se usa next porque apunta unicamente a el boton de
    //Respuesta de la primera imagen y igual al esconderla hace lo mismo
    $("#Contenedor img").hover(function(){
        $(this).next("#Respuesta Button").show()
    }
        ,function(){
            $(this).next("#Respuesta Button").hide()
        });
    });
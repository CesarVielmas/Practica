 //Ahora lo que se vera es los eventos en JQuery y lo que es hover y toggle 
        //A diferencia de los eventos de javascript puro sin librerias , donde se tenia que obtener el id o el selector
        //En JQuery se puede hacer de manera mas sencilla ahorrando pasos como se vera a continuacion
        //Por otro lado se vera hover y toggle lo cual hace aun mas sencillo el agregar eventos y hacer interactivo una pagina
        //Hover lo que hacer es que incluye el evento de mouseover y para cuando se quita el mouse 2 cosas en 1 
        //Bastante util para ahorrar codigo ademas de hacer mas simple la pagina interactiva
        //Ahora toggle este mismo hace igual que hover 2 cosas a la vez pero al dar click , bastante similar a hover 
        //Ejemplo de sus funciones

        $(document).ready(function(){
            //Se ocultan las imagenes
            $("img").hide();
            //Funcion hover el cual incluye los eventos de el mouseover donde se puede ver con unas funciones anonimas
            $("#Aparecer").hover(function(){$("#Aparecerxdd").show() },function(){$("#Aparecerxdd").hide() });
            //Funcion toggle el cual incluye los eventos click donde se puede ver con funciones anonimas
            $("#Aparecer2").toggle(function(){$("#Aparecerxd").show() },function(){$("#Aparecerxd").hide() });
            //Ejemplo de evento en JQuery
            $("html").dblclick(function(){alert("evento ejemplo JQuery") });
        });
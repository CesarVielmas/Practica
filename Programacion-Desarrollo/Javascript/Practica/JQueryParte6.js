//Ahora lo que se vera sera las funciones especiales de JQuery llamadas attr y RemoveAttr
        //Empezando por attr lo cual tiene como funcion añadir atributos a alguna etiqueta html
        //En cambio RemoveAttr como su nombre lo dice lo que hace es remover estos atributos attr
        //Ejemplo
        $(document).ready(function()
        {
            //Obteniendo el elemento mediante el id y añadiendole el evento
            document.getElementById("dimashxdd").addEventListener("mouseover",mouseDentro,false);
            document.getElementById("dimashxdd").addEventListener("mouseout",mouseFuera,false);
        });
        //Funcion para el evento
        function mouseDentro()
        {
            //Ejemplo de attr el cual lo que hace es añadir dentro de la etiqueta src el atributo de otra imagen tambien tomando como otro parametro el false
            $("img").attr("src","https://dimashkudaibergenticonews.files.wordpress.com/2020/03/dimash-kudajbergen-800x480-1.jpg",false);
        }
        function mouseFuera()
        {
            //Ejemplo usando el removeAttr que como su nombre lo dice remueve el attr
            $("img").removeAttr("src");
        }
 //Ahora lo que se vera es el metodo css(); de JQuery este mismo ayuda mucho a la hora de cambiar o 
        //obtener algun valor de CSS es muy util ,  aqui se vera un breve ejemplo
        var tamañoTexto
        $(document).ready(function()
        {
            //Tomando y guardando en la variable tamañoTexto el tamaño
            tamañoTexto =parseInt( $(".tamano").css("font-size"));
            //creando un evento en el boton
            document.getElementById("Aumentar").addEventListener("click",AumentarTa,false);
        });
        //Funcion cambiando el codigo CSS
        function AumentarTa()
        {
            $(".tamano").css("font-size",tamañoTexto * 1.02);
        }
 //Ahora lo que se vera es como utilizar la funcion each y para que sirve ademas tambien de ver lo que son
        //Las funciones anonimas en javascript que asi como en otros lenguajes es casi igual 
        //Empezando por each este mismo sirve para guardar o contener varios datos de alguna manera como un bucle
        //Por su traduccion al español "cada" tiene como objetivo tomar cada elemento si son varios y hacer a cada
        //Uno por separado la instruccion que se le asigne , despues de hacer la tarea , hace que todos los elementos
        //Guardados se muestren en pantalla a la vez si es un efecto en el navegador si no ahi termina
        //Ahora las funciones anonimas estas mismas como en otros lenguajes son funciones sin nombres y en su
        //Mayoria sin parametros aunque algunas si los tienen , estas sirven para un hecho en especifico y que 
        //Se usara solo para eso 
        //Ejemplo usando ambas
        //Funcion anonima la cual usa ready
        $(document).ready(function(){
            //Se toma para el boton llamado difuminar
            document.getElementById("sinEach").addEventListener("click",desaparecer,false);
            //Se toma para el boton llamado con each
            document.getElementById("ConEach").addEventListener("click",conEach,false);
        });
        //Funcion para el boton llamado difuminar
        function desaparecer()
        {
            //Lo unico que se hace aqui es tomar todas las etiquetas img y se les da fadeout y fadein lo cual es entrada y salida junto
            //Con tamaño mas reducido
            $("img").fadeOut(10000).fadeIn(10000).width(100).height(100);
        }
        //Funcion para el boton llamado con each
        function conEach()
        {
            //Aqui lo que se hace primero es tomar las etiquetas img pero exclusivamente las que tengan en el alt el https:// , eso se le indica
            //Despues se usa la funcion each la cual contiene una funcion anonima de la cual hace funcionar el each
            $("img[alt^='https://']").each(function(){
                //Aqui se guardan los links de las imagenes con el attr y se le indica this ya que se va de una por una con each
                var GuardarLinks = $(this).attr("alt");
                //Aqui se le agrega con la funcion llamada append el codigo html el cual contiene los links ya que fue guardado en guardarlinks
                $("p").append("<li> <u>"+GuardarLinks+"</u></li>");
            });
        }
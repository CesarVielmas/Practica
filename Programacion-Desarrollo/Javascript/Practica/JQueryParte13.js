$(document).ready(function(){
 //Lo que se vera ahora es el reload , que es el reload , bueno el reload es como su nombre lo dice el volver a cargar una cosa 
            //Ya que al estaar haciendo una pagina web en lo que es el desarrollo al momento cuando se sube a un servidor para que cargue
            //En alguna otra computadora es muy diferente ya que al cargarla varia la conexion a internet o algun otro valor que pueda influir 
            //Para que cargue dicha pagina por ello es mejor usar un reload a dichas cosas de la pagina para no sufrir por eso 
            //Ejemplo sencillo del reload de una imagen
            //Se crea una variable de tipo objeto Image ya que es necesito para que guarde el src de esta misma
            var srcImagen = new Image();
            //Guarda en el src del objeto srcImagen el src de la respectiva imagen
            srcImagen.src = $("#Imagenxd").attr("src");
            //Le coloca el src de la variable para que asi mismo no falle al cargarla
            $("#Imagenxd").attr("src",srcImagen.src);
        });
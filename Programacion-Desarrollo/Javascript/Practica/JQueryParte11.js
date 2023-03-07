//Ahora lo que se vera son los diferentes efectos que hay , ya se vieron algunos como show , hide, toggle, fadein,fadeout, pero aun faltan mas 
        //Se veran fadeToggle,slideDown,slideout y slideToggle
        //Ejemplo usandolos
        $(document).ready(function(){
            //UsandofadeToggle el cual hace el fadeIn y el fadeOut con sus clicks
            $("#fadeToggle").click(function(){
                $("#imagen1").fadeToggle(4000)
            });
            //Usando SlideDown este lo que hace es esconder una imagen haciendola hacia abajo
            $("#SlideDown").click(function(){
                $("#imagen2").slideDown(4000)
            });
            //Usando SlideUp este lo que hace hace es esconder una imagen pero ahora haciendola hacia arriba
            $("#SlideUp").click(function(){
                $("#imagen3").slideUp(4000)
            });
            //Usando SlideToggle este hace el SlideDown y el SlideUp con sus clicks
            $("#SlideToggle").click(function(){
                $("#imagen4").slideToggle(4000)
            });
        });

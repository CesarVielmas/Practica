 //Ahora lo que se vera son las ventanas emergentes , las cuales son aquellas que se habren por ejemplo en publicidad y entre otras
        //Estas mismas no son muy utiles porque los navegadores lo bloquean pero podrian servir , se usa una sola funcion la cual es
        //open
        //Ejemplo
        $(document).ready(function(){
            //Ciclo largo de ventanas 
            //Que al final solo habre una
            var Tamaños = "width = 200, height = 500";//Se le asigna el tamaño a las ventanas
            var i = 0;//Valor i para el while

            while(i<10)
            {
                var nombre = 12;//variable para el nombre
                nombre++;

                open("https://www.facebook.com",toString(nombre),Tamaños);//Funcion open la cual hace las ventanas emergentes en este caso hacia facebooks.com
                i++;
            }
        });
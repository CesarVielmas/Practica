 //Comienzo del JQuery
 $(document).ready(function()
 {
     //Se toma el id primero de el baner por cerrar y luego se hace una cadena de funciones
     //Donde se añade un evento , que si le da click se ejecutara el metodo CerrarImagen
     var valorxd = document.getElementById("Cerrar").addEventListener("click",CerrarImagen,false);
     //Lo mismo pero ahora cambia el id porque toma las imagenes y toma un metodo diferente el
     //Evento
     var valordimash1 = document.getElementById("Dimash1").addEventListener("click",RemplazarImagen1,false);
     var valordimash2 = document.getElementById("Dimash2").addEventListener("click",RemplazarImagen2,false);
     var valordimash3 = document.getElementById("Dimash3").addEventListener("click",RemplazarImagen3,false);
     var valordimash4 = document.getElementById("Dimash4").addEventListener("click",RemplazarImagen4,false);
 });
 //Creando la funcion para el evento
 function CerrarImagen()
 {
     //Aqui se hace el uso de remove(); el cual como su nombre lo dice remueve un objeto del html
     $("#Cerrar2").remove();
     $("#Cerrar").remove();
 }
 function RemplazarImagen1()
 {
     //Aqui se hace el uso de replaceWitch(); el cual lo que hace es que remplaza el objeto 
     //Y se le da parametros en html para remplazar por la imagen
     $("#Dimash1").replaceWith(" <h1>Acaba de seleccionar a dimash</h1>")
 }
 //Lo mismo con como la anterior funcion solo que para cada imagen
 function RemplazarImagen2()
 {
     $("#Dimash2").replaceWith(" <h1>Acaba de seleccionar a dimash</h1>")
 }
 function RemplazarImagen3()
 {
     $("#Dimash3").replaceWith(" <h1>Acaba de seleccionar a dimash</h1>")
 }
 function RemplazarImagen4()
 {
     $("#Dimash4").replaceWith(" <h1>Acaba de seleccionar a dimash</h1>")
 }
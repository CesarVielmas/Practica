//Ahora lo que se vera seran algunas propiedades y eventos del BOM 
//empezando por el BOM es el browser object model el cual es el navegador a resumidas cuentas  mientras que el DOM era el document object model , el BOM se basa en la experiencia del navegador en el que se encuentre y no sencillamente el documento

//Algunas propiedades y eventos del BOM
//Evento que se activa cuando se hace un scroll en la pantalla , por ello se usa window
window.addEventListener("scroll",(e)=>{
    console.log(window.scrollX);//Propiedad para ver el scroll de X
    console.log(window.scrollY);//Propiedad para ver el scroll de Y
})
//Evento que se activa cuando todo lo de la pagina se carga
window.addEventListener("load",(e)=>{
    window.alert("Se cargo correctamente la pagina");
})
//Evento que se activa cuando se modifca el tamaño de la pantalla
window.addEventListener("resize",()=>{
    console.log(window.screenX);//Propiedad que da el tamaño de la pantalla en X
    console.log(window.screenY);//Propiedad que da el tamaño de la pantalla en Y
})
//Es importante decir que tambien el evento load de el BOM puede cambiarse por el siguiente
document.addEventListener("DOMContentLoaded",(e)=>{
    window.alert("Se cargo la pagina correctamente con DOMContentLoaded");
})
//El DOMContentLoaded lo que hace a diferencia del load es que cuando se carga la pagina sin sus elementos , ya sea imagenes , estilos etc etc , se activara , por ello es muchisimo mas rapido que load , por ello load tiene su funcion cuando se carguen absolutamente todos los elementos del documento incluyendo imagenes estilos etc esa es la gran diferencia
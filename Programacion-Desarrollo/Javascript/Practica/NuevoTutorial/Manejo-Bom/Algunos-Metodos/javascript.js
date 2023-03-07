//Ahora lo que se vera seran algunos metodos de el BOM , ya fueron vistos prompt , alert y confirm pero ahora tocan unos 3 mas para poder observar su funcionamiento y utilidad

//declaracion de los botones html
const $boton1 = document.querySelector(".boton1"),
$boton2 = document.querySelector(".boton2"),
$boton3 = document.querySelector(".boton3");
let pagina;
//Primer evento la cual contiene el nuevo metodo de window o del BOM "print()"
$boton3.addEventListener("click",(e)=>{
    window.print();//Este metodo sirve para imprimir dicha pagina en cuestion
})
//Segundo evento el cual contiene el nuevo metodo de window o del BOM "open()"
$boton1.addEventListener("click",()=>{
    pagina = window.open("https://www.youtube.com");//Este metodo lo que hace es abrir dicha pagina en otra ventana
})
//Tercer evento el cual contiene el nuevo metodo de window o del BOM "close()"
$boton2.addEventListener("click",()=>{
    pagina.close();//Este metodo lo que hace es cerrar la ventana en este casi de la variable
})

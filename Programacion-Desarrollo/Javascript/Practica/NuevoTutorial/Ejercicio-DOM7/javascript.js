const d = document,w = window,recargarPantalla = (tamanoPantalla)=>{
    if (tamanoPantalla>750) {
        d.querySelectorAll("a").forEach((elemento)=>{
            elemento.classList.replace("oculto","visible")
        })
        d.querySelectorAll("iframe").forEach((elemento)=>{
            elemento.classList.replace("visible","oculto")
        })
    }
    else{
        d.querySelectorAll("a").forEach((elemento)=>{
            elemento.classList.replace("visible","oculto")
        })
        d.querySelectorAll("iframe").forEach((elemento)=>{
            elemento.classList.replace("oculto","visible")
        })
    }
};
let tamanoPantalla;
w.addEventListener("resize",()=>{
    tamanoPantalla = w.screenX;
    recargarPantalla(tamanoPantalla);
    
})
d.addEventListener("DOMContentLoaded",()=>{
    tamanoPantalla = w.screenX;
    recargarPantalla(tamanoPantalla);
})
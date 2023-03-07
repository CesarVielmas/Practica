const $boton = document.querySelector(".boton"),$logo = document.querySelector("#Logo"),$menuDesplegable = document.querySelector(".menuDesplegable"),$secciones = document.querySelectorAll(".seccion"),
evento1 = ()=>
{ 
$logo.textContent = "close"
$menuDesplegable.classList.replace("Esconder","Transicion");
if ($logo.textContent == "close") {
    
    $boton.removeEventListener("click",evento1);
    $boton.addEventListener("click",evento2);
}
},
evento2 = ()=>
{ 
$logo.textContent = "menu"
$menuDesplegable.classList.replace("Transicion","Esconder");
if ($logo.textContent == "menu") {
    
    $boton.removeEventListener("click",evento2);
    $boton.addEventListener("click",evento1);
}
};
//Principio
$boton.addEventListener("click",evento1);

$secciones.forEach((elemento)=>{
    elemento.addEventListener("click",()=>{
        $boton.removeEventListener("click",evento2);
        $logo.textContent = "menu"
        $menuDesplegable.classList.replace("Transicion","Esconder");
        $boton.addEventListener("click",evento1);
    })
})



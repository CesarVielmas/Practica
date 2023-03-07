const $bloque = document.querySelector(".contenido");

window.addEventListener("offline",()=>{
    $bloque.textContent = "Desconectado";
    if ($bloque.classList.contains("desconectado")) {
        
    }
    else{
    $bloque.classList.replace("conectado","desconectado");
    }
    $bloque.classList.replace("invisible","visible");
    setTimeout(()=>{
        $bloque.classList.replace("visible","invisible");
    },1000)
})
window.addEventListener("online",()=>{
    $bloque.textContent = "Conectado";
    if ($bloque.classList.contains("conectado")) {
        
    }
    else{
    $bloque.classList.replace("desconectado","conectado");
    }
    $bloque.classList.replace("invisible","visible");
    setTimeout(()=>{
        $bloque.classList.replace("visible","invisible");
    },1000)
})
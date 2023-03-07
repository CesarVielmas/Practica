const $bloqueContenido = document.querySelector(".contenido"),
$contenido = document.querySelectorAll(".contenido_tarjetas"),
$input = document.querySelector(".palabras"),
funcionTeclas = ()=>{
    teclas = "";
        $input.addEventListener("keydown",funcionIngresarTeclas)
        
},
funcionIngresarTeclas = (e)=>{
        if (e.key === "Backspace") {
            teclas = teclas.slice(0,teclas.length-1);
            
        }
        else teclas +=e.key;
        
        $contenido.forEach((elemento)=>{
            if (elemento.textContent.includes(`${teclas}`)) {
                if (elemento.classList.contains("invisible")) {
                    elemento.classList.replace("invisible","visible");
                }
            }
            else
            {
                if (elemento.classList.contains("visible")) {
                    elemento.classList.replace("visible","invisible");
                }
    
            }
        })
        console.log(teclas);
    };
let teclas="";

document.addEventListener("click",(e)=>{
    
    if (e.target.classList.value === $input.classList.value) {
        funcionTeclas();
    }
    else $input.removeEventListener("keyup",funcionIngresarTeclas);
})
const $contenido = document.querySelectorAll(".contenido_obtenible li"),
arrayElementos = [];
let numeroAleatorio;
document.addEventListener("click",(e)=>{
    if (e.target.classList.value === "boton") {
        numeroAleatorio = Math.round(Math.random()*100)
        while(numeroAleatorio>$contenido.length+1)
        {
            numeroAleatorio =  Math.round(Math.random()*100);
        }
        
        alert(`Ganador: ${$contenido.item(numeroAleatorio).textContent}\nNumero: ${numeroAleatorio}`);
    }
})
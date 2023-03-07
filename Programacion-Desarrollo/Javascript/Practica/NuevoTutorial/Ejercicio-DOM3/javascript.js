//Variables
let ancho=0,alto=0;
//Funciones
const atajos = (e)=>{
           console.log(e.key);
    if (e.altKey) {
        if (e.key === "a") {
            alert("Activo una alerta");
        }
        if (e.key === "p") {
            prompt("Ingrese los datos");
        }
        if (e.key === "c") {
            confirm("Confirme porfavor");
        }
    }
},
moverCirculo = (e)=>{
    console.log("Se entro al evento");
    console.log(e.key);
    if (e.key === "ArrowRight") {
        ancho+=3
    }
    if (e.key === "ArrowLeft") {
        ancho-=3
    }
    if (e.key === "ArrowUp") {
        alto-=3
    }
    if (e.key === "ArrowDown") {
        alto+=3
    }
    document.querySelector(".bloque_objeto").setAttribute("style",`top:${alto}px; left:${ancho}px; `);
};
//Eventos en el DOM
document.body.addEventListener("click",(e)=>{
    console.log(e.target.classList.value);
    if (e.target.classList.value === "TeclasEspeciales") 
    {
        document.body.addEventListener("keyup",atajos);
        
    }
    if (e.target.classList.value ==="bloque") {
        console.log("Evento Circulo");
        document.body.addEventListener("keydown",moverCirculo);
    }
})
const $tiempo = document.querySelector(".tiempo"),
$contenido = document.createElement("h3");

const fechaManana = new Date("02/02/2023");

 $contenido.classList.add("contador");
const intervalo = setInterval(()=>{
    //Contador
    let fechaActual = new Date(), 
    fechaActualMilSeg = fechaActual.getTime(),
    tiempoFaltante = fechaManana.getTime() - fechaActualMilSeg,
    diasFaltantes = Math.floor(tiempoFaltante/(1000*60*60*24)),
    horasFaltantes = Math.floor(tiempoFaltante %(1000*60*60*24)/(1000*60*60)),
    minutosFaltantes = Math.floor(tiempoFaltante%(1000*60*60)/(1000*60)),
    segundosFaltantes = Math.floor(tiempoFaltante %(1000*60)/(1000));

    $contenido.textContent = `Falta ${horasFaltantes} Horas con ${minutosFaltantes} minutos y ${segundosFaltantes} segundos`;
    $tiempo.after($contenido)
    if (fechaActualMilSeg <0) {
        clearInterval(intervalo);
        $contenido.textContent = `Ya es mañana`;
        $tiempo.after($contenido);
    }
},1000)

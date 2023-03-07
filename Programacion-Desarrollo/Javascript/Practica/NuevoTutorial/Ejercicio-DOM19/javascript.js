let decir = new window.SpeechSynthesisUtterance(),
voces;
const $selector = document.getElementById("rango"),
intervaloCarga = setInterval(()=>{
    if (window.speechSynthesis.getVoices().length === 0) console.log("Segundos");
    else{
        voces = window.speechSynthesis.getVoices();
        console.log(voces)
        voces.forEach((elementos)=>{
            const $opciones = document.createElement("option");
            $opciones.value = elementos.name;
            $opciones.text = elementos.name;
            $opciones.classList.add("opciones");
            $selector.appendChild($opciones);
        })
        clearInterval(intervaloCarga)
    }
},1000)

document.addEventListener("change",(e)=>{
    if (e.target === $selector) {
        decir.voice = voces.find(voz => voz.name === e.target.value);
    }
})
document.addEventListener("click",(e)=>{
    console.log($selector.value);
    if (e.target.classList.value === "boton") {
       const textoGuardado = document.getElementById("textoDecir").value;
        decir.text = textoGuardado;
        window.speechSynthesis.speak(decir);
    }
   
    
})

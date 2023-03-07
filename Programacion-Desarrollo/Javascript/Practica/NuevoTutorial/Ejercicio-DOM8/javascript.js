let posicion,altura,ancho,$arrayResultado,feature,ventana
const $formulario = document.getElementById("formularioVerdadero");

document.addEventListener("submit",(e)=>{
    if (e.target === $formulario) {
        e.preventDefault();//Para que no envie datos la pagina
            let feature = `height=${$formulario.altura.value},width=${$formulario.ancho.value}`
            ventana = window.open("https://youtube.com","_blank",feature);
    }
});
document.addEventListener("click",(e)=>{
    if (e.target === $formulario.botonCerrar) {
    e.preventDefault();
    ventana.close();
    }
})
/*
$arrayResultado = window.location.href.split("?").pop().split("&")
    $arrayResultado.forEach((elemento)=>{
        if (elemento.includes("=") && elemento.includes("ancho")) {
            posicion = elemento.indexOf("=");
            ancho = Number(elemento.slice(posicion+1));
    
        }
        else if (elemento.includes("=") && elemento.includes("altura")) {
            posicion = elemento.indexOf("=");
            altura = Number(elemento.slice(posicion+1));
            
        }
    })*/ 

 




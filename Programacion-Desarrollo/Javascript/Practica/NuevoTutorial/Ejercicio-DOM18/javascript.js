const $inputs = document.querySelectorAll(".formulario input"),
$boton = document.querySelector(".formulario button"),
$noValidoNombre = document.createElement("p"),
$noValidoCorreo = document.createElement("p"),
$noValidoComentario = document.createElement("p"),
nombreRestriccion = new RegExp("^[a-z ,.'-]+$","i"),
correoRestriccion = new RegExp("[a-z0-9]+@[a-z]+\.[a-z]{2,3}","i");
eventoDocumento = evento =>
$inputs.forEach( elementos=>
(evento.target === elementos)
?document.addEventListener("keyup",(e)=>{

    if (elementos.id === "nombre") {
        if (nombreRestriccion.test(elementos.value)) {
            elementos.setAttribute("style","border: thin solid rgb(0, 83, 0);");
            $noValidoNombre.classList.remove("textoNoValido");
            $noValidoNombre.textContent = "";
            elementos.after($noValidoNombre);
        }
        else{
            elementos.setAttribute("style","border: thin solid rgb(170, 0, 0);");
            $noValidoNombre.classList.add("textoNoValido");
            $noValidoNombre.textContent = `Nombre no valido`;
            elementos.after($noValidoNombre);
        }
    }

    else if (elementos.id === "correo") {

        if (correoRestriccion.test(elementos.value)) {
            elementos.setAttribute("style","border: thin solid rgb(0, 83, 0);");
            $noValidoCorreo.classList.remove("textoNoValido");
            $noValidoCorreo.textContent = "";
            elementos.after($noValidoCorreo);
        }
        else{
            elementos.setAttribute("style","border: thin solid rgb(170, 0, 0);");
            $noValidoCorreo.classList.add("textoNoValido");
            $noValidoCorreo.textContent = `Correo no valido`;
            elementos.after($noValidoCorreo);
        }
    }

    else if (elementos.id === "comentarios") {
        if (elementos.value.length<300) {
            elementos.setAttribute("style","border: thin solid rgb(0, 83, 0);");
            $noValidoComentario.classList.remove("textoNoValido");
            $noValidoComentario.textContent = "";
            elementos.after($noValidoComentario);
        }
        else
        {
            elementos.setAttribute("style","border: thin solid rgb(170, 0, 0);");
            $noValidoComentario.classList.add("textoNoValido");
            $noValidoComentario.textContent = `El comentario no debe exceder 300 palabras`;
            elementos.after($noValidoComentario);
        }
    }

    if ($noValidoComentario.textContent===""&& $noValidoCorreo.textContent==="" && $noValidoNombre.textContent==="") {
        $boton.classList.add("validadoBoton");
    }
    else{
        $boton.classList.remove("validadoBoton");
    }
})
:"");
$noValidoComentario.textContent = "a";
$noValidoCorreo.textContent = "a";
$noValidoNombre.textContent = "a";
document.addEventListener("click",eventoDocumento);
let variable = 0,intervalo,botones;
const $boton1 = document.querySelector(".boton1"),$boton2 = document.querySelector(".boton2"),$boton3 = document.querySelector(".boton3"),$boton4 = document.querySelector(".boton4"),$contenidoNuevo = document.createElement("h3"),$resultado = document.querySelector(".resultado"),
funcion1 = ()=>{
    variable = 0;
    intervalo = setInterval(()=>{
    tiempo = new Date();
    if (variable === 0) {
        $contenidoNuevo.innerText = tiempo.toLocaleTimeString();
        $contenidoNuevo.classList.add("textoCreado");
        $resultado.after($contenidoNuevo);
    }
    },1000)
    document.querySelector(".boton1").setAttribute("disabled","true");
    document.querySelector(".boton1").classList.add("desactivado");
},
funcion2 = ()=>
{
        
            document.querySelector(".boton1").setAttribute("disabled","");
            document.querySelector(".boton1").classList.remove("desactivado");
            variable =1;
            $contenidoNuevo.innerText = "";
            $resultado.after($contenidoNuevo);
            
},
funcion3 = ()=>
{
    document.querySelector(".audio").play();
},
funcion4 = ()=>
{
    document.querySelector(".audio").setAttribute("src","");
}
$boton1.addEventListener("click",funcion1);
$boton2.addEventListener("click",funcion2);
$boton3.addEventListener("click",funcion3);
$boton4.addEventListener("click",funcion4);


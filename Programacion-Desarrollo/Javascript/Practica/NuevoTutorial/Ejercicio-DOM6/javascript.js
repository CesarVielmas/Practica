//Variables
let $variableFondo = getComputedStyle(document.body).getPropertyValue("--colorFondo"),
contador =0,variableStorage;
document.addEventListener("click",(e)=>{
    console.log(e.target.classList.value);
    if (e.target.classList.value === "botonCambio") {
        contador++;
        if (contador %2 >0) {
            document.querySelector(".botonCambio span").textContent = "brightness_5";
            $variableFondo = "black";
            localStorage.setItem("fondo",$variableFondo)
            console.log(localStorage.getItem("fondo"));
            document.body.setAttribute("style",`background-color:${variableStorage};`);
            
            document.body.style.setProperty("background-color",$variableFondo);    
        }
        else if (contador %2 === 0) {
            document.querySelector(".botonCambio span").textContent = "dark_mode";
            $variableFondo = "white";
            localStorage.setItem("fondo",$variableFondo);
            console.log(localStorage.getItem("fondo"));
            document.body.style.setProperty("background-color",$variableFondo);
        }
        
    }
    
})
document.body.setAttribute("style",`background-color:${localStorage.getItem("fondo")};`);
if (localStorage.getItem("fondo")==="white") {
    document.querySelector(".botonCambio span").textContent = "dark_mode";
    contador = 0;
}
else if (localStorage.getItem("fondo")==="black") {
    document.querySelector(".botonCambio span").textContent = "brightness_5";
    contador = 1;
}
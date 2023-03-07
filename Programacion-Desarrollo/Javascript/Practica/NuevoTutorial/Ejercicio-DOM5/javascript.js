//Variables
const $documento = document,
mandarTop = ()=>{
    scrollTo(0,0);
};
$documento.addEventListener("scroll",(e)=>{
    console.log(window.scrollY);
    if (window.scrollY>300) {
        console.log("Entro visible");
        $documento.querySelector(".botonScroll").classList.replace("invisible","visible");
        $documento.querySelector(".botonScroll").addEventListener("click",mandarTop);
    }

    if (window.scrollY<300) {
        console.log("Entro invisible")
        $documento.querySelector(".botonScroll").classList.replace("visible","invisible");
        $documento.querySelector(".botonScroll").removeEventListener("click",mandarTop);
    }
})
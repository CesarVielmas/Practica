let options = {
    threshold: 1.0
  };

const $boton = document.querySelector(".boton"),$logo = document.querySelector("#Logo"),$menuDesplegable = document.querySelector(".menuDesplegable"),$secciones = document.querySelectorAll(".seccion"),
$menuDesplegable2 = document.createElement("div"),
$seccion1 = document.querySelector(".seccion_mirar1"),
$seccion2 = document.querySelector(".seccion_mirar2"),
$seccion3 = document.querySelector(".seccion_mirar3"),
$seccion4 = document.querySelector(".seccion_mirar4"),
evento1 = ()=>
{ 
$logo.textContent = "close"
$menuDesplegable.classList.replace("Esconder","Transicion");
if ($logo.textContent == "close") {
    
    $boton.removeEventListener("click",evento1);
    $boton.addEventListener("click",evento2);
}
},
evento2 = ()=>
{ 
$logo.textContent = "menu"
$menuDesplegable.classList.replace("Transicion","Esconder");
if ($logo.textContent == "menu") {
    
    $boton.removeEventListener("click",evento2);
    $boton.addEventListener("click",evento1);
}
};
//Principio
$boton.addEventListener("click",evento1);

$secciones.forEach((elemento)=>{
    elemento.addEventListener("click",()=>{
        $boton.removeEventListener("click",evento2);
        $logo.textContent = "menu"
        $menuDesplegable.classList.replace("Transicion","Esconder");
        $boton.addEventListener("click",evento1);
    })
})
//cuando se esta en pc
window.addEventListener("resize",(e)=>{
    console.log(window.screenX);
    //Modo Mobil
    if (window.screenX>600) {
        if ($boton.classList.contains("Visible")) {
            
        }
        else 
        {
        $boton.classList.replace("Esconder","Visible");
        document.querySelector(".apartado").removeChild($menuDesplegable2);
        console.log("Entro modo mobil");
        };

    }
    //Modo PC
    if (window.screenX<600) {
        if ($boton.classList.contains("Esconder")) {
            
        }
        else 
        {
        console.log("Entro modo desktop");
        $boton.classList.replace("Visible","Esconder");
        $menuDesplegable2.classList.add("menuDesplegable2");
        $menuDesplegable2.innerHTML = ` 
        <a href="#seccion1" class="seccionVista1 visto" >Seccion 1</a>
        <a href="#seccion2" class="seccionVista2">Seccion 2</a>
        <a href="#seccion3" class="seccionVista3">Seccion 3</a>
        <a href="#seccion4" class="seccionVista4">Seccion 4</a>
        `
        document.querySelector(".apartado").insertAdjacentElement("afterbegin",$menuDesplegable2) 
         };

        
    }
})

if (window.screenX>600) {
    if ($boton.classList.contains("Visible")) {
        
    }
    else 
    {
    $boton.classList.replace("Esconder","Visible");
    document.querySelector(".apartado").removeChild($menuDesplegable2);
    console.log("Entro modo mobil");
    };

}
//Modo PC
if (window.screenX<600) {
    if ($boton.classList.contains("Esconder")) {
        
    }
    else 
    {
    console.log("Entro modo desktop");
    $boton.classList.replace("Visible","Esconder");
    $menuDesplegable2.classList.add("menuDesplegable2");
    $menuDesplegable2.innerHTML = ` 
    <a href="#seccion1" class="seccionVista1 visto" >Seccion 1</a>
    <a href="#seccion2" class="seccionVista2">Seccion 2</a>
    <a href="#seccion3" class="seccionVista3">Seccion 3</a>
    <a href="#seccion4" class="seccionVista4">Seccion 4</a>
    `
    document.querySelector(".apartado").insertAdjacentElement("afterbegin",$menuDesplegable2) 
     };

     let seccion1=false,seccion2=false,seccion3=false,seccion4=false,observer1 = new IntersectionObserver((e)=>{
        console.log("entro seccion 1");
        seccion1 = true;
        seccion2 = false;
        seccion3 = false;
        seccion4 = false;    
    }, options),
    observer2 = new IntersectionObserver((e)=>{
        console.log("entro seccion 2");
        seccion2 = true;
        seccion1 = false;
        seccion3 = false;
        seccion4 = false;
    }, options),
    observer3 = new IntersectionObserver((e)=>{
        console.log("entro seccion 3");
        seccion3 = true;
        seccion2 = false;
        seccion1 = false;
        seccion4 = false;
    }, options),
    observer4 = new IntersectionObserver((e)=>{
        console.log("entro seccion 4");
        seccion4 = true;
        seccion1 = false;
        seccion2 = false;
        seccion3 = false;
    }, options);
    document.addEventListener("scroll",()=>{
        observer1.observe($seccion1);
        observer2.observe($seccion2);
        observer3.observe($seccion3);
        observer4.observe($seccion4);

        if (seccion1===true) {
            document.querySelector(".seccionVista1").classList.add("visto");

            if (document.querySelector(".seccionVista2").classList.contains("visto")) {
            document.querySelector(".seccionVista2").classList.remove("visto");
                
            }
            if (document.querySelector(".seccionVista3").classList.contains("visto")) {
                document.querySelector(".seccionVista3").classList.remove("visto");
                    
            }
            if (document.querySelector(".seccionVista4").classList.contains("visto")) {
                document.querySelector(".seccionVista4").classList.remove("visto");
                        
            }
           
        }
        else if (seccion2===true) {
            document.querySelector(".seccionVista2").classList.add("visto");

            if (document.querySelector(".seccionVista1").classList.contains("visto")) {
            document.querySelector(".seccionVista1").classList.remove("visto");
                
            }
            if (document.querySelector(".seccionVista3").classList.contains("visto")) {
                document.querySelector(".seccionVista3").classList.remove("visto");
                    
            }
            if (document.querySelector(".seccionVista4").classList.contains("visto")) {
                document.querySelector(".seccionVista4").classList.remove("visto");
                        
            }
        }
        else if (seccion3===true) {
            document.querySelector(".seccionVista3").classList.add("visto");

            if (document.querySelector(".seccionVista1").classList.contains("visto")) {
            document.querySelector(".seccionVista1").classList.remove("visto");
                
            }
            if (document.querySelector(".seccionVista2").classList.contains("visto")) {
                document.querySelector(".seccionVista2").classList.remove("visto");
                    
            }
            if (document.querySelector(".seccionVista4").classList.contains("visto")) {
                document.querySelector(".seccionVista4").classList.remove("visto");
                        
            }
        }
        else if (seccion4===true) {
            document.querySelector(".seccionVista4").classList.add("visto");

            if (document.querySelector(".seccionVista1").classList.contains("visto")) {
            document.querySelector(".seccionVista1").classList.remove("visto");
                
            }
            if (document.querySelector(".seccionVista2").classList.contains("visto")) {
                document.querySelector(".seccionVista2").classList.remove("visto");
                    
            }
            if (document.querySelector(".seccionVista3").classList.contains("visto")) {
                document.querySelector(".seccionVista3").classList.remove("visto");
                        
            }
        }
    })
    
    
}

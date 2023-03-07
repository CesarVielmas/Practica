const $carrusel = document.querySelector(".carrusel"),
$imagenFondo = document.createElement("img");
let contador = 0;
document.addEventListener("click",(e)=>
{
    if (e.target.classList.value.includes("botonAtras")) {
        if (contador <=4 && contador > 0) {
            contador-=1;
            
        }
        else{

        }
        console.log(contador);

        if (contador === 0) {
            $carrusel.removeChild($imagenFondo);
        }
        if (contador === 1) {
            $imagenFondo.src = "https://i.ytimg.com/vi/L7PML9UcKwE/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLDdQe9A8CSwL1cj79DumbcrXyQ3AA";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
        if (contador === 2) {
            $imagenFondo.src = "https://i.ytimg.com/vi/h2JwWGYblVs/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLAA-03WZWU95jJ7BfeVeCBFe572ig";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
        if (contador === 3) {
            $imagenFondo.src = "https://i.ytimg.com/vi/8bGA0y40_38/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLDjevB5yO71MuaSLU33__AQiNbQMg";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
        if (contador === 4) {
            $imagenFondo.src = "https://i.ytimg.com/vi/m9M9YeLDnfI/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLBlln8iOSX7EXCK9s6z7ujFY0gjAQ";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
    }
    if (e.target.classList.value.includes("botonAdelante")) {
       if (contador <4) {
            contador+=1;
            
        }
        else{
            
        }
        console.log(contador);
        if (contador === 0) {
            $carrusel.removeChild($imagenFondo);
        }
        if (contador === 1) {
            $imagenFondo.src = "https://i.ytimg.com/vi/L7PML9UcKwE/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLDdQe9A8CSwL1cj79DumbcrXyQ3AA";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
        if (contador === 2) {
            $imagenFondo.src = "https://i.ytimg.com/vi/h2JwWGYblVs/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLAA-03WZWU95jJ7BfeVeCBFe572ig";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
        if (contador === 3) {
            $imagenFondo.src = "https://i.ytimg.com/vi/8bGA0y40_38/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLDjevB5yO71MuaSLU33__AQiNbQMg";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
        if (contador === 4) {
            $imagenFondo.src = "https://i.ytimg.com/vi/m9M9YeLDnfI/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLBlln8iOSX7EXCK9s6z7ujFY0gjAQ";
            if ($imagenFondo.classList.contains("imagen")) $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
            else {
                $imagenFondo.classList.add("imagen"); 
                $carrusel.insertAdjacentElement("afterbegin",$imagenFondo);
                 }
        }
    }
})
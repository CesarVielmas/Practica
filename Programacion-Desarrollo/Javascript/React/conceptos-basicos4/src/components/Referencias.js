//Importacion de React con destructuracion para usar las referencias
import React,{createElement, createRef,useRef} from 'react';

//Las referencias en react es una mejor manera de tomar elementos del DOM , en vez de buscarlos por el id o la clase se pueden usar las referencias para poder obtener dicho elemento y no buscarlos y asignarlos a un elemento del DOM dentro de el evento

//Para esto se hicieron especialmente primero para los componentes de clase , pero posteriormente se hicieron los hooks y estos mismos implementaron las referencias en los componentes de funciones , por lo cual se usaran las referencias de componentes de funciones usando los hooks , para ver informacion de como usar las referencias en los componentes de clases visitar https://es.reactjs.org/docs/refs-and-the-dom.html#gatsby-focus-wrapper

//Creacion del componente de funcion 
export function Referencias(){
    //Asignando una referencia 
    let refMenu = useRef(),
    refNav = useRef();
    //Evento para el click
    const handlerClick = (e) =>{
        
        //Es importante decir que la refencia guarda el objeto o el elemento del DOM en el objeto current por ello para obtenerlo se necesita tambien llamarlo
        if (refMenu.current.textContent === "Desplegar") {
            refMenu.current.textContent = "Contraer";
            refNav.current.classList.replace("navegacion1","navegacion");
        }
        else{
            refMenu.current.textContent = "Desplegar";
            refNav.current.classList.replace("navegacion","navegacion1");
        }
    }
    //Return
    return(
        <>
        <h1>usando referencias</h1>
        {
            //Para que la referencia detecte el elemento del dom al que va a referenciar es importante poner el nobre de la variable de referencia dentro de "ref" en el elemento qe tomara para referenciar
        }
        <button ref={refMenu} onClick={handlerClick}>Desplegar</button>
        <nav ref={refNav} className="navegacion1">
            <a>Seccion 1</a>
            <br/>
            <a>Seccion 2</a>
            <br/>
            <a>Seccion 3</a>
            <br/>
            <a>Seccion 4</a>
        </nav>
        </>
    )
}
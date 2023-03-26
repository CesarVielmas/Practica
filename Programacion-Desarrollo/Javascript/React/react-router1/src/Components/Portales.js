//Ahora lo que se vera seran los portales, los portales sirven mas que todo para imprimir en algun lugar de el documento html el codigo JSX como se puede ver en el index.js, el cual tiene un portal donde indica donde se pondra el codigo JSX que se haga en App.js , y en el index.html busca ese dicho div con el id para hacer el portal 

//Importacion de ReactDom para hacer el portal
import { ReactDOM } from 'react';

//Obteniendo el id del div donde se pondra todo el codigo JSX

export const Portales = () =>{
    /* Portal
    return ReactDOM.createPortal(
        <h1>Hola soy un portal</h1>,
        document.getElementById("portal")
        );
        */
       return (
        <h1>Hola soy un portal</h1>
       )
}
    

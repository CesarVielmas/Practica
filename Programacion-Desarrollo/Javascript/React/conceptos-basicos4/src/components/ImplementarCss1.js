//Importacion de React
import React from 'react';
//Ahora lo que se vera es como implementar el css o el diseño en React , para ello se veran estas diferentes opciones
//Primera opcion mediante una hoja de estilos dentro de la carpeta
import './ImplementarCss1.css';
//Tercera opcion mediante modulos , estos modulos lo que hace es que guardan las variables css dependiendo de la clase y se pueden implementar llamandolas dandoles de className la clase que se le quiere implementar de ese modulo
import estilosModulos from './ImplementarCss1.module.css';
//Cuarta opcion , mediante SCSS , esta opcion , no se mostrara del todo pues necesito ver un curso de Super CSS o SCSS para saber usarlo , pero cuando sepa , se debe de descargar SCSS desde React para que lo implemente o lo resista , para ello buscar en internet con node como implementar SCSS al proyecto lo cual es super facil
export function ImplementarCss1(){
    //Quinta opcion guardando los datos que modificara para los estilos de linea
    const estiloFondo = {
        backgroundColor: "red"
    }
    return(
        <>
        <h1 className='texto'>Implementar Css En React (con una hoja de estilos)</h1>
        {
            //Segunda opcion , con estilos de 1 sola linea
        }
        <h2 style={{border:"2px solid black",color:"white"}}>Con estilo de linea</h2>

        <h3 className={estilosModulos.fondoRojo}>Con estilos de modulos</h3>

        <h4 style={estiloFondo}>Con estilos dentro de una variable</h4>
        </>

    )
}
import React from 'react';
import './Ventana.css'
//Algo importante en este ejercicio es que children no fue instanciado por ningun valor , si no automaticamente  children es lo que lleva dentro de el componente ejemplo <p>hola</p> en este caso "hola" seria lo que va dentro del componente <p> por lo cual children tomaria el valor de hola o todo lo que vaya dentro
export const Ventana = ({children,handlerClick,cambio}) =>{

    return(
        <>
            {
            cambio
            ?
            <div className='abierta'>
            <button className='Cerrar' onClick={handlerClick} id="ventana">X</button>
            {children} 
            </div>
            :
            <div>
            {children} 
            </div>
            }
           
        </>
    )
}
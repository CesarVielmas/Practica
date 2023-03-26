import React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { restar, sumar } from './actions/explicacionAction';

export const ExplicacionContador = () =>{
    const selector = useSelector(state=>state);
    //En el selector estaran todos los states que contenga el store de redux que a su vez obtiene de el reducer de redux
    console.log(selector);
    const dispatch = useDispatch();
    //En dispatch es donde se pondran las funciones que fueron puestas en los actions correspondientes que estas mismas actions como mandan el type , entonces ejecutara el reducer correspondiente y asi mismo este modificara al reducer principal su propiedad de state
    console.log(dispatch);
    return(
        <>
        <h1>Contador Explicativo Redux</h1>
        {
            //Como selector guarda todos los state entonces que traiga contador el cual fue ya asignado con su reducer correspondiente
        }
        <h2>Contador:{selector.contador}</h2>
        {
            //Ahora con dispatch el cual recibe una funcion para pasarle el action al reducer , se le pasara las funciones que fueron hechas en actions , las cuales pasan el type pero pueden pasar el payloader tambien etc
        }
        <button onClick={()=>dispatch(sumar())}>Sumar</button>
        <button onClick={()=>dispatch(restar())}>Restar</button>
        </>
    )
}
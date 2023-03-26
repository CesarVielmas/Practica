import React, { useState } from 'react';
import RenderContadorSinMemo  from './RenderContador1';
import RenderContadorConMemo  from './RenderContador2';
//Se vera con un contador como funciona a grandes razgos la memorizacion
export const Contador = () =>{
    const[contador,setContador] = useState(0);

    const handlerSumar = () => setContador(contador +1);
    const handlerRestar = () => setContador(contador -1);
    return(
        <>
        <h1>Contador Para Ver Funcionamiento De La Memorizacion</h1>
        <p>{contador}</p>
        <button onClick={handlerSumar}>Sumar</button>
        <button onClick={handlerRestar}>Restar</button>
         {
            //Como se puede apreciar renderContadorConMemo no se renderiza mas de 1 vez pues lo resguarda y usa memo , sin embargo sin memo si lo renderiza muchas veces o cada que la variable de estado del padre en este caso contador cambia
         }
        <RenderContadorConMemo/>
        <RenderContadorSinMemo/>
        </>
    )
}
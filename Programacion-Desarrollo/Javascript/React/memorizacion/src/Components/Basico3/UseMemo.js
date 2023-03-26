import React, { useState } from 'react';
import Calculo from './Calculo';
//Ejemplo usando contador otra vez para hacer la renderizacion a proposito
export const Memo = () =>{
    const[contador,setContador] = useState(0);

    const handlerSumar = () => setContador(contador +1);
    const handlerRestar = () => setContador(contador -1);
    return(
        <>
        <h1>Contador Para Ver Funcionamiento De El useMemo</h1>
        <p>{contador}</p>
        <button onClick={handlerSumar}>Sumar</button>
        <button onClick={handlerRestar}>Restar</button>
        <Calculo/>
        </>
    )
}
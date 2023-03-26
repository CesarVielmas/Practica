import React,{memo} from 'react';

export const HijoBack = ({sumar,restar,contador}) =>{
    console.log("Renderizacion de BackHijo");
    return(
        <>
        <h2>Hijo</h2>
        <p>{contador}</p>
        <button onClick={sumar}>Sumar</button>
        <button onClick={restar}>Restar</button>
        </>
    )
}

export default memo(HijoBack);
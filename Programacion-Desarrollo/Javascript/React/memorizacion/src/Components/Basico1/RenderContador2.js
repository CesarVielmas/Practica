import React,{memo} from 'react';
//La memo lo que hace es que guarda o resguarda un componente , lo cual hace que no se renderice mas de 1 vez por factores como la variable de estado de su componente padre sin embargo para que se vuelva a renderizar un componente con memo necesita o cambiar u variable de estado o cambiar alguna prop que obtenga de su componente padre

export const RenderContadorConMemo = () =>{

    console.log("Renderiacion de el render contador con la memorizacion");
    return(
        <>
        
        </>
    )
}

export default memo(RenderContadorConMemo);
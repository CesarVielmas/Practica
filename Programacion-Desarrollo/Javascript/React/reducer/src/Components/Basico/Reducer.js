import React, { useReducer } from 'react'
//Ahora lo que se vera sera como funciona reducer y como este remplaza al useState en situaciones mas complejas

//Por lo general o casi siempre el estado debe de ser 1 objeto donde guardara cada uno de los valores de estado que se podrian modifiar a corde el programa
const estado = {
    contador:0
}
//El reductor es una funcion la cual recibe 2 parametros ,el primero es el estado y el segundo el tipo de accion que realizara , en todo caso el estado ya esta definido sin embargo el tipo aun no esta definido y este se define con dispatch para pasarle el tipo de accion que realizara
const reductor = (estado,tipo) => {
    //Dentro del reducer o rductor debe de ir todo aquello que retornara al valor del state de el objeto en el que se encuentra para que el state tome valores nuevos y asi renderizar respectivamente y actualizar dichos valores del state
    //Por lo general se usa switch y case para hacer este tipo de acciones
    //Cabe aclarar que tipo toma 2 objetos los cuales son type (El cual lo que hace es que se le delcara que tipo de accion realizara con el switch case) y la otra es el payload el cual es un valor que se le da mediante una funcion para que se pueda usar dentro del state y asignar dicho valor
    console.log(estado,tipo);
    switch (tipo.type) {
        case "Sumar":
            //Se quito el break pues el return debe de llevarlo y asi mismo el break no tendria sentido
        return {contador:estado.contador +1}
        
        case "Restar":
            //Se quito el break pues el return debe de llevarlo y asi mismo el break no tendria sentido
        return {contador:estado.contador -1}
    
        default:
        return estado;
            
    }
}

export default function Reducer() {
    //El use reducer es muy similar a el state solo que en sus parametros pide la funcion reductora como primer parametro ,luego pide los valores de inicio del estado , la funcion reductora es osease lo que hara y por ultimo otro valor opcional el cual se indagara en otro momento
    const [state, dispatch] = useReducer(reductor,estado);

    const handlerSumar = ()=>dispatch({type:"Sumar"});
    const handlerRestar = ()=>dispatch({type:"Restar"});
    
  return (
    <div>
        <h1>Reducer con contador</h1>
        <h2>Contador:{state.contador}</h2>
        <button onClick={handlerSumar}>Sumar</button>
        <button onClick={handlerRestar}>Restar</button>

    </div>
  )
}
//Y asi a grandes razgos seria reducer
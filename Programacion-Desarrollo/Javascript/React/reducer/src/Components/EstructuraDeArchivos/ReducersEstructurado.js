import React, { useReducer } from 'react'
import { TYPE } from './Actions/contadorAction';
import { contadorReducer, initState } from './Reducers/contadorReducer';

export default function ReducersEstructurado() {
    const [state, dispatch] = useReducer(contadorReducer, initState);
    const handlerSumar = () => dispatch({type:TYPE.SUMAR});
    const handlerRestar = () => dispatch({type:TYPE.RESTAR});

  return (
    <div>
        <h1>Reducer Mejorado En Estructura De Contador</h1>
        <h2>Contador:{state.contador}</h2>
        <button onClick={handlerSumar}>Sumar</button>
        <button onClick={handlerRestar}>Restar</button>
    </div>
  )
}
//Y esa seria la manera correcta y ordenada de separar archivos usando Reducer

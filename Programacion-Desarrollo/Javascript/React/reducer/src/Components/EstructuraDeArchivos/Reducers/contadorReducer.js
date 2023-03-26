import { TYPE } from "../Actions/contadorAction";
//En reducer iran el valor inicial, la funcion reductora y el valor de transformacion inicial, si es que lo hay

//Para reducer el valor inicial
export const initState = {
    contador:0
}
//Para reducer su funcion reductora
export const contadorReducer = (state,action) =>{

    switch (action.type) {
        case TYPE.SUMAR:
            return {contador:state.contador +1}
        case TYPE.RESTAR:    
            return {contador:state.contador -1}
        default:
            return state;
    }
}
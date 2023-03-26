import { CONTADOR_RESTAR, CONTADOR_SUMAR } from "../types";

const initialContador = 0;

export const explicacionReducer = (state = initialContador,actions) =>{
    
    switch (actions.type) {
        case CONTADOR_SUMAR:
            return state +1;
        case CONTADOR_RESTAR:
            return state-1;
        default:
           return state;
    }
}
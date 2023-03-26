import { TYPES } from "../actions/actionsCrud";


export const initCrud = {
    empleadoRecibir:null,
    datos:[]
}

export const reducerCrud = (state,actions) =>{

    switch (actions.type) {
        case TYPES.READ_DATA:
            {

            }
        case TYPES.CREATE_DATA:
            {
    
            }
        case TYPES.UPDATE_DATA:
            {
        
            }
        case TYPES.DELETE_DATA:
            {
    
            }
        default:
            break;
    }
}
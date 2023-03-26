import { CONTADOR_RESTAR, CONTADOR_SUMAR } from "../types";


export const sumar = () =>({type:CONTADOR_SUMAR});
export const restar = () =>({type:CONTADOR_RESTAR});
import { ADD_CART, CLEAR_CART, REMOVE_ALL_FROM_CART, REMOVE_ONE_FROM_CART } from "../types";


export const addCart = (id) =>({type:ADD_CART,payload:id});
export const removeOneFromCart = (id) =>({type:REMOVE_ONE_FROM_CART,payload:id});
export const removeAllFromCart = (id) =>({type:REMOVE_ALL_FROM_CART,payload:id});
export const clearCart = () =>({type:CLEAR_CART});
import React, { useReducer } from 'react'
import { TYPES } from './actions/carritoActions';
import Carrito from './Carrito';
import Productos from './Productos';
import { carritoReducer, initCarrito } from './reducer/carritoReducer'

export default function CarritoCompras() {
    const [state, dispatch] = useReducer(carritoReducer, initCarrito);

    const handlerAgregar = (id) =>dispatch({type:TYPES.ADD_TO_CART,payload:id});
    const handlerEliminar1Carrito = (id) =>dispatch({type:TYPES.DEL_FROM_CART,payload:id});
    const handlerEliminarTodosCarrito = (id) =>dispatch({type:TYPES.DEL_ALL_FROM_CART,payload:id});
    const handlerLimpiarCarrito = () =>dispatch({type:TYPES.CLEAR_CART});
  return (
    <div>
        <h1>Carrito de compras</h1>
        <h2>Productos</h2>
        {state.productos.map(producto=><Productos producto={producto} key={producto.id} handlerAgregar={handlerAgregar}/>)}
        <h2>Carrito</h2>
        <button onClick={handlerLimpiarCarrito}>Limpiar Carrito</button>
        {
        (state.carrito.lenght === 0)
        ?<h3>Aun no haz añadido nada al carrito</h3>
        :(state.carrito.map(carro=><Carrito productos={carro} repeticiones={state.repeat[carro.id-1]} handlerEliminar={handlerEliminar1Carrito} handlerEliminarTodos={handlerEliminarTodosCarrito}/>))
        }

    </div>
  )
}

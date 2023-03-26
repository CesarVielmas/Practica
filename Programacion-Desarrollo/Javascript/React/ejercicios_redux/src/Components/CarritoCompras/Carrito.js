import React from 'react'
import { useDispatch } from 'react-redux';
import { removeAllFromCart, removeOneFromCart } from '../../actions/carritoActions';

export default function Carrito({carro,repeat}) {
  //Destructuracion de lo que se necesita
  const {id,precio,producto} = carro;
  //Dispatch
  const dispatch = useDispatch();
  return (
    <div style={{border:"thin solid black", with:"40vw",height:"30vh",margin:"20px auto 30px auto",textAlign:"center",padding:"20px"}}>
        <h3>{producto}</h3>
        <h3>Precio:${precio} c/u</h3>
        <h3>Cantidad:{repeat}</h3>
        <h3>Total:${precio*repeat}</h3>
        <button onClick={()=>dispatch(removeOneFromCart(id))}>Eliminar 1</button>
        <button onClick={()=>dispatch(removeAllFromCart(id))}>Eliminar Todos</button>
    </div>
  )
}

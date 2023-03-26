import React from 'react'
import { useDispatch } from 'react-redux';
import { addCart } from '../../actions/carritoActions';

export default function Productos({productos}) {
  const {producto,precio,id} = productos;
  const dispatch = useDispatch();
  return (
    <div style={{border:"thin solid black", with:"40vw",height:"30vh",margin:"20px auto 30px auto",textAlign:"center",padding:"20px"}}>
        <h3>{producto}</h3>
        <br/>
        <h3>Precio:{precio}</h3>
        <button onClick={()=>dispatch(addCart(id))}>Agregar Al Carrito</button>
    </div>
  )
}

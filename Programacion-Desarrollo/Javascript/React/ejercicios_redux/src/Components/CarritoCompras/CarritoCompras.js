import React from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { clearCart } from '../../actions/carritoActions';
import Carrito from './Carrito'
import Productos from './Productos'

export default function CarritoCompras() {
    //Obteniendo los valores con selector
   const selector = useSelector(state=>state);
   //Viendo los valores (descomentar para ver)
   //console.log(selector.carritoCompras);
   //console.log(selector);
   //Destructurando lo importante para este ejercicio
   const {productos,carrito,repeat} = selector.carritoCompras;
   //console.log(productos,carrito,repeat);
   //console.log(repeat);
   //Dispatch para el limpiar carrito
   const dispatch = useDispatch();
  return (
    <div>
        <h1>Carrito de compras en Redux</h1>
        <h2>Productos</h2>
        {
            productos.map(producto=><Productos productos={producto} key={producto.id} />)
        }
        <h2>Carrito</h2>
        <button onClick={()=>dispatch(clearCart())}>Limpiar Carrito</button>
        {
            (carrito.length === 0)
            ?<h3>No Hay Elementos en el carrito</h3>
            :(carrito.map(carro => <Carrito carro={carro} repeat={repeat[carro.id-1]} key={carro.id}/>))
        }
    </div>
  )
}

import React from 'react'

export default function Carrito({productos,repeticiones,handlerEliminar,handlerEliminarTodos}) {
    const {id,producto,precio} = productos;
  return (
    <div>
        <h3>{producto}</h3>
        <h3>Precio Individual:{precio}</h3>
        <h3>Cantidad Añadida:{repeticiones}</h3>
        <h3>Total:{repeticiones*precio}</h3>
        <button onClick={()=>handlerEliminar(id)}>Eliminar 1 Producto Del Carrito</button>
        <button onClick={()=>handlerEliminarTodos(id)}>Eliminar Todos Estos Productos Del Carrito</button>
    </div>
  )
}

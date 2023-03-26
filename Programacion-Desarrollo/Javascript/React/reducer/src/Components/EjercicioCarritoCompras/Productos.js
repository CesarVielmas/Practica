import React from 'react'

export default function Productos({producto,handlerAgregar}) {
    const {id,productos,precio} = producto;
  return (
    <div>
        <h3>{productos}</h3>
        <h3>{precio}</h3>
        <button onClick={()=> handlerAgregar(id)}>Agregar al carrito</button>
    </div>
  )
}

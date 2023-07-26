import React from 'react'

export default function TrRow({nombre,correo,domicilio,edad,curp,id,acceptEdit,eliminarDato}) {
  return (
    <tr>
        <td>{nombre}</td>
        <td>{correo}</td>
        <td>{domicilio}</td>
        <td>{edad}</td>
        <td>{curp}</td>
        <td><button onClick={()=>acceptEdit(id)}>Editar</button></td>
        <td><button onClick={()=>eliminarDato(id)}>Eliminar</button></td>
    </tr>
  )
}

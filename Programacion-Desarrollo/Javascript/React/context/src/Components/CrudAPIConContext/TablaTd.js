import React from 'react';

export const TablaTd = ({data,editarContenido,eliminarContenido}) =>{
    return(
        <tr>
            <td>{data.nombre}</td>
            <td>{data.sueldo}</td>
            <td>{data.area}</td>
            <td>{(data.contratado)?"Contratado":"No Contratado"}</td>
            <td><button onClick={()=>editarContenido(data)}>Editar</button></td>
            <td><button onClick={()=>eliminarContenido(data.id)}>Eliminar</button></td>
        </tr>
    )
}
import React from 'react';

export const TablaTd = ({nombre,sueldo,area,contrato,id,editar,eliminar}) =>
{
    return(
        <tr>
            <td>{nombre}</td>
            <td>{sueldo}</td>
            <td>{area}</td>
            <td>{contrato}</td>
            <td><button onClick={()=>editar({nombre,sueldo,area,contrato,id})}>Editar</button></td>
            <td><button onClick={()=>eliminar(id)}>Eliminar</button></td>
        </tr>
    )
}
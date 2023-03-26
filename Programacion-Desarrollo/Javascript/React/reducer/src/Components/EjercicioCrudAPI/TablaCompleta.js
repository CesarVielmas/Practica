import React from 'react';
import { useFetch } from './hooks/useFetch';
import { TablaTd } from './TablaTd';

export const TablaCompleta = ({data,eliminarContenido,editarContenido}) =>{
   
    
    return(
        <>
       <table>
        <thead>
        <tr>
            <td>Nombre</td>
            <td>Sueldo</td>
            <td>Area</td>
            <td>Contrato</td>
        </tr>
        </thead>

        <tbody>
            {
                (data.length === 0)
                ?<tr><td>No hay datos</td></tr>
                :(data.map(el=><TablaTd data={el} eliminarContenido={eliminarContenido} editarContenido={editarContenido} key={el.id}></TablaTd>))
            }
        
        </tbody>
       </table>
        </>
    )
}
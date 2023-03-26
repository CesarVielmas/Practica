import React from 'react';
import { useNavigate } from 'react-router-dom';
import { TablaTd } from './Rutas/TablaTd';

export const TablaCompleta = ({data,eliminarContenido,editarContenido}) =>{
   let navigate = useNavigate();
    
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
                :(data.map(el=><TablaTd data={el} eliminarContenido={eliminarContenido} editarContenido={()=>{ navigate('formulario/editar'); editarContenido();}} key={el.id}></TablaTd>))
            }
        
        </tbody>
       </table>
        </>
    )
}
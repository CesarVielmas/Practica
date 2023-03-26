import React, { useContext } from 'react';
import CrudContext from './Context/CrudContext';
import { TablaTd } from './TablaTd';

export const TablaCompleta = () =>{
   const {data,eliminarContenido,editarContenido} = useContext(CrudContext);
    
   
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
            (data.map(el=><TablaTd data={el} eliminarContenido={eliminarContenido} editarContenido={editarContenido} key={el.id}></TablaTd>))
            }
        
        </tbody>
       </table>
        </>
    )
}
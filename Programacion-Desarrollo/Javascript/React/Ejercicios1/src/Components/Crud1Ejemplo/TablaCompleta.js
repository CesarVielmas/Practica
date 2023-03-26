//Importacion de React
import React from 'react';
import { TablaTd } from './TablaTd';
let contador = 0;
export const TablaCompleta = ({empleados,obtenerParaEditar,eliminarDatos}) =>{

    return(
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
        (empleados.length === 0)
        ?<h2>No hay empleados</h2>
        :(empleados.map(empleado => <TablaTd nombre={empleado.nombre} key={empleado.id} id={empleado.id} area={empleado.area} sueldo={empleado.sueldo} contrato={(empleado.contratado)?"Contratado":"No Contratado"} editar={obtenerParaEditar} eliminar={eliminarDatos}></TablaTd>))
    }
        </tbody>
    </table>
        
    );
}
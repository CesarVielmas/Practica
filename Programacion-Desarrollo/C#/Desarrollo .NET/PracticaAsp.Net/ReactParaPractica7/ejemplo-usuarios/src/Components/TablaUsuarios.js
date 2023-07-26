import React from 'react'
import TrRow from './TrRow'

export default function TablaUsuarios({datos,eliminarDato,acceptEdit}) {
  return (
    <table>
        <thead>
            <tr>
                <td>Nombre</td>
                <td>Correo</td>
                <td>Domicilio</td>
                <td>Edad</td>
                <td>Curp</td>
            </tr>
        </thead>
        <tbody>
            {
                datos.map((dato)=><TrRow nombre={dato.nombre} correo={dato.correo} edad={dato.edad} curp={dato.curp} domicilio={dato.domicilio} id={dato.id} eliminarDato={eliminarDato} acceptEdit={acceptEdit}/>)
            }
            
        </tbody>
    </table>
  )
}

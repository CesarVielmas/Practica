import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';

const valorInicial = {
    nombre:" ",
    area:" ",
    sueldo:0,
    contratado:false,
    id:null
}
export const Formulario = ({empleado,subirDatos,actualizarDatos}) =>{
    const[datos1,setDatos1] = useState(valorInicial);
    let navigate = useNavigate();

   
    const handlerChange = (e) =>{

         if (e.target.id === "Contratado") {
             setDatos1({
                 ...datos1,
                 [e.target.id.toLowerCase()]:e.target.checked
             })
         }
         else{
             setDatos1({
                 ...datos1,
                 [e.target.id.toLowerCase()]:e.target.value
             })
         }
     }
     
     const handlerSubmit = (e) => {
         e.preventDefault();
         alert(`datos1 Enviados\nNombre:${datos1.nombre}\nSueldo:${datos1.sueldo}\nArea:${datos1.area}\nContratado:${datos1.contratado}`);
        
         if (datos1.id === null) {
             navigate('/')
             subirDatos(datos1);
         }
         else{
             actualizarDatos(datos1);
         }
         
     }
     useEffect(()=>{
        if (empleado!==undefined) {
            setDatos1(empleado);
        }
    },[empleado])

    return(
        <>
        <form onSubmit={handlerSubmit}>
        <label htmlFor='nombre'>Nombre</label>
        <br/>
        <input type="text" id='nombre' value={datos1.nombre} onChange={handlerChange}/>
        <br/>
        <label htmlFor='area'>Area</label>
        <br/>
        <select onChange={handlerChange} value={datos1.area} id='area'>
            <option value="Asistente">Asistente</option>
            <option value="Derechos Humanos">Derechos Humanos</option>
            <option value="Abogado">Abogado</option>
            <option value="Empleado">Empleado</option>
        </select>
        <br/>
        <label htmlFor='Sueldo'>Sueldo</label>
        <br/>
        <input type="number" onChange={handlerChange} value={datos1.sueldo} id="Sueldo"/>
        <br/>
        <label htmlFor='Contratado'>Contratado</label>
        <br/>
        <input type="checkbox" onChange={handlerChange} value={datos1.contratado} id='Contratado'/>
        <br/>
        <input type="submit" value="Agregar"/>
        </form>
        
        </>
    )
}
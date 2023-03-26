import React,{useEffect, useState} from 'react';
import { CrudEjemplo1 } from './CrudEjemplo1';
const inicioDatos = {
    nombre:"",
    area:"",
    sueldo:0,
    contratado:false,
    id:null
}
export const Formulario = ({subirDatos,actualizarDatos,datosEdit}) =>{
    const[datos,setDatos] = useState(inicioDatos);

    useEffect(()=>{
        setDatos(datosEdit);
    },[datosEdit])

    const handlerChange = (e) =>{
        if (e.target.id === "Contratado") {
            setDatos({
                ...datos,
                [e.target.id.toLowerCase()]:e.target.checked
            })
        }
        else{
            setDatos({
                ...datos,
                [e.target.id.toLowerCase()]:e.target.value
            })
        }
    }
    
    const handlerSubmit = (e) => {
        e.preventDefault();
        alert(`Datos Enviados\nNombre:${datos.nombre}\nSueldo:${datos.sueldo}\nArea:${datos.area}\nContratado:${datos.contratado}`);
       
        if (datos.id === null) {
            subirDatos(datos);
        }
        else{
            actualizarDatos(datos);
        }
        
    }
    
    return(
       
        <>
         <form onSubmit={handlerSubmit}>
        <label htmlFor='nombre'>Nombre</label>
        <br/>
        <input type="text" id='nombre' value={datos.nombre} onChange={handlerChange}/>
        <br/>
        <label htmlFor='area'>Area</label>
        <br/>
        <select onChange={handlerChange} value={datos.area} id='area'>
            <option value="Asistente">Asistente</option>
            <option value="Derechos Humanos">Derechos Humanos</option>
            <option value="Abogado">Abogado</option>
            <option value="Empleado">Empleado</option>
        </select>
        <br/>
        <label htmlFor='Sueldo'>Sueldo</label>
        <br/>
        <input type="number" onChange={handlerChange} value={datos.sueldo} id="Sueldo"/>
        <br/>
        <label htmlFor='Contratado'>Contratado</label>
        <br/>
        <input type="checkbox" onChange={handlerChange} value={datos.contratado} id='Contratado'/>
        <br/>
        <input type="submit" value="Agregar"/>
        </form>
       
        </>
    )

}
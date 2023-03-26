import React, { useEffect,useState } from 'react';
import { Formulario } from './FormularioEnvio';
import { TablaCompleta } from './TablaCompleta';
import { useFetch } from './hooks/useFetch';

export const CrudEjemplo2 = () =>{
    let data = useFetch("http://localhost:3001/empleados");
    let [empleadoRecibir,setEmpleadoRecibir] = useState();
    const[datos,setDatos] = useState([]);

    const recarga =async () =>{
        let res = await fetch("http://localhost:3001/empleados");
        let json = await res.json();
        return json;
    }

    const actualizarContenido = async (empleado) =>{
        fetch(`http://localhost:3001/empleados/${empleado.id}`,{
            method:"PUT",
            headers: {
                'Content-Type': 'application/json'
            },
            body:JSON.stringify(empleado)
        })
        data = await recarga();
        setDatos(data);
    }
    const anadirContenido =async (empleado) =>{
        empleado.id = datos.length;
        fetch(`http://localhost:3001/empleados`,{
            method:"POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body:JSON.stringify(empleado)
        })
        data = await recarga();
        setDatos(data);
    }

    const editarContenido = (empleado) =>{
        setEmpleadoRecibir(empleado);
    }

    const eliminarContenido =async (id) =>{
        fetch(`http://localhost:3001/empleados/${id}`,{
            method:"DELETE"
        })
       data = await recarga();
       setDatos(data);
    }

   useEffect(()=>{
    setDatos(data);
    console.log(datos);
   },[data])
   
    return(
        <>
        <h1>Crud De Ejemplo 2 (Datos de Json Server)</h1>
        <Formulario empleado={empleadoRecibir} subirDatos={anadirContenido} actualizarDatos={actualizarContenido}></Formulario>
        {
            (datos !== undefined)
            ?<TablaCompleta data={datos} eliminarContenido={eliminarContenido} editarContenido={editarContenido}></TablaCompleta>
            :<h2>Esperando Datos</h2>
        }
        </>
    )
}
import React,{ useEffect,useState } from 'react';
import { useFetch } from './hooks/useFetch';
import { HashRouter, Route, Routes } from 'react-router-dom';
import { RutasCrud } from './Rutas/ManejoRutasCrud';
import { Agregar } from './Rutas/Agregar';
import { Ver } from './Rutas/Ver';

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
        empleado.id = datos.length +1;
        console.log(empleado);
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
        <HashRouter>
            <RutasCrud/>
            <Routes>
                <Route path='formulario/agregar' element={<Agregar empleado={empleadoRecibir} subirDatos={anadirContenido} actualizarDatos={actualizarContenido}/>}/>
                <Route path='/' 
                element={
                    (datos !== undefined)
            ?<Ver data={datos} eliminarContenido={eliminarContenido} editarContenido={editarContenido}></Ver>
            :<h2>Esperando Datos</h2>}/>

                <Route path='formulario/editar' element={<><Agregar empleado={empleadoRecibir} subirDatos={anadirContenido} actualizarDatos={actualizarContenido}/><Ver data={datos} eliminarContenido={eliminarContenido} editarContenido={editarContenido}></Ver></>}/>
            </Routes>
        </HashRouter>
        </>
    )
}
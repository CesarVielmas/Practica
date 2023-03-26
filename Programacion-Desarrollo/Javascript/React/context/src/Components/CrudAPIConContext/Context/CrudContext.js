import { createContext, useEffect, useState } from "react";
import { useFetch } from "../hooks/useFetch";

const CrudContext = createContext();

//Provider

export const CrudProvider = ({children}) =>{
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

   const datosProvider = {empleadoRecibir,anadirContenido,actualizarContenido,data,eliminarContenido,editarContenido};
   return (data!== undefined&&datos!==undefined)?<CrudContext.Provider value={datosProvider}>{children}</CrudContext.Provider>:""
}

export default CrudContext;
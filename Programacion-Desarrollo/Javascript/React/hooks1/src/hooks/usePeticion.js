//Importacion de react y destructuracion
import React,{useState,useEffect} from 'react';
//Esto es un hook personalizado no confundir con un componente ya que el hook personalizado hara algo automatico con solo llamarlo
export function Peticion(url){
    const[datos,setDatos] = useState(null);
    const[status,setStatus] = useState("Pendiente");
    const[error,setError] = useState(false);

    useEffect(()=>{
        //Haciendo la peticion a fetch de anera asincronica
        const obtenerDatos =async(url) =>{
            //try catch por si hay errores
            try {
                let respuesta = await fetch(url);
                if (!respuesta.ok) {
                    throw {estado:respuesta.status,error:"Hubo un error"};
                }
                let archivoJson = await respuesta.json();
                setDatos(archivoJson);
                setStatus("Aceptado");
            } catch (error) {
                setStatus("Hubo un error");
                setError(error);
            }
        }
        obtenerDatos(url)
    },[url])
    //Ahora como es un hook personalizado retornara los objetos y no retornara etiquetas de JSX ya que no es un componente
    return(
        {
            datos,
            status,
            error
        }
    )
}
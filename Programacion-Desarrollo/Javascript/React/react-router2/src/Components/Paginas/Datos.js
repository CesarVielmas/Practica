import React from 'react';
import { useParams } from 'react-router';
//Para el envio de datos se usa useParams de react-router por lo cual , este envio de datos recibe de la url lo que necesita y necesita llenarse bien lo que pide cada ruta por ejemplo en rutas tiene un "/datos/:nombre/:edad/:altura" por lo cual los datos que necesita recibir o enviar son los 3 que necesita
export const Datos = () =>{
    const datos = useParams();
    console.log(datos);
    return(
        <>
        <h3>{datos.nombre}</h3>
        <h3>{datos.edad}</h3>
        <h3>{datos.altura}</h3>
        </>
    )
}
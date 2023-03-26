//Importacion de React necesaria
import React,{useState,useEffect} from 'react';
//Importacion del hook personalizado
import { Peticion } from '../hooks/usePeticion';
//Ahora se veran los hooks personalizados para usar hooks personalizados o crearlos se necesita poner siempre en la creacion de este la palabra "use" al principio del archivo
export function HookPersonalizado(){
    let objetoPeticion = Peticion("https://pokeapi.co/api/v2/");
    return(
        <>
        <h1>hooks personalizados</h1>
        <h2>estatus del estado de obtencion de datos: {JSON.stringify(objetoPeticion.status)}</h2>
        <h2>errores encontrados en la obtencion de dato:{JSON.stringify(objetoPeticion.error)}</h2>
        <h2>codigo entregado:{JSON.stringify(objetoPeticion.datos)}</h2>
        </>
    )
}
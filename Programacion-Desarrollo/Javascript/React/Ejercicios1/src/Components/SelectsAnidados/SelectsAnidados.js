import React, { useEffect, useState } from 'react';
import { useFetch } from '../Crud2Ejemplo/hooks/useFetch';
import { Loader } from '../Loader';
import { Estados } from './Estados';

export const SelectsAnidados = () =>{
    let objeto = useFetch("https://api.copomex.com/query/get_estados?token=5e83a2eb-f80f-4a09-931c-152308670368");
    const [activo,setActivo] = useState(false);
    const [estados,setEstados] = useState(null);

    useEffect(()=>{
      if (objeto === null || objeto=== undefined) return;

      setEstados(objeto.response.estado);
      setActivo(true);
    },[objeto]);
    
    return(
        <>
        <h1>Select Anidados</h1>
        {(activo)?<Estados estados={estados}></Estados>:<Loader></Loader>}
        </>
    )
}
import React, { useState,useEffect } from 'react';
import { Municipios } from './Municipio';

export const Estados = ({estados}) =>{
    let objeto = null;
    const [activo,setActivo] = useState(false);
    const [municipios,setMunicipios] = useState(null);

    const handlerChange = (e) =>{

        const asincrono = async()=>{
            let res =await fetch(`https://api.copomex.com/query/get_municipio_por_estado/${e.target.value}?token=5e83a2eb-f80f-4a09-931c-152308670368`);
            objeto = await res.json();
            setMunicipios(await objeto.response.municipios);
            setActivo(true);
        }
        asincrono();
    }
    useEffect(()=>{
      if (objeto === null || objeto=== undefined) return;
      setMunicipios(objeto.response.municipios);
      setActivo(true);
    },[objeto]);

    return(
        <>
        <select onChange={handlerChange}>
        {(estados.map(estado=><option value={estado}>{estado}</option>))}
        </select>
        <br/>
        {(activo)?<Municipios municipios={municipios}></Municipios>:<select></select>}
        
        </>
    )
}
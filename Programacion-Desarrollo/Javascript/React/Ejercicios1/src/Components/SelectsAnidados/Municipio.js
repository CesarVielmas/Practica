import React,{useState,useEffect} from 'react';
import { Colonias } from './Colonias';

export const Municipios = ({municipios}) =>{
    let objeto = null;
    const [activo,setActivo] = useState(false);
    const [colonias,setColonias] = useState(null);

    const handlerChange = (e) =>{

        const asincrono = async()=>{
            let res =await fetch(`https://api.copomex.com/query/get_colonia_por_municipio/${e.target.value}?token=5e83a2eb-f80f-4a09-931c-152308670368`);
            objeto = await res.json();
            setColonias(await objeto.response.colonia);
            setActivo(true);
        }
        asincrono();
    }
    useEffect(()=>{
      if (objeto === null || objeto=== undefined) return;
      setColonias(objeto.response.colonia);
      setActivo(true);
    },[objeto]);
    return(
        <>
        <select onChange={handlerChange}>
        {(municipios.map(municipio=><option value={municipio}>{municipio}</option>))}
        </select>
        <br/>
        {(activo)?<Colonias colonias={colonias}></Colonias>:<select></select>}

        </>
    )
}
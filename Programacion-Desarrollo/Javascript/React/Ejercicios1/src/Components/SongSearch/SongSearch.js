//Importacion de React
import React, { useEffect, useState } from 'react';
import { useFetch } from '../Crud2Ejemplo/hooks/useFetch';
import { Loader } from '../Loader';
import { Detalles } from './Detalles';
import { Formulario } from './Formulario';

export const SongSearch = () =>{
    const [loader,setLoader] = useState(true);
    const [enviado,setEnviado] = useState(null);
    const [biografia,setBiografia] = useState(null);
    const [letra,setLetra] = useState(null);
    useEffect(()=>{
        if (enviado === null) return;

        const asincrono = async()=>{
            let urlBiografia = `https://www.theaudiodb.com/api/v1/json/2/search.php?s=${enviado.artista}`;
            let urlLetra = `http://api.chartlyrics.com/apiv1.asmx/SearchLyric?artist=${enviado.artista}&song=${enviado.cancion}`;
            
            console.log("\n",urlBiografia,"\n",urlLetra);
            //Letra
            let resLetra = await fetch(urlLetra);
            let jsonLetra = resLetra.json();
            console.log("Biografia:",jsonLetra);
            setLetra(await jsonLetra);

            //Biografia
            let resBio = await fetch(urlBiografia);
            let jsonBiografia = await resBio.json();
            console.log("Letra:",jsonBiografia);
            setBiografia(await jsonBiografia);

        }
        asincrono();
    },[enviado])
    const datosEnviados = (datos) =>{
        console.log(datos);
        setEnviado(datos);
    }
    return(
        <>
        <h1>Song Search</h1>
        <Formulario datosEnviados={datosEnviados}></Formulario>
        {loader?<Loader></Loader>:<Detalles></Detalles>}
        </>
    )
}
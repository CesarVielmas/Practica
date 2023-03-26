import React, { useState } from 'react';
import { useLocation} from 'react-router';
import {useNavigate} from 'react-router-dom'
export const EnvioDatos2 = () =>{
    //El use location para lo que sirve en react-router e tomar los datos directamente de la url , asi mismo al tomar los datos de la url , se guardara en location y en search , ya que location es un objeto donde contiene el contenido de la url en search
    let location = useLocation();
    console.log(location);
    //Aqui se hace una conversion con el objeto location para obtener directamente su search o su query , para que sea aun mas sencillo obtener sus datos
    const locationParam = new URLSearchParams(location);
    //Obteniendo los datos de la url con get el cual es un metodo de URLSearchParams y si no los encuentra entonces asigna los valores
    const[start,setStart] = useState(parseInt(locationParam.get("start"))||1);
    const[fin,setFin] = useState(parseInt(locationParam.get("fin"))||20);
    //useNavigate() es el metodo con el que se puede modificar location , ya que dentro de navigate esta location y se puede modificar con esto
    const navigation = useNavigate();

    const handlerAtras = () =>{
      //Modificando navigation y su location , ya que navigation como usa useNavigate , es una funicion que toma el siguiente valor que tomara el location
      navigation(`?start=${start-20}&fin=${fin-20}`);
      setStart(parseInt(locationParam.get("start")));
      setFin(parseInt(locationParam.get("fin")));
    }
    const handlerAdelante = () =>{
         
          //Modificando navigation y su location , ya que navigation como usa useNavigate , es una funicion que toma el siguiente valor que tomara el location
          navigation(`?start=${start+20}&fin=${fin+20}`);
          setStart(parseInt(locationParam.get("start")));
          setFin(parseInt(locationParam.get("fin")));
    }
    return(
        <>
        <h2>Envio De Datos 2</h2>
        <h3>Productos</h3>

        <p>de {start} a {fin}</p>
        <button onClick={handlerAtras}>Atras</button>
        <button onClick={handlerAdelante}>Adelante</button>
        </>
    )
}
//Importacion de React con su destructuracion
import React,{useEffect,useState} from 'react';

//Componente de funcion para desplegar la hora
function HoraActual(props){
    return <h2>{props.hora}</h2>
}

//Se hara el reloj como el anterior con componentes de clase , pero ahora con los hooks y con componentes de funciones
export function Reloj(){
    //estados del programa
    const[hora,setHora] = useState(new Date().toLocaleTimeString()),
    [estado,setEstado] = useState(false);
    
    const cambiarHora = (estado)=>{
        let temporizador;
        if (estado) {
            temporizador = setInterval(()=>{
                setHora(new Date().toLocaleTimeString());
            },1000)
        }
        if(!estado)clearInterval(temporizador);

    }
    //Ciclo de vida de actualizacion 
    useEffect(()=>{
        if (estado) {
         cambiarHora(true);
        }
        else
        {
            //Cuando acaba entonces entra en el ciclo de vida del desmontaje
            cambiarHora(false);
            console.log("Desmontaje");
        } 

    },[estado])

    return(
        <>
        <h1>Hora Actual</h1>
        {
            (estado)
            ?<HoraActual hora={hora}></HoraActual>
            :<h2>Hora detenida</h2>
        }
        <button onClick={()=>setEstado(true)}>Iniciar</button>
        <button onClick={()=>setEstado(false)}>Detener</button>
        </>
    )
}
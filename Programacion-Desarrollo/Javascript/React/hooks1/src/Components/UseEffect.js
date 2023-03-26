//Importacion de react necesaria con destructuracion del useState y useEffect
import React,{useState,useEffect} from 'react';

//Ahora lo que se vera sera el useEffect el cual se usa para poder ver el ciclo de vida de los componentes de funciones que incluye los hooks
export function Pantalla(){
    //Declarando en el estado una variable
    const[scrollY,setScrollY] = useState(0);

    //Esta es la manera simple de llamar a un useEffect , se pueden llamar multiple veces en el codigo y cada useEffect representa dependiendo de la manera en que se escriba , cada uno de los ciclos de vida del componente se vera el de montado y actualizacion

    //Ciclo de vida de montado
    useEffect(()=>{     
        //Este ciclo de montado solo se ejecutara 1 vez y para esto en el segundo parametro de useEffect donde usa un array , debe ir vacio para que solo se ejecute 1 vez el dicho codigo
        console.log("El componente fue montado");
    },[]);

    //Ciclo de vida de actualizacion

    //Para esto se hara un evento que localize el scrollY de la pantalla el cual modificara el ScrolllY
    const moverPantalla = ()=> 
    {
    setScrollY(window.scrollY);
    };
    //Para el ciclo de vida de actualizacion debe haber una variable en el estado que debe de recibir en el useEffect en el array de su segundo parametro , esto le dice al programa que haga un seguimiento a dicha variable y que si hay cambio , entonces ejecute lo que tiene dentro el useEffect
    useEffect(()=>{
        window.addEventListener("scroll",moverPantalla);
    },[scrollY])

    return(
        <>
        <h1>Pantalla</h1>
        <h2>Valor scrollY: {scrollY}</h2>
        </>
    )
}
//En UseEffect2 se vera los ciclos de ida faltantes los cuales son el de desmontado
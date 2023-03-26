import React,{useCallback, useState} from 'react';
import HijoBack  from './BackHijo';

//Uno de los problemas con las memorizaciones , es que al obtener funciones, estas no funcionan como se quisiera que fuera ya que al momento de usar alguna otra funcion , como renderiza el componente otra vez , entonces renderiza otra vez la funcion y esto hace que lo repita "x" cantidad de veces , para solucionar esto , se trajo las CallBacks las cuales ayudan a que no se renderize una funcion en especifico y que solo se renderize cuando se use

//Se hara el mismo ejemplo con el contador
export const CallBack = () =>{

    const[contador,setContador] = useState(0);
    const[valor,setValor] = useState("");
    //Usando CallBack para evitar que se renderize esta funcion a menos que cambie el valor de contador [contador]
    const handlerSumar = useCallback(
      () => {
        setContador(contador+1);
      },
      [contador]//Importante asignar la observacion o las variables que usara la funcion del callBack
    );
    const handlerRestar = useCallback(
        () => {
          setContador(contador-1);
        },
        [contador]//Importante asignar la observacion o las variables que usara la funcion del callBack que haran que vuelva a renderizar la funcion
      );
    const handlerChange = (e) => setValor(e.target.value);
    
    return(
        <>
        <h1>Contador Para Ver Funcionamiento De La Memorizacion</h1>
        <p>{contador}</p>
        <button onClick={handlerSumar}>Sumar</button>
        <button onClick={handlerRestar}>Restar</button>
        <input type="text" value={valor} onChange={handlerChange} />
         {
            //Para ver el funcionamiento de la renderizacion sin las CallBack simplemente eliminar useCallBack de las funciones y asi ver que lo anterior que se comento es cierto
         }
        <HijoBack sumar={handlerSumar} restar={handlerRestar} contador={contador}/>
        </>
    )
}
//Para usar los useStates de los hooks se deben de importar con destructuracion en React
import React,{useState} from 'react';

//Ahora , los hooks son una manera para poder usar todo lo que los elementos de clases incluye y los componentes de funciones no para poder simplificar y dar una manera mejor de escribir componentes
export function Contador(){
    //Para referenciar o usar o dar una variable a un estado se debe hacer de esta manera
    //Se asigna la variable que estara dentro del estado y su set , ya que no existe un setState y se debe usar ese set para que modifque dicha variable de estado , despues de asignar ambos valores , se deben igualar a useState y entre los parentesis o sus parametros debe asignarse el valor que tomara dicho valor en este caso contador tomara el valor de 0 pero podria tomar cualquier otro
    const[contador,setContador] = useState(0);

    //Ahora esta funcion expresada lo que hara es que con setContador , el cual es como si fuera un setState pero exlusivo para la variable contador que es la que setea , le sumara 1 
    const sumar = () => setContador(contador+1);
    const restar = () => setContador(contador-1);
    
    //return pues en las funciones de componentes no necesita de un metodo render
    return(
        <>
        <h1>Modificar el state</h1>
        <button onClick={sumar}>+</button>
        <button onClick={restar}>-</button>
        <h2>Contador {contador}</h2>
        </>
    )
}
//Entonces en un codigo tan reducido gracias a useState , se pudo lograr dicho contador de modificacion del state
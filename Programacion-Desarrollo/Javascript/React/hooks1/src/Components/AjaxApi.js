//Importacion de React y su destructuracion para los hooks
import React,{useState,useEffect} from 'react';
import { Contador } from './UseState';
//Componente de funcion para cada pokemon generado usando destructuracion con las props que le fueron pasadas
function Pokemon({nombre,imagen,id}){
    return(
        <>
        <h2>Pokemon {id}: {nombre}</h2>
        <img src={imagen} alt={nombre}/>
        </>
        
    )
}
//Ahora lo que se hara sera una peticion a una api con fetch usando hooks en un componente de funcion y para que sea diferente se usara fetch asincrono
export function Pokemons(){
    //declarando los estados
    const[pokemons,setPokemons] = useState([]);

    //Usamos el useEffect del ciclo de vida de el montaje , el cual es con el array vacio
    useEffect(()=>{
        let pokedatos = [];
        let contador = 0;
        //Como sera en fetch asincrono entonces en una funcion asincrona se pondra todo
        const obtenerPokemons = async()=>
        {
            let respuesta = await fetch("https://pokeapi.co/api/v2/pokemon");
            let archivoJson = await respuesta.json();
            archivoJson.results.forEach(async pokemones=>{
                let respuesta = await fetch(pokemones.url);
                let archivoJson = await respuesta.json();
                let objetoPokemons = {
                    id:  archivoJson.id,
                    nombre:  archivoJson.name,
                    imagen:  archivoJson.sprites.front_default
                }
                pokedatos[contador] = objetoPokemons;
                contador++;
                setPokemons(pokedatos);
            })
            
        }
        obtenerPokemons();
       
    },[])
    //Return para dar los respectivos valores
    return(
        
        <>
        <h1>Pokemons obtenidos con fetch asincrono y usando hooks</h1>
        {
            (pokemons.length === 0)
            ?<h2>Cargando...</h2>
            :(pokemons.map(pokemon=><Pokemon nombre={pokemon.nombre} key={pokemon.id} id={pokemon.id} imagen={pokemon.imagen}></Pokemon>))
        }
        </>
    )
}
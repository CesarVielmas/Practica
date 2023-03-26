//Importacion de React con destructuracion
import React, { Component } from 'react';

//Componente de funcion el cual hara cada pokemon 
function Pokemon(props){
    return(
        <>
        <h2>{props.nombre}</h2>
        <img src={props.imagen} alt={props.nombre}/>
        </>
    )
}
//Ahora se vera como hacer una peticion ajax con fetch en React para ello se usara la api pokemon
//Componente de clase
export class PeticionAjax extends Component{
    state ={
        pokemons:[]
    }
    //Las peticiones a APIS se deben hacer en react cuando el componente este montado en el DOM por lo cual para hacer esto se usa casi siempre el componentDidMount para hacer las peticiones
    componentDidMount()
    {
        //Array que almacenara los pokemons
        let pokemons =[];
        //Peticion de fetch
        fetch("https://pokeapi.co/api/v2/pokemon")
        //Si el elemento en fetch es cargado ya que se una promise entonces mandara el elemento en json a el otro then
        .then(elemento=>elemento.json())
        .then(elemento=>{
            elemento.results.forEach(el=>{
                //Segunda peticion de fetch , ya que la url que manda results viene todo el contenido de los pokemons pero en otro json
                fetch(el.url)
                .then(elemento=>elemento.json())
                .then(elemento=>{
                   let pokemon = {
                    id:elemento.id,
                    nombre:elemento.name,
                    imagen:elemento.sprites.front_default
                   };

                   
                  pokemons.push(pokemon);
                  this.setState({
                    pokemons
                   })
                })
            })

        })
        //El array que almaceno los pokemons inyectandoselos al state
        
    }
    render(){
      
        return (
            <>
            <h1>Peticiones AJAX</h1>
            {
                //Aqui se hace un condicional para cargar cada pokemon
                (this.state.pokemons.length <19)
                ?<h2>Cargando...</h2>
                :(this.state.pokemons.map(pokemon=><Pokemon nombre={pokemon.nombre} key={pokemon.id} imagen={pokemon.imagen}></Pokemon>))
            }
            </>
        )
    }
}
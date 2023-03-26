import React from 'react';

//Para empezar react router ofrece una manera sencilla de hacer rutas con la barra de direcciones de la web en su url dentro de cualquier componente en especifico ,este se manda a llamar con Browser Router , pero por buenas practicas de programacion se le asigna el nombre de Routes 
//Importacion de react-routes
import {BrowserRouter as Routers,Route,Routes} from 'react-router-dom'
export const ConceptosBasicos = () =>{

    return(
        <div>
        <h1>Conceptos Basicos</h1>

        <Routers>
       
        {
            //Dentro de Routers o de BrowserRouter ira Routes el cual dentro de Routes debe de ir cada ruta que tendra dentro para la pagina o dentro del componente
        }
        <Routes>
        {
            //Para cada ruta debe de ir un element que el cual debe contener los elementos JSX que debe renderizar la
        }
        <Route path='/' element={<h2>Esta es la pagina Principal</h2>}/>
        <Route path='/contacto' element={<h2>Esta seria la pagina de contacto</h2>}/>
        <Route path='/productos' element={<h2>Esta seria la pagina de productos</h2>}/>

        </Routes>
        
        </Routers>
        </div>
    )
}
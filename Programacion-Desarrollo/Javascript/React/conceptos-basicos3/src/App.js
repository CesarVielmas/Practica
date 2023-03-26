import React from 'react';
import logo from './logo.svg';
import './App.css';
//Importacion del renderizado condicional
import RenderizadoCondicional from './Components/RenderizadoCondicional';
//Importacion de el renderizado de elementos
import RenderizacionElementos from './Components/RenderizacionElementos';
//Importacion de los eventos en JSX
import {Eventos1, Eventos2} from './Components/Eventos';
//Importacion de eventos personalizados
import { EventosPersonalizados } from './Components/EventosPersonalizados';
function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
        <hr/>
        {
          //Visualizacion del componente de clase renderizado condicional 
        }
        <RenderizadoCondicional></RenderizadoCondicional>
        <hr/>
        {
          //Visualizacion del componente de clase renderizado de elementos
        }
        <RenderizacionElementos></RenderizacionElementos>
        <hr/>
        {
          //Visualizacion de el componente de clase Eventos
        }
        <Eventos1></Eventos1>
        <hr/>
        <Eventos2></Eventos2>
        <hr/>
        <EventosPersonalizados></EventosPersonalizados>
      </header>
    </div>
  );
}

export default App;

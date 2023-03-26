//Importacion de react
import React from 'react';
import logo from './logo.svg';
import './App.css';
//Importacion de la comunicacion de componentes de padre a hijo
import { ComuncacionPadreHijo } from './Componentes/ComunicacionComponentes';
//Importacion de la comunicacion de componentes de hijo a padre
import { ComunicacionHijoPadre } from './Componentes/ComunicacionComponentes';
//Importacion de el ciclo de vida de los componentes
import { CicloVida } from './Componentes/CicloVida';
//Importacion de peticiones AJAX
import { PeticionAjax } from './Componentes/PeticionAjax';
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
        <ComuncacionPadreHijo></ComuncacionPadreHijo>
        <hr/>
        <ComunicacionHijoPadre></ComunicacionHijoPadre>
        <hr/>
        <CicloVida></CicloVida>
        <hr/>
        <PeticionAjax></PeticionAjax>
      </header>
    </div>
  );
}

export default App;

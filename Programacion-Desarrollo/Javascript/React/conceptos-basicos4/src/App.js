//Importacion de React
import React from 'react';
import logo from './logo.svg';
import './App.css';
//Importacion de Referencias
import { Referencias } from './components/Referencias';
//Importacion de Formularios
import { Formularios } from './components/Formularios';
//Importacion de Implementar Css1
import { ImplementarCss1 } from './components/ImplementarCss1';
//Importacion de Implementar Css 2
import { ImplementarCss2 } from './components/ImplementarCss2';
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
        <Referencias></Referencias>
        <hr/>
        <Formularios></Formularios>
        <hr/>
        <ImplementarCss1></ImplementarCss1>
        <hr/>
        <ImplementarCss2></ImplementarCss2>
        <hr/>
      </header>
    </div>
  );
}

export default App;

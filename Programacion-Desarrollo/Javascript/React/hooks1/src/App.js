//Importacion de react
import React from 'react';
import logo from './logo.svg';
import './App.css';
//Importacion de el componente contador de UseState
import { Contador } from './Components/UseState';
//Importacion de el componente Pantalla de UseEffect
import { Pantalla } from './Components/UseEffect';
//Importacion de el componente reloj de UseEffect2
import { Reloj } from './Components/UseEffect2';
//Importacion de el componente Pokemons usando fetch asincrono y los hooks de AjaxApi
import { Pokemons } from './Components/AjaxApi';
//Importacion de el componente hookPersonalizado de hooksPersonalizados
import { HookPersonalizado } from './Components/hooksPersonalizados';
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
        <Contador></Contador>
        <hr/>
        <Pantalla></Pantalla>
        <hr/>
        <Reloj></Reloj>
        <hr/>
        <Pokemons></Pokemons>
        <hr/>
        <HookPersonalizado></HookPersonalizado>
      </header>
    </div>
  );
}

export default App;

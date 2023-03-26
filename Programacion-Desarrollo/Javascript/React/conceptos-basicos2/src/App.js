//Ahora lo que se vera sera como importar y crear componentes , en este caso el componente creado por create-react-app es el App.js , por defecto tiene este componente como parte de su estructura 

//En este caso create-react-app da la ventaja o desventaja que no es necesario importar React from 'react' , pero es una buena practica siempre importarlo en todos los componentes que se haga
import React from 'react';
import logo from './logo.svg';
import './App.css';
//importacion del Componente 1 , destructurado pues no se uso el export default
import { Componente1 } from './componentes/Componente1';
//Importacion del Componente 2 , sin destructurar , pues al mandar un default no hace falta destructurarlo
import Componente2 from './componentes/Componente2';
//Importacion del Componente 3 , sin destructurar , pues usa tambien export default igual que el componente 2
import Componente3 from './componentes/Componente3';
//Importacion de Propiedad 1 para mostrar las propiedades
import Propiedad1 from './componentes/Propiedad1';
//Importacion de Propiedad 2 para mostrar las propieades
import Propiedad2 from './componentes/Propiedad2';
//Importacion de Estado la cual mostrara como funciona las variables de estado
import Estado from './componentes/Estado';
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
        {
          //Componente 1 puesto en el html
          //Se debe poner como una etiqueta html pues es lo que crea el componente y su mayor virtud es que se puede usar infinitas veces asi reutilizando codigo
        }
        <Componente1></Componente1>
        {
          //Componente 2 puesto en el html
        }
        <Componente2></Componente2>
        {
          //Componente 3 puesto en el html
        }
        <Componente3></Componente3>
        {
          //Propiedad 1 puesto en el html
          //Es importante decir que las propiedades o props se guardan en la etiqueta dependiendo de cuantos valores se les asigne en este caso en el componente Propiedad1 se guardaron varias props con los diferentes valores posibles que pueden tomar dichas props dentro de la etiqueta del componente como si fuera la declaracion o asignacion de clase , pero en este caso se añade la propiedad
        }
        <h1>Propiedad 1</h1>

        <Propiedad1 
        numero={20} 
        cadena="Soy una cadena de el componente Propiedad1" 
        booleano = {true}
        arrays ={[1,4,6,7]} 
        objeto = {{nombre:"Cesar",matricula:"2035665"}} 

        elementoReact = {<p>Soy un elemento react y esto siendo tomado como propiedad de el componente propiedad1</p>} 

        componenteReact = {<Componente1/>}

        ></Propiedad1>
        {
          //Propiedad 2 puesto en el html
          //Es lo mismo pero en una funcion con propiedades en vez de clases
        }
        <h1>Propiedad 2</h1>
        <Propiedad2
        numero={21} 
        cadena="Soy una cadena de el componente Propiedad2" 
        booleano = {false}
        arrays ={[1,4,6,7]} 
        objeto = {{nombre:"Cesar",matricula:"2035665"}} 

        elementoReact = {<p>Soy un elemento react y esto siendo tomado como propiedad de el componente propiedad2</p>} 

        componenteReact = {<Componente3/>}
        ></Propiedad2>
        {
          //Estado en el html
        }
        <Estado></Estado>
        <br/>

      </header>
    </div>
  );
}

export default App;

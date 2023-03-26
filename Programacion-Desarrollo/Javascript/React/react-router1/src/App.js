import React from 'react';
import { Portales } from './Components/Portales';
import { ConceptosBasicos } from './Components/react-router/conceptos-basicos';
import { Paginas } from './Components/react-router/paginas';

function App() {
  return (
    <div>
      <h1>Portales</h1>
      <Portales></Portales>
      <hr/>
      <h1>Rutas</h1>
      <ConceptosBasicos></ConceptosBasicos>
      <hr/>
      <Paginas></Paginas>
      <hr/>
    </div>
  );
}

export default App;

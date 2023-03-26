import React from 'react';
import { CrudEjemplo2 } from './Components/CrudAPIConContext/CrudEjemplo2';
import PaginaConContext from './Components/PaginaConContext/Pagina';
import PaginaSinContext from './Components/PaginaSinContext/Pagina';

function App() {
  return (
   <>
   <PaginaSinContext/>
   <hr/>
  <PaginaConContext/>
  <hr/>
  <CrudEjemplo2/>
   </>
  );
}

export default App;

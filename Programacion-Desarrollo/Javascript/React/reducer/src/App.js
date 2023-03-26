import React from 'react';
import Reducer from './Components/Basico/Reducer';
import CarritoCompras from './Components/EjercicioCarritoCompras/CarritoCompras';
import { CrudEjemplo2 } from './Components/EjercicioCrudAPI/CrudEjemplo2';
import ReducersEstructurado from './Components/EstructuraDeArchivos/ReducersEstructurado';

function App() {
  return (
    <div>
    <Reducer/>
    <hr/>
    <ReducersEstructurado/>
    <hr/>
    <CarritoCompras/>
    <hr/>
    <CrudEjemplo2/>
    </div>
  );
}

export default App;

import React from 'react';
//Importacion de CrudEjemplo1 
import { CrudEjemplo1 } from './Components/Crud1Ejemplo/CrudEjemplo1';
import { CrudEjemplo2 } from './Components/Crud2Ejemplo/CrudEjemplo2';
import { SelectsAnidados } from './Components/SelectsAnidados/SelectsAnidados';
import { SongSearch } from './Components/SongSearch/SongSearch';
import { ValidacionFormulario } from './Components/ValidacionFormularios/ValidacionFormularios';
import { VentanasModal } from './Components/VentanasModal/VentanasModal';

function App() {
  return (
    <>
    <VentanasModal></VentanasModal>
    <hr/>
    <ValidacionFormulario></ValidacionFormulario>
    <hr/>
    <SelectsAnidados></SelectsAnidados>
    <hr/>
    <SongSearch></SongSearch>
    <hr/>
    <h1>Cruds Con React</h1>
    <CrudEjemplo1></CrudEjemplo1>
    <hr/>
    <CrudEjemplo2></CrudEjemplo2>
    </>

  );
}

export default App;

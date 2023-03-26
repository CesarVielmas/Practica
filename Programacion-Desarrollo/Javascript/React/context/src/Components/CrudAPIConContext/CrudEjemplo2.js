import React from 'react';
import { Formulario } from './FormularioEnvio';
import { TablaCompleta } from './TablaCompleta';
import { CrudProvider } from './Context/CrudContext';

export const CrudEjemplo2 = () =>{
   
    return(
        <>
        <h1>Crud API (Datos de Json Server) Con Context</h1>
        <CrudProvider>
            
        <Formulario></Formulario>
        <TablaCompleta></TablaCompleta>
           
        </CrudProvider>
        
        </>
    )
}
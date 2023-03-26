import React from 'react';
import {Routes,Route, BrowserRouter as Router, Navigate} from 'react-router-dom';
import { EnvioDatos1 } from './EnvioDatos1';
import { EnvioDatos2 } from './EnvioDatos2';
import { Navegacion } from './Navegacion';
import { Contacto } from './Paginas/Contacto';
import { Datos } from './Paginas/Datos';
import { Error } from './Paginas/Error';
import { Home } from './Paginas/Home';
import { Productos } from './Paginas/Productos';

export const Rutas = () =>{

    return(
        <>
        <Router>
            <h1>Navegacion</h1>
            <Navegacion/>
            <h2>Envio datos</h2>
            <EnvioDatos1/>
            <h1>Vista dependiendo de la url</h1>
            <Routes>
                <Route path='/' element = {<Home></Home>} />
                <Route path='/contacto' element={<Contacto></Contacto>}/>
                <Route path='/error' element={<Error></Error>}/>
                <Route path='/productos' element={<Productos></Productos>}/>
                {
                    //Ruta de datos donde recibira los 3 parametros nombre, edad , altura
                }
                <Route path='/datos/:nombre/:edad/:altura' element={<Datos></Datos>}/>
                {
                    //Ruta de datos ahora usando location y history
                }
                <Route path='/datos2' element={<EnvioDatos2></EnvioDatos2>}/>
                {
                    //Redirecciones de ruta 
                }
                <Route path='/contact' element={<Navigate to='/contacto'/>} />
                <Route path='/products' element={<Navigate to='/productos' />} />
            </Routes>
        </Router>
        </>
    )
}
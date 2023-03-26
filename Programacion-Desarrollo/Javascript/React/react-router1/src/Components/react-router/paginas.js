import React from 'react';
import {BrowserRouter as Router,Routes,Route} from 'react-router-dom'
import { Contacto } from './PaginasEjemplo/Contacto';
import { Home } from './PaginasEjemplo/Home';
import { Productos } from './PaginasEjemplo/Productos';
import { Error } from './PaginasEjemplo/Error';
import App from '../../App';
//Ahora se vera como exportar de manera correcta los contenidos con react-routes , desde la version V5 ya no se pueden hacer de multiples formas solo de 1 y esta seria la unica forma y la correcta de hacerlo 

export const Paginas = ()=>{
return (
    <>
    <Router>
        <Routes>
            {
                //Una cosa importante por aclarar es que antes de la V6 de react-routers se tenia que poner el atributo "exact" en cada Route obligatoriamente para que la url tuviera que ser exacta a lo que decia su path y no cometer errores , pero ahora el atributo ya no es necesario porque react-router ya lo hace de manera automatica, por otro lado error debia estar hasta abajo de todas las routes porque su path es un selector de "all" que independientemente lo que se pusiera siempre se activaria y ahora no , por lo cual a cambiado algo la version y la volvio mas sencilla
            }
            <Route element={<><Error/> <p>Pagina no encontrada</p></>} path='*'/>
            <Route element={<><Home></Home> <p>Contenido en otro lugar de home</p></>} path='/'/>
            <Route element={<><Contacto/> <p>Contenido en otro lugar de contacto</p></>} path='/contacto'/>
            <Route element={<><Productos/> <p>Contenido en otro lugar de productos</p></>} path='/productos'/>
        </Routes>
    </Router>
    </>
    )
}
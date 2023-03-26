import React from 'react';
import { BrowserRouter as Router, Routes,Route, HashRouter } from 'react-router-dom';
import { Anidaciones } from './Paginas/Anidaciones';
import { Home } from './Paginas/Home';
import { Inicio } from './Paginas/Inicio';
import { Login } from './Paginas/Login';
import { Privado } from './Paginas/Privado';
import { PrivateRoute } from './Paginas/PrivateRoute';
export const Rutas = ({children}) =>{

    return(
        <>
        <HashRouter>
            <h1>Rutas en Hash</h1>
                {children}
                <Routes>
                <Route path='/' element={<Home/>} />
            {
                //Rutas anidadas
            }
        <Route path='anidacion/*' element={<Anidaciones/>} />
        {
            //Rutas Privadas
        }
        <Route path='privado' element={<Privado/>} />
        <Route path='privado/login' element={<Login/>} />
        <Route path='privado/inicio' element={<PrivateRoute Componente={<Inicio/>} pathError="privado/login" confirmacion={true}/>} />
                </Routes>
        </HashRouter>

        {
            //Router normal
        }
        <Router>
        <h1>Rutas sin Hash</h1>
            {children}
        <Routes>
        <Route path='/' element={<Home/>} />
            {
                //Rutas anidadas
            }
        <Route path='anidacion/*' element={<Anidaciones/>} />
        {
            //Rutas Privadas
        }
        <Route path='privado' element={<Privado/>} />
        <Route path='privado/login' element={<Login/>} />
        <Route path='privado/inicio' element={<PrivateRoute Componente={<Inicio/>} pathError="privado/login" confirmacion={true}/>} />
        

        </Routes>

        </Router>
        </>
    )
}
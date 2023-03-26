import React from 'react';
import { Link } from 'react-router-dom';

export const Privado = () =>{

    return(
        <>
        <h3>Rutas Privadas</h3>
        <nav>
            <Link to="login">Login</Link>
            <Link to="inicio">Inicio</Link>

        </nav>
        </>
    )
}
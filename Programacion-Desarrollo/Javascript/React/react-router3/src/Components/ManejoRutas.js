import React from 'react';
import { Link } from 'react-router-dom';

export const ManejoRutas = () =>{
        return(
            <>
            <nav>
                <Link to="/">Home</Link>
                <Link to="anidacion/*">Anidaciones</Link>
                <Link to="privado">Rutas Privadas</Link>
            </nav>
            </>
        )
}
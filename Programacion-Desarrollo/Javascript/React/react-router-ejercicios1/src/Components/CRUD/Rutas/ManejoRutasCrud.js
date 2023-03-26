import React from 'react';
import { Link } from 'react-router-dom';

export const RutasCrud = () =>{

    return(
        <header>
                <nav>
                    <h2>Crud Con Rutas</h2>
                    <Link to='formulario/agregar'>Agregar</Link>
                    <br/>
                    <Link to='formulario/editar'>Editar</Link>
                    <br/>
                    <Link to='/'>Ver</Link>
                </nav>
            </header>
    )
}
import React from 'react';
import { Link } from 'react-router-dom';
export const EnvioDatos1 = () =>
{
    //En el to , se puede ver todo el envio de datos , con el nombre , edad y altura , deben llenarse los 3 aunque sean vacios
    return(
        <nav>
            {
                //Envio de datos con to usando useParams
            }
            <ul>
            <Link to='/datos/Cesar/0/0'>Enviar Nombre</Link>
            <Link to='/datos/""/20/0'>Enviar Edad</Link>
            <Link to='/datos/""/0/168'>Enviar Altura</Link>
            </ul>
           
        </nav>
    )
}
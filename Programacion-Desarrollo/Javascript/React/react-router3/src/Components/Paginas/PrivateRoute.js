import React from 'react';
import { Navigate } from 'react-router-dom';

export const PrivateRoute = ({confirmacion,Componente,pathError}) =>{

    return(
        <>
        {
            (confirmacion)
            ?Componente
            :<Navigate to={`/${pathError}`}/>
        }
        </>
    )
}
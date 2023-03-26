import React from 'react';
import { Biografia } from './Biografia';
import { Letra } from './Letra';

export const Detalles = () =>{
    
    return(
        <>
        <table>
            <thead>
                <tr>
                    <td>
                    <Biografia></Biografia>
                    </td>
                    <td>
                        <Letra></Letra>
                    </td>
                </tr>
            </thead>
        </table>
        </>
    )
}
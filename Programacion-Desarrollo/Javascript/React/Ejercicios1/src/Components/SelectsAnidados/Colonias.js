import React from 'react';

export const Colonias = ({colonias}) =>{

    return(
        <>
        <select>
            {colonias.map(colonia =><option value={colonia}>{colonia}</option>)}
        </select>
        </>
    )
}
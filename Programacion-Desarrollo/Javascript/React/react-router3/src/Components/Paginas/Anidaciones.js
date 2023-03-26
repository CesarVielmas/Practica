import React from 'react';
import { Link, Route, Routes, useParams } from 'react-router-dom';

const Paginas = () =>{
    let params = useParams();
    console.log(params);
    return(
        <>
        <h2>Pagina de {params.pagina}</h2>
        </>
    )
}
export const Anidaciones = () =>{
   
    return(
        <>
        <div>
            <h1>Anidaciones React Router</h1>

            <nav>
                <Link to="Pagina1">Pagina 1</Link>
                <Link to="Pagina2">Pagina 2</Link>
                <Link to="Pagina3">Pagina 3</Link>
                <Link to="Pagina4">Pagina 4</Link>
            </nav>
        </div>
        <Routes>
            <Route path=':pagina' element={<Paginas/>} />
        </Routes>
        </>
        
    )
}
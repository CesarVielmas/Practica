import React, { useState } from 'react';
const formInit = {
    artista: "",
    cancion:""
}
export const Formulario = ({datosEnviados}) =>{
    const [form,setForm] = useState(formInit);

    const handlerChange = (e) =>{
        setForm({
            ...form,
            [e.target.id]:e.target.value
        })
    }

    const handlerSubmit = (e) =>{
        e.preventDefault();

        alert(`Datos Enviados\nArtista:${form.artista}\nCancion:${form.cancion}`);
        datosEnviados(form);
        setForm(formInit);
    }

    return(
        <>
        <h2>Formulario</h2>
        <form onSubmit={handlerSubmit}>
            <label htmlFor='artista'>Nombre Del Artista</label>
            <br/>
            <input type="text" id='artista' value={form.artista} onChange={handlerChange}/>
            <br/>
            <label htmlFor='cancion'>Nombre De La Cancion</label>
            <br/>
            <input type="text" id='cancion' value={form.cancion} onChange={handlerChange}/>
            <br/>
            <br/>
            <input type="submit" value="Enviar"/>
        </form>
        </>
    )
}
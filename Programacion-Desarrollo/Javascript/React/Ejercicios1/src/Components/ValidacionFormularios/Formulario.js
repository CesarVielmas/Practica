import React from 'react';
import { useValidacion } from './hooks/useValidacion';

const valorInicial = {
    nombre:"",
    correo:"",
    contrasenia:"",
    confirmarContrasenia:""
} 
const valorCorrecto =[{
    nombre:true,
    correo:true,
    contrasenia:true,
    confirmarContrasenia:true
}]
export const Formulario = () =>{
    const {form,correcto,handlerChange,handlerSubmit,error} = useValidacion(valorInicial,valorCorrecto);

    return(
        <form onSubmit={handlerSubmit}>
            <input type="text" name='nombre' value={form.nombre} onChange={handlerChange}placeholder='Ingrese su nombre' required/>
            {(correcto.nombre)?<br/>:<p style={{backgroundColor:"red",color:"whitesmoke"}}>{error.nombre}</p>}
            <br/>

            <input type="email" name='correo' value={form.correo} onChange={handlerChange} placeholder='Ingrese su correo' required/>
            {(correcto.correo)?<br/>:<p style={{backgroundColor:"red",color:"whitesmoke"}}>{error.correo}</p>}
            <br/>

            <input type="password" name='contrasenia' value={form.contrasenia} onChange={handlerChange}placeholder='Ingrese su contraseña' required/>
            {(correcto.contrasenia)?<br/>:<p style={{backgroundColor:"red",color:"whitesmoke"}}>{error.contrasenia}</p>}
            <br/>

            <input type="password" name='confirmarContrasenia' value={form.confirmarContrasenia} onChange={handlerChange} placeholder='Confirmar contraseña' required/>
            {(correcto.confirmarContrasenia)?<br/>:<p style={{backgroundColor:"red",color:"whitesmoke"}}>{error.confirmarContrasenia}</p>}
            <br/>
            <input type="submit" value="Enviar"/>
        </form>
    )
}
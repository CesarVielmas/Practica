import React, { useEffect, useState } from 'react'
import './CrearUsuario.css';
export default function CrearUsuario({postearDatos,edit,datosForm,editarDatos,notAcceptEdit}) {
    const [name, setName] = useState(datosForm.nombre);
    const [email, setEmail] = useState(datosForm.correo);
    const [domicilio, setDomicilio] = useState(datosForm.domicilio);
    const [edad, setEdad] = useState(datosForm.edad);
    const [curp, setCurp] = useState(datosForm.curp);
    const changeName = (e)=> setName(e.target.value);
    const changeDomicilio = (e)=> setDomicilio(e.target.value);
    const changeEmail = (e)=> setEmail(e.target.value);
    const changeEdad = (e)=> setEdad(e.target.value);
    const changeCurp = (e)=> setCurp(e.target.value);
    useEffect(() => {
      setName(datosForm.nombre);
      setEmail(datosForm.correo);
      setDomicilio(datosForm.domicilio);
      setEdad(datosForm.edad);
      setCurp(datosForm.curp);
    }, [datosForm])
    
  return (
    <div className='crearUsuario'>
        <h2>Crear Usuario</h2>
        <input type='text' placeholder='nombre...' value={name} onChange={changeName}/>
        <input type='text' placeholder='correo...' value={email} onChange={changeEmail}/>
        <input type='text' placeholder='domicilio...' value={domicilio} onChange={changeDomicilio}/>
        <input type='number' placeholder='edad...' value={edad} onChange={changeEdad}/>
        <input type='text' placeholder='curp...' value={curp} onChange={changeCurp}/>
        {
            edit
            ?<><button onClick={()=>editarDatos(datosForm.id,{
                id:datosForm.id,
                nombre:name,
                correo:email,
                domicilio,
                edad,
                curp
            })}>Editar</button> <button onClick={notAcceptEdit}>No Editar</button></>
            :<button onClick={()=>postearDatos({
                nombre:name,
                correo:email,
                domicilio,
                edad,
                curp
            })}>Crear</button>
        }
        
    </div>
  )
}

import React, { useEffect, useState } from 'react'
import CrearUsuario from './CrearUsuario'
import TablaUsuarios from './TablaUsuarios'
const editData = {
    id:0,
    nombre:"",
    correo:"",
    domicilio:"",
    edad:0,
    curp:""
}
export default function MenuPrincipal() {
    const [datos, setDatos] = useState(null);
    const [datosForm, setDatosForm] = useState(editData);
    const [edit, setEdit] = useState(false);
    
    useEffect(() => {
      fetch("http://localhost:5030/api/usuarios").then(datos=>datos.json()).then(
        datosObtenidos => setDatos(datosObtenidos)
      );
    }, [datos])
    const postearDatos = (usuario) =>{
        fetch("http://localhost:5030/api/usuarios",{
            method:"POST",
            body: JSON.stringify(usuario),// Con cuerpo
            headers: {
                'Content-Type': 'application/json',
            },
        })

    }
    const editarDatos = (id,nuevoUsuario)=>{
        console.log(id,nuevoUsuario);
        fetch(`http://localhost:5030/api/usuarios/${id}`,{
            method:"PUT",
            body: JSON.stringify(nuevoUsuario),// Con cuerpo
            headers: {
                'Content-Type': 'application/json',
            },
        })
    }
    const acceptEdit = (id)=>{
        datos.forEach(elemento => {
            if (elemento.id === id) {
                setDatosForm({
                    ...datosForm,
                    id:elemento.id,
                    nombre:elemento.nombre,
                    domicilio:elemento.domicilio,
                    edad:elemento.edad,
                    correo:elemento.correo,
                    curp:elemento.curp
                });
            }
        });
        setEdit(true);
        console.log(datosForm);
    }
    const notAcceptEdit = ()=> {
        setDatosForm(editData);
        setEdit(false);
    }
    const eliminarDato = (id)=>{
        fetch(`http://localhost:5030/api/usuarios/${id}`,{
            method:"DELETE"
        });

    }
  return (
    <>
    {
        datos === null
        ?""
        :<>
        <CrearUsuario postearDatos={postearDatos} edit={edit} datosForm={datosForm} notAcceptEdit ={notAcceptEdit} editarDatos={editarDatos}/>
        <TablaUsuarios datos={datos} eliminarDato={eliminarDato} acceptEdit={acceptEdit}/>
        </>
    }
   
    </>
  )
}

import React, { useState } from 'react';
import {Formulario} from './FormularioEnvio';
import { TablaCompleta } from './TablaCompleta';
const empleados =[
    {
        id:0,
        nombre:"Cesar Alejandro Vielmas Salais",
        area:"Abogado",
        sueldo:2600,
        contratado:true
    },
    {
        id:1,
        nombre:"Candy Jimenez Lopez Doriga",
        area:"Asistente",
        sueldo:1500,
        contratado:true
    },
    {
        id:2,
        nombre:"Pepito Flores Madrid",
        area:"Empleado",
        sueldo:1000,
        contratado:false
    },
    {
        id:3,
        nombre:"Maria Javier Agustina Dominguez",
        area:"Empleado",
        sueldo:1200,
        contratado:false
    },
    {
        id:4,
        nombre:"Juan Checo Perez Guzman",
        area:"Derechos Humanos",
        sueldo:2000,
        contratado:true
    }
] 

//Crud de ejemplo 1 el cual usara una api falsa con un array que ya contendra los datos a imprimir y modificar
export const CrudEjemplo1 = () =>{
    const [datos,setDatos] = useState(empleados);
    const [editar,setEditar] = useState({});
   
    const subirDatos = (empleado)=>{
        empleado.id = datos.length;
        setDatos([
            ...datos,
            empleado
        ]);
    }
    const actualizarDatos=(empleado)=>{
        let nuevoDato = [];
        datos.forEach((el,index)=>{

            if (el.id===empleado.id) {
                el.nombre = empleado.nombre;
                el.sueldo = empleado.sueldo;
                el.area = empleado.area;
                el.contratado = empleado.contratado;
               
            }
            nuevoDato[index] = el;
        })
        setDatos(nuevoDato);
    }
    const eliminarDatos = (id) =>{
        let nuevoDato = [];
        datos.forEach((el,index)=>{
            if (el.id===id) {
               
            }
            else{
                nuevoDato[index] = el;
            }
        })
        setDatos(nuevoDato);
    }
    const obtenerParaEditar = (empleado) =>{
       setEditar({
        nombre:empleado.nombre,
        sueldo:empleado.sueldo,
        contratado:empleado.contrato,
        area:empleado.area,
        id:empleado.id
       });
       
    }
    return(
        <>
        <h2>Crud De Ejemplo 1 (Datos de una API falsa)</h2>
        <Formulario subirDatos={subirDatos} actualizarDatos={actualizarDatos} eliminarDatos={eliminarDatos} datosEdit ={editar}></Formulario>
        <TablaCompleta empleados={datos} obtenerParaEditar={obtenerParaEditar} eliminarDatos={eliminarDatos}></TablaCompleta>
        </>
    );

}
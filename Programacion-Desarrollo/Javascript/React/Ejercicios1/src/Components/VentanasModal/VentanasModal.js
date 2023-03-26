import React, { useState } from 'react';
import { Ventana } from './Vetana';

const cambioInit = {
    modal1:false,
    modal2:false,
    modal3:false
}
export const VentanasModal = () =>{
    const [cambio,setCambio] = useState(cambioInit);

    const handlerClick = (e) =>{
        if (e.target.id==="modal1"&&cambio.modal1===false) {
            setCambio({
                ...cambio,
                modal1:true
            });

        }
        if (e.target.id==="modal2"&&cambio.modal2===false) {
            setCambio({
                ...cambio,
                modal2:true
            });
           
        }
        if (e.target.id==="modal3"&&cambio.modal3===false) {
            setCambio({
                ...cambio,
                modal3:true
            });
        }
        if (e.target.id==="ventana"&&cambio.modal1===true) {
            setCambio({
                ...cambio,
                modal1:false
            });
        }
        if (e.target.id==="ventana"&&cambio.modal2===true) {
            setCambio({
                ...cambio,
                modal2:false
            });
        }
        if (e.target.id==="ventana"&&cambio.modal3===true) {
            setCambio({
                ...cambio,
                modal3:false
            });
        }
    }
    return(
        <>
        <h1>Ventanas Modal</h1>
        <br/>
        <button onClick={handlerClick} id="modal1">Activar Ventana Modal 1</button>
        <br/>
        <button onClick={handlerClick} id="modal2">Activar Ventana Modal 2</button>
        <br/>
        <button onClick={handlerClick} id="modal3">Activar Ventana Modal 3</button>

        <Ventana handlerClick ={handlerClick} cambio={cambio.modal1}>
            {
                //Asignando los valores a children pues es lo que contiene dentro de ventana
            }
            <h2>Ventana modal 1</h2>
            <h2>Perros 1</h2>
            <img src='https://imgs.search.brave.com/oyrNhCP5BbckTa1H5wpHNGAy6Lwk8_P8BsZYVl5w4n4/rs:fit:764:225:1/g:ce/aHR0cHM6Ly90c2Uz/Lm1tLmJpbmcubmV0/L3RoP2lkPU9JUC5X/dW9sLTVQbW9SbndH/S2dLcUJlSWt3SGFF/bSZwaWQ9QXBp' alt='perro' />
        </Ventana>

        <Ventana handlerClick ={handlerClick} cambio={cambio.modal2}>
            {
                //Asignando los valores a children pues es lo que contiene dentro de ventana
            }
            <h2>Ventana modal 2</h2>
            <h2>Perros 2</h2>
            <img src='https://imgs.search.brave.com/mc4kYKIY2H2NSCsMGi9twER5n9HrvDfQmnjT_KLMki0/rs:fit:474:417:1/g:ce/aHR0cHM6Ly93d3cu/cGV0ZGFybGluZy5j/b20vd3AtY29udGVu/dC91cGxvYWRzLzIw/MjAvMTEvcmF6YXMt/ZGUtcGVycm9zLmpw/Zw' alt='perro' />
        </Ventana>

        <Ventana handlerClick ={handlerClick} cambio={cambio.modal3}>
            {
                //Asignando los valores a children pues es lo que contiene dentro de ventana
            }
            <h2>Ventana modal 3</h2>
            <h2>Perros 3</h2>
            <img src='https://imgs.search.brave.com/L1NuHEjFceTl23FJeeJX9KD3wRNY3qAZfj0z6KcruUw/rs:fit:524:225:1/g:ce/aHR0cHM6Ly90c2Ux/Lm1tLmJpbmcubmV0/L3RoP2lkPU9JUC5p/Qm9YWGppT2RrYkNj/SGx2RkZ1aEJBSGFH/cyZwaWQ9QXBp' alt='perro' />
        </Ventana>
       
        </>
    )
}
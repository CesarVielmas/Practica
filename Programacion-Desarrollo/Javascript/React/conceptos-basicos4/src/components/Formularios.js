//Importacion de React con destructuracion de useState de los hooks pues sera usado
import React,{useState} from 'react';

//Para implementar de manera correcta los formlarios en React debe de poner en cada input guardarlo en el state del programa o varios states , se veran 2 formas , para hacer los formularios en React


//Primera Opcion (BASICO)
//Componente de funcion para los formularios (formulario pequeño y basico)
/*export function Formularios(){
    //El use state para cada input del formulario
    let [nombre,setNombre] = useState(""),
    [terminos,setTerminos] = useState(false),
    [bebida,setBebida] = useState(""),
    [genero,setGenero] = useState("");

    //Funcion para el submit
    const handlerSubmit = (e)=>{
        e.preventDefault();
        alert(`Datos Enviados\nNombre: ${nombre}\nTerminos Aceptados: ${terminos}\nBebida Favorita: ${bebida}\nGenero Seleccionado: ${genero}`)
    }
    return(
        //En cada input debe haber un onChange pues el state del valor del input debe cambiar dependiendo lo que ingrese el usuario
        <>
        <h1>Formularios en React</h1>
        <form onSubmit={handlerSubmit}>
            <label htmlFor='nombre'>Ingrese su nombre</label>
            <input type="text" id='nombre' defaultValue="Ingrese un nombre" onChange={(e)=>setNombre(e.target.value)}/>

            <br/>
            <label htmlFor='checkbox'>Acepte los terminos y condiciones</label>
            <input type="checkbox" id='checkbox' onChange={(e)=>setTerminos(e.target.checked)}/>
            <br/>
            <h2>Seleccione alguna bebida</h2>

            <label htmlFor='pepsi'>Pepsi</label>
            <input type="radio" name='coca' value="Pepsi" id='pepsi' onChange={(e)=>setBebida(e.target.value)} />
            <br/>
            <label htmlFor='cola'>Coca Cola</label>
            <input type="radio" name='coca' value="Coca Cola" id='cola' onChange={(e)=>setBebida(e.target.value)} />
            <br/>
            <label htmlFor='mirinda'>Mirinda</label>
            <input type="radio" name='coca' value="Mirinda" id='mirinda' onChange={(e)=>setBebida(e.target.value)} />
            <br/>
            <label htmlFor='bigCola'>Big Cola</label>
            <input type="radio" name='coca' value="Big Cola" id='bigCola' onChange={(e)=>setBebida(e.target.value)} />
            <br/>
            
            <h2>Seleccione un genero</h2>
            <select onChange={(e)=> setGenero(e.target.value)}>
                <option value="Masculino">Masculino</option>
                <option value="Femenino">Femenino</option>
                <option value="Otro">Otro</option>
            </select>
            <br/>
            <input type="submit"/>
        </form>
        </>
    )
    
}
*/
//Segunda opcion (Un poco mas avanzado)
export function Formularios(){
    //Ahora sera con un solo state para guardar tantos datos sean, por lo cual se guardaran en un objeto
    const [datos,setDatos] = useState({});
    //Funcion submit
    const handlerSubmit = (e) =>{
        e.preventDefault();
        alert(`Datos Enviados\nNombre: ${datos.nombre}\nTerminos Aceptados: ${datos.checkbox}\nBebida Favorita: ${datos.coca}\nGenero Seleccionado: ${datos.Genero}`)
    }
    return(
        <>
        <h1>Formularios en React</h1>
        <form onSubmit={handlerSubmit}>
            <label htmlFor='nombre'>Ingrese su nombre</label>
            <input type="text" id='nombre' defaultValue="Ingrese un nombre" onChange={(e)=>setDatos({
             ...datos,
             [e.target.id]:e.target.value   
            })}/>

            <br/>
            <label htmlFor='checkbox'>Acepte los terminos y condiciones</label>
            <input type="checkbox" id='checkbox' onChange={(e)=>setDatos({
             ...datos,
             [e.target.id]:e.target.checked   
            })}/>
            <br/>
            <h2>Seleccione alguna bebida</h2>

            <label htmlFor='pepsi'>Pepsi</label>
            <input type="radio" name='coca' value="Pepsi" id='pepsi' onChange={(e)=>setDatos({
             ...datos,
             [e.target.name]:e.target.value   
            })} />
            <br/>
            <label htmlFor='cola'>Coca Cola</label>
            <input type="radio" name='coca' value="Coca Cola" id='cola'onChange={(e)=>setDatos({
             ...datos,
             [e.target.name]:e.target.value   
            })}/>
            <br/>
            <label htmlFor='mirinda'>Mirinda</label>
            <input type="radio" name='coca' value="Mirinda" id='mirinda' onChange={(e)=>setDatos({
             ...datos,
             [e.target.name]:e.target.value   
            })}/>
            <br/>
            <label htmlFor='bigCola'>Big Cola</label>
            <input type="radio" name='coca' value="Big Cola" id='bigCola'onChange={(e)=>setDatos({
             ...datos,
             [e.target.name]:e.target.value   
            })} />
            <br/>
            
            <h2>Seleccione un genero</h2>
            <select name='Genero' onChange={(e)=>setDatos({
             ...datos,
             [e.target.name]:e.target.value   
            })}>
                <option value="Masculino">Masculino</option>
                <option value="Femenino">Femenino</option>
                <option value="Otro">Otro</option>
            </select>
            <br/>
            <input type="submit"/>
        </form>
        </>
    )
}
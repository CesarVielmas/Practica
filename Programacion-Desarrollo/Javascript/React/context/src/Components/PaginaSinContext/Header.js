import React from 'react'

export default function Header({tema,cambio,cambioLenguaje,idioma,cambioAuth,auth}) {
  return (
    <header className={tema}>
        <h2>{idioma.headerTheme}</h2>
        <label htmlFor='tema'>{idioma.headerLabel1}</label>
        <input type="radio" value="light" name='tema' id='tema' onChange={cambio}/>
        <br/>
        <label htmlFor='tema1'>{idioma.headerLabel2}</label>
        <input type="radio" value="dark" name='tema' id='tema1' onChange={cambio}/>
        <h2>{idioma.headerLenguages}</h2>
        <br/>
        <select onChange={cambioLenguaje}>
        <option value="es">En</option>
        <option value="en">Es</option>
        </select>

        {
          auth
          ?<button onClick={cambioAuth} id='log'>{idioma.button1}</button>
          :<button onClick={cambioAuth} id='sign'>{idioma.button2}</button>
        }
    </header>
  )
}

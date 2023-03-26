import React, { useContext } from 'react'
import LanguageContext from './Context/LanguageContext';
import SesionContext from './Context/Sesion';
import ThemeContext from './Context/ThemeContext'

export default function Header() {
    //Use context para obtener de ThemeContext dichos valores
    const {theme,handlerTheme} = useContext(ThemeContext);
    const {auth,handlerAuth} = useContext(SesionContext);
    const {traduccion,handlerLenguaje} = useContext(LanguageContext);

  return (
    <header className={theme} >
       <h2>{traduccion.headerTheme}</h2>
        <label htmlFor='temaContext'>{traduccion.headerLabel1}</label>
        <input type="radio" value="light" name='temaContext' id='temaContext' onChange={handlerTheme}/>
        <br/>
        <label htmlFor='tema1Context'>{traduccion.headerLabel2}</label>
        <input type="radio" value="dark" name='temaContext' id='tema1Context' onChange={handlerTheme}/>
        <h2>{traduccion.headerLenguages}</h2>
        <br/>
        <select onChange={handlerLenguaje}>
        <option value="es">En</option>
        <option value="en">Es</option>
        </select>

        {
          auth
          ?<button onClick={handlerAuth} id='log'>{traduccion.button1}</button>
          :<button onClick={handlerAuth} id='sign'>{traduccion.button2}</button>
        }
    </header>
  )
}

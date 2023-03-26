import React, { useContext } from 'react'
import LanguageContext from './Context/LanguageContext';
import SesionContext from './Context/Sesion';
import ThemeContext from './Context/ThemeContext'

export default function Main() {
    //Use context para obtener de ThemeContext dichos valores
    const {theme} = useContext(ThemeContext);
    const {auth} = useContext(SesionContext);
    const {traduccion} = useContext(LanguageContext);

  return (
    <main className={theme}>
      {auth?<h2>{traduccion.main2H2}</h2>:<h2>{traduccion.main1H2}</h2>}    
        <p>{traduccion.mainP}</p>
    </main>
  )
}

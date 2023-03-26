import React, { useContext } from 'react'
import LanguageContext from './Context/LanguageContext';
import ThemeContext from './Context/ThemeContext'

export default function Footer() {
   //Use context para obtener de ThemeContext dichos valores
   const {theme} = useContext(ThemeContext);
   const {traduccion} = useContext(LanguageContext);

  return (
    <footer className={theme}>
        <p>{traduccion.footerP}</p>
    </footer>
  )
}

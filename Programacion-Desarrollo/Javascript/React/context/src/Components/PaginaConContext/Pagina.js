import React from 'react'
import { LanguageProvider } from './Context/LanguageContext'
import { SesionProvider } from './Context/Sesion'
import { ThemeProvider } from './Context/ThemeContext'
import Footer from './Footer'
import Header from './Header'
import Main from './Main'

export default function PaginaConContext() {

  return (
    <>
    <h1>Pagina Con Context</h1>
    {
        //Ahora para enrollar a los componentes que tendran dicha variable globar deben de encerrarse en su dicho provider
    }
    <SesionProvider>
    <LanguageProvider>
    <ThemeProvider>
        
    <Header/>
    <Main/>
    <Footer/>

    </ThemeProvider>
    </LanguageProvider>
    </SesionProvider>
       </>
  )
}

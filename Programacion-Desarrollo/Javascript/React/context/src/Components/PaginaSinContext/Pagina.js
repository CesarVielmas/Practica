import React, { useState } from 'react';
import Footer from './Footer';
import Header from './Header';
import Main from './Main';

const inicioTema = "light";
const inicioIdioma = "es";
const diccionarioLeng = {
    en:{
        headerTheme:"Select the theme",
        headerLabel1:"Light",
        headerLabel2:"Dark",
        headerLenguages:"Select the language",
        main1H2:"Welcome to the page guest",
        main2H2:"Welcome to the page user",
        mainP:"Welcome to the new page making without context",
        footerP:"Footer of page",
        button1:"Logout",
        button2:"Sign In"
    },
    es:{
        headerTheme:"Selecciona el tema",
        headerLabel1:"Claro",
        headerLabel2:"Oscuro",
        headerLenguages:"Selecciona el lenguaje",
        main1H2:"Bienvenido a la pagina invitado",
        main2H2:"Bienvenido a la pagina usuario",
        mainP:"Bienvenido a esta nueva pagina hecha sin context",
        footerP:"Pie de pagina",
        button1:"Cerrar Sesion",
        button2:"Iniciar Sesion"
    }
}
const inicioAuth = false;

export default function PaginaSinContext() {
    const [tema, setTema] = useState(inicioTema);
    const [idioma, setIdioma] = useState(inicioIdioma);
    const [traduccion, setTraduccion] = useState(diccionarioLeng[idioma]);
    const [auth, setAuth] = useState(inicioAuth);

    const handlerTema = (e) => setTema(e.target.value);
    const handlerLenguaje = (e) =>{
        console.log(e.target.value);
        setIdioma(e.target.value);
        setTraduccion(diccionarioLeng[idioma]);
    }
    const handlerAuth = (e) =>{
        if (auth)setAuth(false);
        else setAuth(true);
    }
  return (
    <>
    <h1>Pagina hecha sin context</h1>
    <Header tema={tema} cambio={handlerTema} cambioLenguaje={handlerLenguaje} idioma={traduccion} cambioAuth={handlerAuth} auth={auth}/>
    <Main tema={tema} idioma={traduccion} auth={auth}/>
    <Footer tema={tema} idioma={traduccion}/>
    </>
  )
}

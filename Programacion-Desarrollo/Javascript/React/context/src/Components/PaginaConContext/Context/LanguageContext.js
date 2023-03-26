import { createContext, useState } from "react";

//Lo mismo que ThemeContext es la misma logica
const LanguageContext = createContext();

const inicioIdioma = "es";
const diccionarioLeng = {
    en:{
        headerTheme:"Select the theme",
        headerLabel1:"Light",
        headerLabel2:"Dark",
        headerLenguages:"Select the language",
        main1H2:"Welcome to the page guest",
        main2H2:"Welcome to the page user",
        mainP:"Welcome to the new page making with context",
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
        mainP:"Bienvenido a esta nueva pagina hecha con context",
        footerP:"Pie de pagina",
        button1:"Cerrar Sesion",
        button2:"Iniciar Sesion"
    }
}

export const LanguageProvider = ({children}) =>{

    const [idioma, setIdioma] = useState(inicioIdioma);
    const [traduccion, setTraduccion] = useState(diccionarioLeng[idioma]);
    
    const handlerLenguaje = (e) =>{
        console.log(e.target.value);
        setIdioma(e.target.value);
        setTraduccion(diccionarioLeng[idioma]);
    }

    let data = {traduccion,handlerLenguaje};

    return<LanguageContext.Provider value={data}>{children}</LanguageContext.Provider>
}

export default LanguageContext;
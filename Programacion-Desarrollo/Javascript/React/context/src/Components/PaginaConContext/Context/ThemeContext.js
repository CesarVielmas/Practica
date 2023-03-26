import { createContext, useState } from "react";


const ThemeContext = createContext();
//Elementos para la logica del state
const initTheme = "light";
//Cada context debe de tener su dicho provider , antes tambien necesitaba de un recargable , pero con la llegada de los hooks ya no es necesario ya que se hace dentro de los elementos on useContext
export const ThemeProvider = ({children}) =>{
    //Dentro de el provider debe de ir toda la logica como el estado o las funciones las cuales se pueden pasar
    const [theme, setTheme] = useState(initTheme);

    //Funcion para cambiar su valor que ira en el header
    const handlerTheme = (e) =>setTheme(e.target.value);

    let data = {theme,handlerTheme};
    //Ahora este debe de retornar el contexto pero su provider y casi siempre debe de tener su propiedad child el cual trae de ThemeProvider para decir que componentes tendran dichos estados heredados

    //Por otro lado los datos deben de ir en value , pues estos se los pasara a los componentes children para que sean globales a esos componentes children
    return <ThemeContext.Provider value={data}>{children}</ThemeContext.Provider>
}



export default ThemeContext;
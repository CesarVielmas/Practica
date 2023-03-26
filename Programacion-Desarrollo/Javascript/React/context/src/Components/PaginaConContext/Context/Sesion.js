import { createContext, useState } from "react";


 const SesionContext = createContext();

 const inicioAuth = false;
 
export const SesionProvider = ({children}) =>{
    const [auth, setAuth] = useState(inicioAuth);

    const handlerAuth = (e) =>{
        if (auth)setAuth(false);
        else setAuth(true);
    }

    let data = {auth,handlerAuth};
    return<SesionContext.Provider value={data}>{children}</SesionContext.Provider>
}
export default SesionContext;
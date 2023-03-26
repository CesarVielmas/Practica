//Importacion de react 
import React from "react";

//Haciendo lo mismo que propiedad 1 pero con las props o propiedades en las funciones
function Propiedad2(props){
    return(
        <>
        {
            //Aqui se añadiran todas las propiedades que puede aceptar al igual que las clases soportan las mismas propiedades en las props solo que aqui solo se vera que es mas simple que usar clases
        }
        <a>{props.numero}</a>
        <a>{props.cadena}</a>
        <a>{props.booleano?"El valor es true":"El valor es false"}</a>
        <a>{props.arrays}</a>
        <a>{props.objeto.matricula}</a>
        <a>{props.elementoReact}</a>
        <a>{props.componenteReact}</a>
        </>
    )
}
//Propiedades por defecto
Propiedad2.defaultProps = {
    propiedadPorDefecto: "Valor por defecto añadido a propiedad 2"
}
//Exportamos por defecto para la importacion
export default Propiedad2;
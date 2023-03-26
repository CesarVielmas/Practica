//Importacion de React necesaria para cualquier componente
import React from "react";

//Para las propiedades es importante decir que pueden ir en cualquier manera de creacion de componente como las anteriores 3 sin embargo solo se haran 2 ejemplos para clases y otra para funciones en react para que quede claro

//Las propiedades son todas aquellas que se le agregan a la clase del componente creado o la funcion del componente creado , pueden ser añadidas de manera default o por alguna importacion de el componente en algun otro lado , estas mismas se guardan en un objeto llamado props el cual se vera como usarlo en las clases y en las funciones

//Ejemplo de un componente con clases en react usando props
class Propiedad1 extends React.Component{
    //Para poder usar las props en los objetos primero que nada se debe declarar en el constructor de la clase
    constructor(props){
        //Despues para que la clase hija en este caso Propiedad1 pueda usar la propiedad del padre la cual es la clase Component de React entonces se hace con super(props) pues obtiene el valor de las props
        super (props);
    }
    //funcion render indispensable para mostrar en pantalla la etiqueta
    render(){
        //Return para mostrar lo que se desea en el componente
        //En este caso el valor de propiedadPorDefecto el cual fue descrito en defaultProps de Propiedad1 para ello es importante siempre saber que se debe usar el this para llamar a las props en las clases
        return (
                //Elemento padre necesario por la sintaxis de JSX
            <>
            {
                //Mandando la propiedad por defecto en la etiqueta html <a/>
                
            }
            <a>{this.props.propiedadPorDefecto}</a>
            {

            //Mandando las propiedades que se pueden aceptar por el objeto props de React en etiquetas de ancla <a/>
            //numero
            //cadena
            //booleano
            //arrays
            //objetos (importante JSX no puede imprimir el objeto como tal , solo sus propiedades, sin embargo props si obtiene todo el objeto)
            //funciones
            //elementos de React 
            //componentes de React
            }
            <a>{this.props.numero}</a>
            <a>{this.props.cadena}</a>
            <a>{this.props.booleano?"Es un true":"Es un false"}</a>
            <a>{this.props.arrays}</a>
            <a>{this.props.objeto.nombre}</a>
            <a>{this.props.elementoReact}</a>
            <i>{this.props.componenteReact}</i>
           
            </>
            
        );
    }
}

//Ahora una cosa importante de los props es que se puede tambien instanciar propiedades por default o por defecto a un componente de clase o funcion con la llamada a defaultProps la cual es un objeto y es en la que se guardan las propiedades por defecto del componente
//Ejemplo
Propiedad1.defaultProps = {
    propiedadPorDefecto: "Valor Por defecto"
}
//Exportamos el componente , en este caso por default
export default Propiedad1;
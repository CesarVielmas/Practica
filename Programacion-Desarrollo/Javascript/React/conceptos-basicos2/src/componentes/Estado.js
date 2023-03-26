//Importacion de la libreria de React
import React from "react";
//Una cosa no menos importante es que antes JSX o React lo que hacia para las funciones y modificar un estado que no tenian era ponerlas dentro de una clase de componentes y asignarle el valor de estado que podia cambiar la cual lo que hacia es que tambien hacia el renderizado igual que la clase de componente en las funciones de componentes
//Ejemplo
function EstadoFuncion(props){
    return(
        <>
        <h1>Renderizacion del componente de funcion</h1>
        <h2>{props.estadoHijo}</h2>
        </>
    );
}

//Ahora lo que se vera es el estado , el estado en los componentes , es una variable que lo que hace es que cada que se cambia su valor no directamente si no indirectamente , entonces vuelve a renderizar el componente eso es lo que tiene de diferencia a comparacion de las variables , que vuelve a renderizar el componente , en este caso como aun no se ven los hooks , las funciones de componentes no pueden teer estado por si solas sin los hooks , pero las clases de componentes si tienen dicho estado , despues se vera como usar los hooks y los estados en las funciones

//componente de clase
class Estado extends React.Component{
    //Constructor el cual obtiene propiedades si es que se le agregan y que obtiene las propiedades de la clase padre
    constructor(props){
        //Obteniendo propiedades de la clase padre
        super(props);
        //este es el estado el cual se encuentra en cada clase de componente , para crearle una variable de estado , que lo que hace o hara es que si se llega a modificar esa variable de estado entonces renderizara se hara de la manera tipo objeto
        this.state = {
            contador:0
        };

        //Ahora se hara un setInterval para modicar indirectamente dicho valor de estado y asi mismo renderizar x tiempo el componente
        setInterval(()=>{
            //Para modificar indirectamente al estado se usa la funcion setState , la cual recibe como parametro un objeto el cual se le debe indicar que variables del state seran modificadas
            this.setState({
                //En este caso modificara la variable contador del state la cual obtendra los valores del state original de contador y le sumara 1 , haciendo asi que su valor cambie
                contador:this.state.contador+1
            })
        },3000)
    }
    //Funcion render para renderizar lo que se ve en pantalla del componente
    render(){
        return(
            //Renderizando el contador del state 
            <>
            <>
            <h1>Renderizacion de el componente de clase</h1>
            <h2>{this.state.contador}</h2>
            </>
            {
                //Como se puede apreciar tambien se pueden añadir componentes creados dentro de los componentes
                //En este caso el componente de EstadoFuncion creado arriba etc

            }
            <EstadoFuncion estadoHijo = {this.state.contador}></EstadoFuncion>
            </>
        )
    }
}
//Exportamos por default al estado
export default Estado;
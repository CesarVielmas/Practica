//Importacion de React
import React,{Component} from "react";

//Ahora lo que se vera son los eventos , para eso en la sintaxis JSX es muy similar como poner un evento en un html aunque claro tiene sus diferencias
//Componente de clase
export class Eventos1 extends Component{
    //Constructor de el componente de clase
    constructor(props){
        //Propiedades que puede tomar
        super(props);
        //asignandole variables a el estado
        this.state = {
            estado: true
        }
        //Cosa importante por hacer , es añadir el biding ya que el this de las funciones , como es un bloque de codigo su this referenciaria a si mismo por elllo el biding y que tome el this de la clase
       this.modificarFalso =  this.modificarFalso.bind(this);
       this.modificarVerdadero =  this.modificarVerdadero.bind(this);
    }
    //Funcion para modificar el estado a falso y cambiar el renderizado
    modificarFalso() {
        this.setState({
            estado:false
        })
    }
    //Funcion para modificar el estado a verdadero y cambiar el renderizado
    modificarVerdadero() {
        this.setState({
            estado:true
        })
    }
    //renderizado
    render(){
        //Return que condicional dependiente del estado
        return(
            <>
            <h1>Modificacion del estado en EgmaScript 6</h1>
            {
            // Botones del evento en JSX , su sintaxis es bastante similar a un boton con un evento incrustado en html
            }
            <button onClick={this.modificarFalso}>Modificar a falso</button>
            <button onClick={this.modificarVerdadero}>Modificar a verdadero</button>
            {
                (this.state.estado)
                ?<h1>El estado es verdadero</h1>
                :<h1>El estado es falso</h1>
            }
            </>
        )
    }
}
//Tambien hay otra manera de hacer un componente de clase sin tener que hacer biding con la version nueva de egmascript 7 la cual es la siguiente
export class Eventos2 extends Component{
    //Primero que todo no necesita el constructor como la clase de componente de Eventos1
    state ={
        estado:true
    }

    //Despues otra cosa que cambia es que las funciones deben de ser de tipo arrow function pues las arrow function son las que toman el this de sus padres y no su propio this

     //Funcion para modificar el estado a falso y cambiar el renderizado
    modificarFalso=()=> {
        this.setState({
            estado:false
        })
    }
    //Funcion para modificar el estado a verdadero y cambiar el renderizado
    modificarVerdadero=()=> {
        this.setState({
            estado:true
        })
    }

    //Renderrizacion funcion
    render(){
        //Return que condicional dependiente del estado
        return(
            <>
            <h1>Modificacion del estado en EgmaScript 7</h1>
            {
            // Botones del evento en JSX , su sintaxis es bastante similar a un boton con un evento incrustado en html
            }
            <button onClick={this.modificarFalso}>Modificar a falso</button>
            <button onClick={this.modificarVerdadero}>Modificar a verdadero</button>
            {
                (this.state.estado)
                ?<h1>El estado es verdadero</h1>
                :<h1>El estado es falso</h1>
            }
            </>
        )
    }
}
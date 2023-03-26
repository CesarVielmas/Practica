//Importacion de react comun con destructuracion de su clase component
import React,{Component} from 'react';

//Componente de funcion de ejemplo
function Hijo1(props){
    return <h1>{props.mensaje}</h1>
}
//Componente de clase
//haciendo una comunicacion del padre hacia al hijo
export class ComuncacionPadreHijo extends Component{
    //Ya se usara sin el constructor el cual fue de la egmaScript 7 
    //Funcion de renderizacion
    render(){
        //Manda la informacion de tipo de comunicacion del padre al hijo
        return(
            
            <Hijo1 mensaje="Informacion mandada del padre al hijo"></Hijo1>
        )
    }
}
//Componente de funcion de ejemplo
function Hijo2(props){
    return<button onClick={props.cambiarPosito}>Cambiar estado a negativo</button>
}
//Componente de funcion de ejemplo
function Hijo3(props){
    return<button onClick={props.cambiarPosito}>Cambiar estado a positivo</button>
}

//Haciendo una comunicacion del hijo al padre
//Componente de clase
//Como se puede apreiar cambia el hijo el estado del padre
export class ComunicacionHijoPadre extends Component{
    //Usando los componentes de clase mas optimizados con el egmaScript 7
    //dando al estado una variable
    state = {
        estado:true
    }
    cambiarEstadoVerdadero=()=>{
        this.setState({
            estado:true
        })
    }
    cambiarEstadoFalso=()=>{
        this.setState({
            estado:false
        })
    }
    render(){
        return(
            <>
            <Hijo2 cambiarPosito={this.cambiarEstadoFalso}> </Hijo2>
            <Hijo3 cambiarPosito={this.cambiarEstadoVerdadero}></Hijo3>
            {
            (this.state.estado)
            ?<h1>{"Estado Positivo"}</h1>
            :<h1>{"Estado Negativo"}</h1>
            }
            </>
            )
    }
}
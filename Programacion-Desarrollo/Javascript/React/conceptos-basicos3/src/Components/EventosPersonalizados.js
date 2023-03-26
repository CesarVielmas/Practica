//Importacion de React 
import React,{Component} from "react";

//Ahora se veran un poco lo que son los diferentes eventos que tiene React
//Creacion de componente de funcion ejemlo
function EventoBoton(props){
    return <button onClick={props.clickEvento}>Activar</button>
}
//Creacion componente de clase
export class EventosPersonalizados extends Component{
    //Funcion para el evento 1
    //Nota , es de buena practica poner el nombre handler al inicio de alguna funcion para evento
    handlerClick1 =(e,mensaje)=>
    {
        console.log("Activado");
        //mensaje
        console.log(mensaje);
        //El evento e , es el que manda automaticamente react , de los eventos , este utiliza un metodo que se llama sintetic el cual es el evento sintetico de react , este lo que hace es que cualquier navegador o version de navegador pueda poder ejecutar el evento sin errores para eso sirve sintetic
        console.log(e);
        //Para ver el evento nativo que da javascript , se debe usar de la siguiente manera, el cual con nativeEvent regresa el evento nativo y se puede modificar de mejor manera los eventos osease el evento de siempre
        console.log(e.nativeEvent);
        //Usando target en Sintetic de React y NativeEvent de javascript
        console.log(e.target);
        console.log(e.nativeEvent.target);
    }

    handlerClick2 = ()=>{
        console.log("Se ingreso al boton de un componente personalizado");
    }
    //Funcion render para la renderizacion
    render(){
        return(
            <>
            <h1>Evento a la etiqueta JSX</h1>
            {
                //Es importante saber que si se le quiere pasar mas parametros a una funcion , debe de involucrarse una funcion anonima para poder  darle algunos otros valores
                //Ejemplo
            }
            <button onClick={(e)=>this.handlerClick1(e,"Mensaje mandado")}>Activar</button>
            <h1>Evento a la etiqueta Personalizada</h1>
            {
                //Es importante saber que es lo que sucederia con una etiqueta personalizada y como poder mandarle los parametros de el evento y or lo cual deben mandarse como propiedad para poder accionar el evento en la etiqueta de el componente personalizado
            }
            <EventoBoton clickEvento = {this.handlerClick2}></EventoBoton>
            </>
        )
    }
}
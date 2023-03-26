//Importamos la libreria de react y destructuramos lo que se quiere obtener de react , en este caso la clase Component
import React,{Component} from 'react';

//Componente de funcion que se visualizara si contador es par
function RenderizadoPar()
{
    return <h2>Renderizado par</h2>;
}
//Componente de funcion que se visualizara si contador es impar
function RenderizadoImpar()
{
    return <h2>Renderizado Impar</h2>;
}

//Ahora lo que se vera sera un uso de los states , el cual tiene como finalidad entender como afecta el estado a la renderizacion de los componentes

//Componente de clase
class RenderizadoCondicional extends Component{
    //Constructor para obtener las props o dar valores al state
    constructor(props){
        //Obteniendo y pasando valores a la clase padre Component
        super(props);
        //Dando variables al state
        this.state = {
            contador:0
        }
        //Modificando variable del state para el renderizado
        setInterval(()=>{
            //Modificando el valor contador del state
            this.setState ({
                contador:this.state.contador+1
            })
        },3000);

    }
    //renderizado 
    render(){
        return(
            //Renderizado condicional
            <>
            {
                (this.state.contador%2 == 0)
                ?<h1>El contador es un numero Par {this.state.contador}</h1>
                :<h1>El contador es un numero Impar {this.state.contador}</h1>
            }
            {
                (this.state.contador%2 == 0)
                ?<RenderizadoPar></RenderizadoPar>
                :<RenderizadoImpar></RenderizadoImpar>
            }
            </>
        )
    }
}
//Exportacion , en este caso por default
export default RenderizadoCondicional;
//Importacion de React
import React,{Component} from 'react';

//Ahora lo que se vera sera el diferente tiempo de vida de los componentes o sus fases

//Para ver la ultima fase de el ciclo de vida de un componente el cual es cuando se desmantela o se elimina del DOM se hara otro componente de clase
class Eliminacion extends Component{
    constructor(props){
        super(props);
    }
    //El ultimo ciclo de vida el cual es componentWillUnmount el cual se efectua cuando se elimina del DOM completamente el componente 
    componentWillUnmount(){
        console.log("Ciclo de vida del componentWillUnmount el cual se efectua cuando se elimina del DOM el componente");
    }
    render(){
        return <h4>{this.props.tiempo}</h4>
    }
}
export class CicloVida extends Component{
    //Constructor el cual es una de las etapas de vida de el componente el cual es la inicializacion del componente
    constructor(props){
        super(props);
        console.log("Ciclo de vida del constructor el cual se encarga de inicializar todas las propiedades o estados antes de que se dibuje o se cree el componente");
        //Estado el cual tendra una hora y sera modificado para ver el ciclo de vida
        this.state = {
            hora:new Date().toLocaleTimeString(),
            estado:false
        }
        //Variable para un setTimeOut
       let tiempo = null;
    }
    //ComponentDidMount el cual es una etapa de vida del componente que se efectua cuando el componente se pone dentro del DOM osease despues de dibujarse con render 
    componentDidMount(){
        console.log("Ciclo de vida del componentDidMount el cual lo que hace es poner el componente ya dibujado dentro del DOM");
    }
    //ComponentDidUpdate el cual es una etapa de vida del componente que se efectua cuando se redibuja o el render efectua su accion otra vez o se actualiza es importante aclarar que este puede tomar 2 objetos , el primero las props y el segundo el state , pero lo curioso aqui es que toma las props y state antes de que fueran modificadas osease una version anterior a esta
    componentDidUpdate(prevProps,prevState){
        console.log("Ciclo de vida del componentDidUpdate el cual lo que hace es que cuando hay un redibujo de parte del render o que se actualize entonces se efectuara dicho ciclo de vida");
        console.log(prevProps);
        console.log(prevState);
    }
    //Funciones para probar los ciclos de vida
    tiempoTime = ()=>{
       this.tiempo =  setInterval(()=>{
        this.setState({
            hora:new Date().toLocaleTimeString()
        })
        },1000)
    }
    activarHora = ()=>{
        this.tiempoTime();
        this.setState({
            estado:true
        })
    }
    detenerHora= ()=>{
        clearInterval(this.tiempo);
        this.setState({
            estado:false
        })
    }
    //Render o el renderizado es una las etapas de la vida de el componente , este mismo dibuja lo que posteriormente se mostrara en el DOM
    render(){
        console.log("Ciclo de vida del render el cual lo que hace es dibujar o redibujar lo que posteriormente estara en el DOM");
        return(
            <>
            <h3>Ciclo de vida</h3>
            <button onClick={this.activarHora}>Activar ver ciclo de vida</button>
            <button onClick={this.detenerHora}>Detener ver ciclo de vida</button>
            {
                (this.state.estado)
                ?<Eliminacion tiempo={this.state.hora}></Eliminacion>
                :<h4>Tiempo detenido</h4>
            }
            </>
            )
    }
}

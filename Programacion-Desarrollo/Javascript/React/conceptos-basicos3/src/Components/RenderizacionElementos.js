//Importamos React , importante en cada componente, en este caso destructurando Component
import React,{Component} from "react";
//Importacion de la api falsa creada en helpers
import perritos from '../helpers/ejemploDatos.json';
//Componente de funcion creado para el ejemplo el cual obtendra los objetos que se le pasan con la llamada a la api falsa de el json
function Elementos(props){
    return(
        //Obteniendo de las props el objeto que envia el componente de clase 
        <li>{"Perrito "+props.perros.nombre+" de raza "+props.perros.raza+" podria ser la opcion ideal"}</li>
    )
}
//Ahora lo que se vera sera la diferencia entre la renderiacion de componentes JSX y los elementos normales

class RenderizacionElementos extends Component{
    //Constructor que recibira propiedades , si las hay
    constructor(props){
        super(props);
        //Asignandole un objeto al state
        this.state = {
            perro: ["Candy","Pepe","Mary"]
        }
    }
    //Renderizacion
    render(){
        //return que devolvera lo que renderizara
        return(
            
            <>
            <h1>Nombres de perros</h1>
            {
                //Renderizacion del state con map
            }
            <ul>
            {this.state.perro.map((elemento,i)=>{
             return <li key={i}>{elemento}</li>   
            })}

            </ul>
            <hr/>
            <div>
                <h1>Perros</h1>
            {
                //Renderizando elementos para ello se apoyara del componente creado arriba de funcion y ademas se usara la api false en el archivo json de ejemplo creado en helpers
                perritos.perritos.map((elemento)=>{
                 return <Elementos perros = {elemento} key={elemento.id}></Elementos>   
                })
            }   
            </div>
            </>
        )
    }
}
//exportacion para usarlo
export default RenderizacionElementos;
//Para crear un nuevo componente , existen 3 maneras para poder crearlos aqui se veran esas 3 maneras y su informacion extra

//cuando importamos siempre para crear un componente nuevo se debe usar Components de React , aunque con solo importar React se podra usar usando React.Components sin embargo es mejor destructurarlo desde el inicio por comodidad

/* Ejemplo sin destructuracion 
import React from "react";

class Componentes extends React.Component {
    render(){
        return <h1>Componente llamado Componentes Creado</h1>
    }
}
*/

//Con destructuracion (Recomendado)
import React,{Component} from "react";

//Ahora para crear dicho componente hay 3 formas para hacerlo

//Forma de la version antigua de React usando clases
//Esta version siempre de extender de Component de React , pues se necesita para crear un componente , ademas tambien siempre , pero siempre se va a necesitar que se cree una funcion llamada render dentro de el componente y esta lo que hara es renderizar el contenido y para que se visualize se debe usar un return con lo que va a imprimir
export class Componente1 extends Component{
    //funcion render necesaria para el componente de clase creada
    render(){

        //return necesario para indicar que es lo que devolvera el componente y se visualizara
        return <h1>Componente 1 de clase , que se usaba en versiones anteriores de react</h1>;
    }
}

//Importante , tambien es necesario exportar la clase de el componente para que el programa lo localize y al hacer la importacion lo pueda usar dicho componente , en este caso se uso la exportacion desde la clase , pero en los demas componentes es de manera diferente

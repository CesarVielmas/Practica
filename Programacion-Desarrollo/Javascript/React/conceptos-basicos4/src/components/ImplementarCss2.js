//Ahora se vera una manera muy eficiente de implementar Css a react con styled components , el cual es una libreria externa pero que funciona muy bien con react 

//Importacion de React
import React, { createElement } from 'react';

//Importacion de styled-components
import styled,{css,keyframes,ThemeProvider,createGlobalStyle} from 'styled-components';

//Funcion de componente con hooks
export function ImplementarCss2(){
    //Temas para ThemeProvider
    const claro ={
        colorFondo: "white",
        colorLetra: "black"
    },oscuro ={
        colorFondo: "black",
        colorLetra: "white"
    },morado ={
        colorFondo: "purple",
        colorLetra: "blue"
    };

    //Para empezar a usar styled-components es necesario leer un poco la documentacion , es una herramienta muy efectiva y eficaz para css , con ella se puede crear lo siguiente

    //Componentes que ya incluyen el css y se mandan a llamar en el return para imprimirlos con css
    const PrimerComponente = styled.h2`
    //Aqui va el codigo css
    background-color: brown;
    color: aqua;
    font-size: 40px;

    `;
    //Poder hacer condicionales dependiendo de los datos mandados y dando un estilo con las props
    const SegundoComponente= styled.h2`
        //Lo que hace css es poder dar estilos , dentro de otros estilos , en este caso le asigna estilos estando dentro de una estiqueta que deberia asignar estilos por ello css fue destructurado de styled para poder incluir dichos estilos dentro de los estilos
        ${
            //se tiene que hacer una funcion anonima pues props son los parametros que obtiene de su componente
        (props)=>(props.rojo)
                ?css`background-color:red`
                :css`background-color:purple`}

    `;

    //animaciones con keyframe , el cual debe de destructurrse de styled para poder usar el keyframe que seria la misma sintaxis que una animacion
    const animacion = keyframes`
            //Animacion de opacidad
            0%{
                opacity: 0;
            }
            100%{
                opacity: 1;
            }
    `;

    const TercerComponente = styled.h2`
            //Usando la animacion anterior
            animation-name: ${animacion};
            animation-duration: 8s;
    `;
    //dar temas oscuros o claros o etc , a ciertos componentes o elementos
    //Componente para obtener el tema 
    const CuartoComponente = styled.h2`
        background-color: ${({theme})=>theme.colorFondo};
        color: ${({theme})=>theme.colorLetra};
    `;
    //Heredar de otros componentes sus estilos con styled(nombre del componente que se desee heredar)`modificaciones de estilo o añadidos`
    const QuintoComponente = styled(TercerComponente)`
        background-color: blue;
    `;
    //Para terminar aqui y que no sea tan largo tambien tiene su global style , osease que va a modificar todos los estilos o todos los estilos que contengan esas clases es como una hoja de estilos , pero a nivel global , de todo el proyecto
    const globalStyles = createGlobalStyle`
        h2{
            border-radius: 60%;
            text-transform: uppercase;
        }
    `;
    //Return
    return(
        <>
        <h1>Implementacion de CSS parte 2</h1>
        <PrimerComponente>Este es el primer componente con CSS con styled-component</PrimerComponente>
        <SegundoComponente rojo={false}>Este es el segundo componente con CSS con styled-component</SegundoComponente>
        <TercerComponente>Este es el tercer componente con CSS con styled-component</TercerComponente>
        <ThemeProvider theme={claro}>
        <CuartoComponente>Este es el cuarto componente con CSS con styled-component</CuartoComponente>
        </ThemeProvider>
        <ThemeProvider theme={morado}>
        <CuartoComponente>Este es el cuarto componente con CSS con styled-component</CuartoComponente>
        </ThemeProvider>
        <QuintoComponente>Este es el quinto componente con CSS con styled-component</QuintoComponente>
        </>
    )
}
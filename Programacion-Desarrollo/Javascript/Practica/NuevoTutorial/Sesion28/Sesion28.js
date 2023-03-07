//Sesion 28 
//Lo que se vera aqui seran los modulos dichos modulos son muy eficacez y ademas muy usados
//En cualquier aplicacion javascript , es el remplazo de las funciones autoejecutables
//Para ello se vera como importarlos , pero primero dentro del html debe de venir en la
//Etiqueta script "type = "module" " para que pueda funcionar y asi mismo importar
//Los modulos o exportar
//Primero que nada hay que importar los modulos los cuales vienen en la carpeta Sesion28
import { valorPI as PI,valor2 as valorRueda,valor3 as confirmacion } from "./Elementos.js";
import { funcionRueda as resultadoFinal } from "./Funciones.js";//Con as se le da otro nombre a dichas variables o funciones en el contexto del archivo
resultadoFinal(PI,valorRueda,confirmacion);

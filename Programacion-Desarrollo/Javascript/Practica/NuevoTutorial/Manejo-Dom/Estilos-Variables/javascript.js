//Lo que se vera ahora seran los estilos con css y variables de css en javascript para poder efectuar dicho cambio a la pagina y que sea un poco mas dinamica

const $parrafo1 = document.querySelector(".parrafo1"),//Guardando el valor de parrafo 1 para no batallar
$parrafo2 = document.querySelector(".parrafo2");
console.log($parrafo1.style);//Para ver todos los estilos que contiene dicha etiqueta
console.log($parrafo1.style.backgroundColor);//Para ver un estilo en especifico usando camelCase
console.log($parrafo1.getAttribute("style"));//Para ver el estilo en este caso es diferente pues muestra el puro texto de lo que fue cambiado
console.log(window.getComputedStyle($parrafo1));//Usando el metodo getComputedStyle lo que hace es mostar todo el estilo puesto y por haber , ademas de mostar su autocompletado por defecto de lo que desee , no es necesario instanciar el objeto window , pues ya viene por defecto en el navegador
console.log(getComputedStyle($parrafo1).getPropertyValue("background-color"));//Con el metodo getPropertyValue al darle el getComputedStyle lo que hace es obtener el atributo que se desea obtener, para cambiar su valor o verlo

//Asignando algunos estilos desde javascript

//Con la notacion del punto
$parrafo1.style.border = "5px solid black";
$parrafo1.style.borderRadius = "10px 20px 10px 20px"
$parrafo1.style.padding = "10px";
$parrafo1.style.textAlign = "center";

//Con el metodo setAttribute
$parrafo2.setAttribute("style","border:10px solid blue; border-radius:15px 30px 20px 5px; padding:10px; text-align:center; background-color:purple; color:aliceblue;")

//Ahora para modificar una variable css dentro de javascript
//Estas se pueden modificar gracias a que toma con getComputerStyle la cual toma todas las propiedades que existan en el css de alguna etiqueta y si se hace referencia a la etiqueta html entonces pueden ser tomadas como variables y asi mismo tambien modificar su valor 
const $html = document.documentElement,
$body = document.documentElement.querySelector("body");//Se le asigna a $html que tomara todo el contenido html , a $body que tomara la etiqueta body de la pagina html
let colorFondo = getComputedStyle($html).getPropertyValue("--color-fondo");//Aqui lo que sucede es que la propiedad de el style $html desde la raiz , lo toma la variable color fondo osease ahora es la variable de css la cual tomo su valor
let colorLetras = getComputedStyle($html).getPropertyValue("color--letras");//lo mismo que el anterior pero tomo otra variable css

$body.style.setProperty("background-color",colorFondo);//Se le asigna a el fondo del color del body el color de fondo tomado por la variable de css con el metodo setProperty el cual lo que hace es que toma alguna de las propiedades de algun atributo las que se les diga de la etiqueta html y le asigna otro valor dentro de el segundo parametro

//Ahora un cambio en las variables como ejemplo
//Primero cambiar el valor de la variable en css lo cual se hace con setProperty en la raiz
$html.style.setProperty("--color-fondo","tomato");
//Segundo cambiar el valor a la variable en cuestion para que haga su trabajo
colorFondo = getComputedStyle($html).getPropertyValue("--color-fondo");
//Por ultimo cambiar decirle al estilo cambiado otra vez que cambio el color para que lo vuelva a tomar
$body.style.setProperty("background-color",colorFondo);

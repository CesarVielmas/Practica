//Ahora lo que se vera seran algunos metodos para agregar o modificar elementos que son mas modernos y que vinieron para remplazar a los anteriores

//Declaracion de constantes html
const $tarjeta = document.createElement("div"),
$fragmento = document.createDocumentFragment();

//En este caso se usara innerHTML para agregar texto aunque obviamente no es recomendable
let $contenido = `
<h1></h1>
<img>
`;

//Ahora aqui los nuevos metodos los cuales hacen casi exactamente lo mismo

//Lo que hace insertAdjacentHTML es como innerHTML pero pide la posicion en la que se pondra el html y como segundo parametro la variable que contiene el codigo o contenido del html en forma de texto
$tarjeta.insertAdjacentHTML("afterbegin",$contenido);

//Algunas modificaciones para poner clases a los elementos

$tarjeta.querySelector("img").setAttribute("src","https://i.ytimg.com/vi/1Psjws97FoA/hqdefault.jpg?sqp=-oaymwEcCNACELwBSFXyq4qpAw4IARUAAIhCGAFwAcABBg==&rs=AOn4CLBqku1wT4Sdw0FJk6j5I8mk4Z8P7g")
$tarjeta.querySelector("img").setAttribute("alt","Imagen dimash")
$tarjeta.querySelector("img").classList.add("imagen");
$tarjeta.querySelector("h1").classList.add("titulo");
$tarjeta.classList.add("tarjeta");

//Lo que hace insertAdjacentText es insertar un nodo de tipo texto , en este caso se busco la etiqueta h1 dentro de la tarjeta la cual ya fue añadida con el insertAdjacentHTML y dentro de esta misma etiqueta h1 se añadio el texto como nodo
$tarjeta.querySelector("h1").insertAdjacentText("afterbegin","Imagen");

//Lo que hace AdjacentElement es casi lo mismo que appendChild() agrega un elemento , pero sin embargo se puede agregar como hijo , como hermano posterior , como hermano anterior o hijo final , esto gracias a su primer parametro el cual pide la posicion en la cual sera agregado dicho elemento
//En este caso los fragmentos no pueden tomar los insertAdjacentElement o sus contrapartes asi que deben usarse los antiguos 
//$fragmento.insertAdjacentElement("afterbegin",$tarjeta);
$fragmento.appendChild($tarjeta);

//Como se usa un fragmento no se puede añadir un elemento con insertAdjacentElement y debe ser con appendChild o cualquier variante ya que es un fragmento y no un elemento
document.body.appendChild($fragmento);
//Posiciones
//afterbegin = hijo en la primera posicion
//afterend = hijo en la ultima posicion
//beforebegin = hermano anterior de la etiqueta
//beforeend = hermano posterior de la etiqueta

//Tambien existen otros metodos los cuales no se usaran aqui pero son importantes y pueden ser usados
//document.body.before(); lo que hace es que añade un hermano anterior a la etiqueta
//document.body.after(); lo que hace es que añade un hermano despues de la etiqueta
//document.body.prepend();lo que hace es que añade un hijo en la primera posicion dentro de la etiqueta
//document.body.append();lo que hace es que añade un hijo al final de el ultimo hijo o posicion
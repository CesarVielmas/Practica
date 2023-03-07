//Ahora lo que se vera sera, como poder añadir texto o codigo html a la pagina desde javascript pues esto puede ser muy efectivo para usarse en elgunas ocaciones en especifico

//Texto de ejemplo para añadir
const texto = `
    <h1>Hola soy un codigo añadido en javascript</h1>
    <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Alias aliquid beatae odio. Eveniet exercitationem maxime recusandae dolorum sapiente, omnis cum repudiandae unde nihil saepe rerum autem minus iusto assumenda! Consequuntur.</p>
    <p>Lorem ipsum, dolor sit amet consectetur adipisicing elit. Ea cum nihil provident necessitatibus magni ipsum doloremque sit quia odit, numquam error consequatur quibusdam, ad voluptas animi similique quae nisi. Minus!</p>
    
`;
//Declaracion de bloque el cual es el div del html donde ira el contenido
const $bloque = document.querySelector(".contenido");
$bloque.textContent = texto;//Con el metodo textContent se añade solamente el texto dentro de la etiqueta html
$bloque.outerHTML = texto;//Con el metodo outerHTML lo que hace es añadir el texto convertido a codigo html y eliminando la etiqueta en la que iria todo el contenido
$bloque.innerHTML = texto;//Es muy parecido a outerHTML pero el metodo innerHTML lo que hace es añadir el texto en codigo html dentro de la etiqueta donde se pone, algo que outerHTML no hace , si no la elimina
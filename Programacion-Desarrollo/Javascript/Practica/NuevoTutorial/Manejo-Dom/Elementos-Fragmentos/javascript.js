//Ahora lo que se vera sera como añadir elementos dentro de el documento html y con ello significa que se puede añadir de la mejor manera y correcta el codigo desde javascript al html

//Primera manera para entenderlo , no es recomendable usarlo asi

//Primero se crean las diferentes etiquetas que usara el documento
//Para ello se usa el metodo createElement o createTextNode los cuales como su nombre dice es para crear elementos o texto etc , los cuales tienen como parametro el elemento a crear o el texto que se generara
const $div = document.createElement("div"),
$img = document.createElement("img"),
$texto = document.createElement("p"),
$textoContenido = document.createTextNode("Imagen Ejemplo");

//Despues se tendra que anidar dentro del documento html por lo cual se usara el metodo appendChild el cual tiene como objetivo añadir el elemento a que sea hijo de otro por lo cual al añadirlo a body lo que hace es que ahora div pertenece al documento html y dentro de la etiqueta body

//Se le añade el atributo href a la imagen y su alt para que pueda contener la imagen
$img.setAttribute("src","https://upload.wikimedia.org/wikipedia/commons/d/d7/Kudaibergen_at_New_Wave_in_2019.jpg");

$img.setAttribute("alt","imagen dimash");

//Se le añaden unas clases para que al ser añadidos al documento html tome los estilos css
$texto.classList.add("texto");
$img.classList.add("imagenes");
$div.classList.add("bloque");

//Aqui se le añade como hijo el texto contenido el cual es texto , pero es una manera correcta de añadir texto
$texto.appendChild($textoContenido)
//Ahora a div como hijo se le añade texto
$div.appendChild($texto)
//Ahora a div como segundo hijo se le añade la imagen
$div.appendChild($img)
document.body.appendChild($div)

//Ahora la manera correcta para poder añadir codigo html desde javascript es mediante un fragment o un fragmento , esto sirve ya que ahorra muchos recursos al navegador ya que el procesador no le exigira demasiado a la computadora del usuario

//Primero se declaran los elementos que formaran parte dentro del html incluyendo al fragmento
const $div2 = document.createElement("div"),
$img2 = document.createElement("img"),
$texto2 = document.createElement("p"),
$textoContenido2 = document.createTextNode("Imagen Ejemplo 2"),
$fragmento = document.createDocumentFragment();

//Ahora se deben anidar los hijos para mandarlo al documento html , especificamente dentro de body

//Dandole las propiedades necesarias a la imagen
$img2.setAttribute("src","http://martinwullich.com/wp-content/uploads/2020/11/dimash-kudaibergen-moscow-2019.jpg");
$img2.setAttribute("alt","Segunda imagen dimash");

//Dandole clases para que al entrar al html tome los estilos
$texto2.classList.add("texto");
$div2.classList.add("bloque");
$img2.classList.add("imagenes");
//Haciendo la anidacion de padres e hijos
$texto2.appendChild($textoContenido2);
$div2.appendChild($texto2);
$div2.appendChild($img2);

//Importante anidar el ultimo elemento a el fragmento
$fragmento.appendChild($div2);

//Y por ultimo añadirlo al documento html en este caso dentro de body
document.body.appendChild($fragmento);

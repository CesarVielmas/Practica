//Ahora lo que se vera sera como interactuar con las clases para quitar o poner clases etc o remplazar
//Esto es muy importante pues gracias a esto puede ser mas interactivo el sitio
//Declaracion de el $bloque para que tome sus atributos desde html
const $bloque = document.querySelector(".bloque");

//className es el nombre de la clase a la cual fue asignado el elemento que fue tomado desde html
console.log($bloque.className);

//classList es mas extenso pues contiene unos metodos utiles que se veran a continuacion
console.log($bloque.classList)

//el metodo contains lo que hace es mandar un true si encuentra el elemento dado dentro y un false si no encuentra ese nombre de clase
console.log($bloque.classList.contains("bloque"));//Mandara true pues esta clase si existe
console.log($bloque.classList.contains("name"));//Mandara false pues esa clase no existe en la etiqueta

//El metodo remove lo que hace es eliminar dentro de la clase lo que se le pida 
$bloque.classList.remove("bloque");//Eliminara la clase bloque
console.log($bloque.classList.contains("bloque"));//Mandara false pues no existe la clase bloque

//El metodo add por otro lado es lo contrario a remove , pues añade alguna clase , sea la que sea poniendo dentro su nombre
$bloque.classList.add("bloque");//Se añadio la clase bloque
console.log($bloque.classList.contains("bloque"));//Mandara true pues ya fue devuelta dicha clase

//el metodo replace lo que hace es remplazar alguna clase por otra 
$bloque.classList.replace("bloque","margenes");//se remplazo la clase bloque y se puso ahora la clase margenes

//el metodo toggle lo que hace es que busca clases , si no existe esa clase la agrega dentro de esta y si exista dicha clase la elimina
$bloque.classList.toggle("bloque");//En este caso agregara la clase bloque pues aun no existe
console.log($bloque.classList.contains("bloque"),$bloque.classList.contains("margenes"));//Mandara doble true pues bloque lo agrego toggle al no encontrarlo y margenes ya lo tenia

//Ahora añadiendo clases a la etiqueta
$bloque.classList.add("opacidad","rotacion","bordeBonito","alinearContenido");
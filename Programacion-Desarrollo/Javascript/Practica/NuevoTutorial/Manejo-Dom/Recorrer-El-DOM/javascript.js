//Ahora lo que se vera seran unas formas de poder recorrer el documento html con codigo javascript el cual ahorra tiempo en buscar

//Declarando la variable de tipo DOM para hacer el recorrido
const $cuadro = document.querySelector(".bloque");
//Es importante decir que en html existen diferentes tipos de nodos , las etiquetas los cuales son "Element" espacios en blanco etc , por ello se usa Element para que tome directamente a las etiquetas ya que lo otro es muy cuando se toma y muy posiblemente ni se use

//la propiedad lastElementChild lo que hace es tomar al ultimo hijo dentro de su misma etiqueta
console.log($cuadro.lastElementChild);

//la propiedad parentElement lo que hace es encontrar a el padre de dicha etiqueta 
console.log($cuadro.parentElement);

//la propiedad firstElementChild lo que hace es casi lo mismo que lastElementChild solo que lo contrario pues ahora toma al primer hijo que se encuentra dentro de dicha etiqueta
console.log($cuadro.firstElementChild);

//la propiedad children lo que hace es que busca a todos los hijos dentro de la etiqueta , al ser un arreglo se le puede usar corchetes [] para buscar uno en especifico o no usarla "children[]" para que recolecte todos si no se usa
console.log($cuadro.children)

//la propiedad previusElementSibling lo que hace es encontrar al elemento anterior osease a su hermano mas sercano pero anterior
console.log($cuadro.previousElementSibling);

//la propiedad nextElementSibling lo que hace es todo lo contrario ya que ahora buscar al hermano de la etiqueta , pero el siguiente hermano , no el anterior
console.log($cuadro.nextElementSibling)

//el metodo closest lo que hace es buscar la etiqueta que se le de ,de forma ancestral osease que la buscara por fuera de la etiqueta a la que se tomo y si la encuentra la mandara
console.log($cuadro.closest("html"));

//buscando una etiqueta p dentro de otra
console.log($cuadro.lastElementChild.children[1]);
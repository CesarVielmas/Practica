//Ahora lo que se vera sera como modificar u obtener atributos de html , mediante javascript y tambien los nuevos data-atributtes que fueron añadidos en html5 para hacer algunas u otras cosas

//Atributos
console.log(document.documentElement.lang);//Con document.documentElement.atributo buscara en la etiqueta solamente la etiqueta html el atributo y dara su valor
console.log(document.documentElement.getAttribute("lang"));//Exactamente lo mismo que el anterior solo que ahora es con el metodo getAtributte y la otra era con la metodologia del punto
console.log(document.querySelector(".Parrafo1").style);//Para obtener los atributos de algun elemento en especifico se debe usar querySelector para localizarlo o cualquier otro , en este caso se uso la metodologia del punto
console.log(document.querySelector(".Parrafo2").getAttribute("style"));//Lo mismo que el anterior pero se uso el metodo getAttribute el cual toma los mismos valores que la metodologia del punto pero simplificado
document.querySelector(".Parrafo1").style  = "border:50px solid black;";//Cambiando valores con la metologia del punto
console.log(document.querySelector(".Parrafo1").style);//Viendo valores por la metologia del punto
document.querySelector(".Parrafo1").setAttribute("style","border:50px solid green;");//Cambiando valores mediante el setter setAttribute el cual como primer parametro se debe poner el atributo a cambiar y en el segundo parametro el nuevo valor que tomara
console.log(document.querySelector(".Parrafo1").getAttribute("style"));//Viendo el atributo mediante el metodo getAttribute
document.querySelector(".Parrafo1").removeAttribute("style");//El metodo removeAttribute remueve el atributo completamente 

//Poniendo valores de las etiquetas a variables o constantes consejo: es recomendable usar el signo de dolar al principio de cualquier constante o variable que sea tipo de tipo DOM o que tome valores del html
const $Parrafo2  = document.querySelector(".Parrafo2");
console.log($Parrafo2.getAttribute("style"));
//Cambiando atributos a las etiquetas mediante variables o constantes
$Parrafo2.setAttribute("style","border:20px solid black;");
console.log($Parrafo2.hasAttribute("style"));//Con el metodo hasAttribute comprueba si existe el atribute dentro de la etiqueta , mandara true si existe y un false si no , en este caso es un true
$Parrafo2.removeAttribute("style");//Removiendo el atributo style
console.log($Parrafo2.hasAttribute("style"));//Mandara false pues comprueba si existe o no y fue recientemente eliminado

//Ahora los Data-Attribute
console.log(document.querySelector(".Parrafo1").getAttribute("data-descripcion"));//Obteniendo el valor mediante el getAttribute
console.log(document.querySelector(".Parrafo1").dataset)//Obteniendo el valor mediante la metologia del punto el cual es diferente, ya que usa dataset y luego si se quiere el valor en especifico del dataset se pone otro punto con el nombre del dataset .dataset.nombreDelDataset
document.querySelector(".Parrafo1").setAttribute("data-descripcion","Valor Cambiado");//Cambiandole el valor a un data con el metodo setAttribute
console.log(document.querySelector(".Parrafo1").getAttribute("data-descripcion"));//Viendo el valor cambiado



//Ahora lo que se vera sera como tomar los elementos de un documento html mediante el DOM
//Para empezar se tienen los siguientes elementos que son algo obsoletos , pero ayudan a ahorrar memoria del navegador para que no sea tan pesada la pagina aunque es mas recomendable usar su contraparte menos en el id
console.log(document.getElementsByName("bloque1__li--1"));//Obtiene todos los elementos del html que contengan como name = "bloque1__li--1"
console.log(document.getElementsByClassName("bloque2"));//Lo que hace es obtener todos los elementos del html que contengan como class = "bloque2"
console.log(document.getElementsByTagName("div"));//Lo que hace es obtener todas las etiquetas html que sean de tipo de div
console.log(document.getElementById("bloque"));//Lo que hace es obtener todos los elementos que contengan como id = "bloque"

//Para los elementos anteriormente vistos pueden remplazarse con el metodo querySelector y querySelectorAll los cuales hacen lo mismo que los 4 elementos anteriormente vistos , querySelector tomando solo el primer elemento encontrado y querySelectorAll tomando todos los elementos que tengan dicha caracteristicas
console.log(document.querySelector("div"));//Es importante decir que para clases se usa "." para id "#" y asi sustantivamente como css 
console.log(document.querySelectorAll("div"));//Toma todos los elementos que sean una etiqueta de tipo div en html , ya que querySelector solo tomara la primera
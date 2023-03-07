//Ahora lo que se vera seran 3 objetos bastante importantes en el navegador los cuales son location(url), history(historial) y navigator(navegador), se veran algunos metodos y propiedades

//Objeto location
console.log("Objeto location");
console.log(window.location.href);//Muestra la url completa de la pagina
console.log(window.location.protocol);//Muestra el protocolo que esta usando la pagina
console.log(window.location.host);//Muestra el host que en este caso es el mismo que el nombre del hostname
console.log(window.location.hostname);//Muestra el nombre del host
console.log(window.location.hash);//Muestra los hashesh que haya en la url de la pagina en este caso no hay
console.log(window.location.pathname);//Lo que hace esta propiedad es mostrar el path osease /carpeta/archivo etc
console.log(window.location.port);//Lo que hace esta propiedad es mostrar el puerto si es que lo hay
//console.log(window.location.reload()); lo que hace es recargar la pagina
console.log(window.location);

//Objeto history
console.log("Objeto History");
console.log(window.history);
console.log(window.history.length);//Propiedad para ver la cantidad de paginas abiertas en el historial
//console.log(window.history.go()); metodo para ir una pagina adelante en el historial
//console.log(window.history.back()); metodo para ir una pagina hacia atras en el historial
console.log(window.history.state);//Propiedad para ver el estado de la pagina
//console.log(window.history.forward()); metodo para viajar de un lado a otro en las paginas guardadas

//Objeto navigator
console.log("Objeto navigator");
console.log(window.navigator);
console.log(window.navigator.userAgent);//Propiedad para ver desde que dispositivo y navegador se esta usando para ver la pagina
console.log(window.navigator.vendor);//Propiedad para ver quien creo dicho navegador
console.log(window.navigator.geolocation);//Objeto de geolocalizacion el cual sera muy util despues
console.log(window.navigator.language);//Propiedad que muestra el lenguaje que esta usando la pagina
console.log(window.navigator.onLine);//Propiedad que muestra si se esta en linea osease con conexion a internet o no y mostrara un true si esta en linea o un false si no 

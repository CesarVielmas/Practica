//Ahora lo que se vera sera la API de fetch la cual es una version mas modernade el XMLHttpRequest , por lo cual es bastante mas utilizada y tiene mejores formas de organizar el codigo

//Declaraciones Items HTML
const $lista = document.querySelector(".datosEjemplo"),
$fragmento = document.createDocumentFragment(),
$fragmento2 = document.createDocumentFragment();

//Ahora lo importante es que a diferencia de XMLHttpRequest Fetch no necesita de ningun metodo send o open como con XMLHttpRequest lo cual es bastante mejor y mas sencillo

//Declaracion de fetch el cual es un metodo, el cual su primer parametro es la url de donde tomara el archivo json y su segundo parametro es un objeto con las propiedades que puede tomar fetch , el cual se vera despues
fetch("https://jsonplaceholder.typicode.com/users").
//Como se puede apreciar fetch es una promesa de el objeto XMLHttpRequest , por lo cual contiene los metodos then el cual hara el codigo siempre y cuando no haya errores, el catch el cual se ejecutara si hay error y el finally el cual se ejecutara si o si pase lo que pase
then(
    objetoTomado =>{
        //El objeto que da en un principio no sirve de mucho , solo sirve para poder corroborar el status y obtener alguna informacion extra, para poder obtener un json o texto o convertirlo vaya , se debe usar sus funciones de conversion , ya sea blob , json o text
        //En este caso se convertira a json 
        //console.log(objetoTomado.json());
        //Importante , como son promesas los tipos de dato , es importante tener solo 1 declaracion de la conversion

        //Lo mas recomendable a hacer despues de su conversion es pasarlo a otro then el cual tomara el objeto ya convertido con un return , ya sea text o blob o json

        //Una cosa importante es que el catch no entra de manera correcta muchas veces entonces es muy recomendable usar un condicional de que cunado el ok el cual es el señalador que dice si encontro o no los datos, sea falso , osease no pudo encontrar datos o no ingreso entonces hacer un Promise.reject() el cual le exige al programa irse al catch y ignorar los then
        return (objetoTomado.ok)? objetoTomado.json():Promise.reject(objetoTomado);//Importante pasarle el objetoTomado a reject para que lo mande a el catch
    }
).
//Segundo then que obtiene el return objetoTomado.json() osease el objeto convertido
then(objetoConvertido =>{
    console.log(objetoConvertido);
    
    const objetoObtenido = objetoConvertido;
    objetoObtenido.forEach((elemento)=>{
        const $li = document.createElement("li");
        $li.textContent = `usuario: ${elemento.username} compañia: ${elemento.company.name} correo: ${elemento.email}`;
        $fragmento.appendChild($li);
    })
    $lista.appendChild($fragmento);
}).//Y como se puede ver se hizo lo mismo que con el XMLHttpRequest
catch(error =>{
    console.log("El error fue",error.status);
}).
finally(objeto=>{
    console.log("Esto se ejecutara siempre");
})

//Ejemplo Practico Imagenes
const $contenido = document.querySelector(".imagenes");
fetch("https://jsonplaceholder.typicode.com/photos").
then(objeto1 =>{
    return (objeto1.ok)?
    objeto1.json():
    Promise.reject(objeto1);
}).
then(objetoConvertido=>{
    const objetoImagenes = objetoConvertido;
    objetoImagenes.forEach((elementos)=>{
        const $imagenes = document.createElement("img"),
        $titulo = document.createElement("figcaption");
        $titulo.textContent = `imagen: ${elementos.id}`;
        $fragmento2.appendChild($titulo);
        $imagenes.src = elementos.thumbnailUrl;
        $fragmento2.appendChild($imagenes);
    })
    $contenido.appendChild($fragmento2);
}).
catch(error =>{
    console.log(`Ocurrio el error ${error.status}`)
}).
finally(objeto=>{
    console.log(`El objeto viene de ${objeto}`);
})
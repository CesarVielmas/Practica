//Ahora lo que se vera sera como hacer peticiones y como funciona el objeto XMLHttpRequest el cual es un objeto para hacer peticiones o cargarlas , aunque es mas nuevo fetch , pero al igual lo utiliza ajax

//Primero se necesita instanciar un objeto ajax con el XMLHttpRequest()
let ajax = new XMLHttpRequest();
const $fragmento = document.createDocumentFragment(),
$lista = document.querySelector(".datosEjemplo");
//Ahora este mismo objeto tiene un evento que se llama readyStateChange el cual se activa cuando nota un cambio en el ajax , ya sea obteniendo una petcicion o un cambio en el state o estado
ajax.addEventListener("readystatechange",(e)=>{
    if (ajax.readyState!==4) return "";

    console.log("ingreso");
    //Con response text es el valor que toma del servidor y >que posteriormente podra ser utilizado en este caso se parseo el json a un objeto de tipo javascript y este mismo toma sus valores o atributos
    const objetoJSON = JSON.parse(ajax.responseText);
    console.log(objetoJSON);
    //Con un forEach se le añade cada elemento tomado y se le pone su valor en un textContent de un li que ira en el fragmento
    objetoJSON.forEach((elemento)=>{
        const $li = document.createElement("li");
        //Por cada objeto entonces usara la notacion del punto para poder tomar sus valores
        $li.textContent = `usuario: ${elemento.username} compañia: ${elemento.company.name} correo: ${elemento.email}`;
        $fragmento.appendChild($li)
    })
    $lista.appendChild($fragmento);

});
//Ahora el metodo de ajax o el obeto XML es uno que se llama open el cual se le indica el metodo por el cual obtendra o mandara datos , en este caso obtendra datos de una api importante para probar datos que se llama json holder y con el evento anterior declarado entonces habra un cambio en el state y hara lo que tenga dentro

//ajax.open("GET","archivo.json"); para obtener un json local

//Para obtener un json de una api o en linea
ajax.open("GET","https://jsonplaceholder.typicode.com/users");

//Con el metodo send es necesario activarlo porque aunque no se mande nada a el servidor , este mismo lo ejecuta y hace los 4 pasos de readyState
ajax.send();
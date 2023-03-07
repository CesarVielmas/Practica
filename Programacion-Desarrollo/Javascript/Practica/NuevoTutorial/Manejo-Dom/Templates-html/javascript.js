//Ahora lo que se vera sera la funcionalidad de la etiqueta template de html y su funcionamiento dentro de javascript el cual si es utilizado y util para poder generar mucho codigo html y poder tomarlo como plantilla

//Declaracion de las variables que se usaran para crear codigo html
const $plantilla = document.querySelector(".plantilla").content,//Tomando la plantilla es importante usar content
$fragmento = document.createDocumentFragment(),//creando el fragmento
arrayEjemplo =[//Array de ejemplo con 3 objetos
{
    alt:"foto dimash 1",
    imagen:"https://media.gettyimages.com/id/956546112/es/foto/dimash-kudaibergen-attends-the-screening-of-yomeddine-during-the-71st-annual-cannes-film.jpg?s=612x612&w=gi&k=20&c=Fy2yI-cm45iSN9QPrzFZh54-5WLTrJcqLqtbCiup858="
}
,
{
    alt:"foto dimash 2",
    imagen:"https://en.dimashnews.com/wp-content/uploads/2019/12/618b30a6f13869b87d35.jpeg"
}
,
{
    alt:"foto dimash 3",
    imagen:"https://c8.alamy.com/compes/2dgd0xx/dimash-kudaibergen-participa-en-el-global-gift-the-eva-foundation-gala-photoall-en-el-hotel-george-v-en-paris-francia-el-16-de-mayo-de-2017-foto-de-alban-wyters-abacapress-com-2dgd0xx.jpg"
}
];
//Lo siguiente es hacer un ciclo para que se pueda ver el potencial de template
arrayEjemplo.forEach(elemento =>
    {
        //Ahora el contenido de la plantilal o template se ira desarrollando y dando sus respectivos atributos y clases para que la clonacion los tome y este mismo se los de al fragmento el cual al final se lo dara a body cuando se junten varios fragmentos 
        $plantilla.querySelector("img").setAttribute("src",elemento.imagen);
        $plantilla.querySelector("img").setAttribute("alt",elemento.alt);
        $plantilla.querySelector("img").classList.add("imagenes");
        $plantilla.querySelector("div").classList.replace("contenido","bloques");
        $plantilla.querySelector("p").classList.add("texto");
        
        let $clonacion  = document.importNode($plantilla,true);//Ahora aqui lo que pasa es que la plantilla se clonara el numero de veces que de vuelta el array y despues al acabar ese contenido clonado sera llevado a el fragmento para ser visto en pantalla , se clona con el metodo importNode el cual recibe el parametro de lo que clonara y un true o false , un true si se desea clonar su contenido y un false si no se desea clonar su contenido
        $fragmento.appendChild($clonacion);
    })
    //Dandole el fragmento al archivo html para que haga su trabajo y se vea en el html
    document.body.appendChild($fragmento);
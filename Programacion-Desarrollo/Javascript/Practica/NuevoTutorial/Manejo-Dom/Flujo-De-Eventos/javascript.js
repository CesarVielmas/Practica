//Ahora lo que se vera sera el flujo de eventos que tiene javascript al asignarle un evento a algo que este dentro de este mismo y como funciona el tipo burbuja

//Para empezar esto se efectua de hijo a hijo ya que su propagacion puede ser de fuera hacia dentro y de dentro hacia afuera dependiendo de la propagacion , cuando es de adentro hacia afuera se le llama propagacion de tipo burbuja y cuando no , es que no es de tipo burbuja

const $padre = document.querySelector(".Principal"),
$contenido = document.querySelectorAll(".Principal div"),
$ancla = document.querySelector("a");
//Ejemplo de propagacion de tipo burbuja
$contenido.forEach((elemento)=>{
    elemento.addEventListener("click",function(e){
        console.log(`Esto es el div ${this.className} y lo propago`);
        e.stopPropagation();//Aqui para evitar la propagacion
    },true)

})
//Para evitar el propagarse de tipo burbuja la funcion addEventListener tiene un tercer parametro boleano el cual es false por defecto y este significa el tipo de propagacion en este caso si se hace que la propagacion sea no de tipo burbuja tendra que cambiarse de false a true

//Por ultimo existen 2 interesantes metodos de el objeto evento , el cual el primero es stopPropagation y el otro es preventDefault , empezando por stopPropagation este es importante , pues lo que hace es evitar cualquier tipo de propagacion , ya sea burbuja o no burbuja y estese puede ver en la funcion que tomo el evento de los divs

//El siguiente es el preventDefault el cual lo que hace es evitar cualquier comportamiento por default de alguna etiqueta html justamente con el objeto de eventos
$ancla.addEventListener("click",(evento)=>{
    evento.preventDefault();//Se le quita su comportamiento por default
    window.alert("La ancla fue despojada de sus comportamientos por defecto");
})
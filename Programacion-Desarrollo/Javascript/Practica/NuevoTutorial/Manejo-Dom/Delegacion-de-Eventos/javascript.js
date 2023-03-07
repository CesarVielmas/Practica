//Ahora lo que se vera sera una forma facil para asignar eventos con la delegacion , esta misma ayuda muchisimo a ahorrar memoria en el navegador cuando se trata de muchas cosas en pantalla  por ello es necesario considerarlo y tratar de usar siempre la delegacion para que ahorre los maximos recursos posibles en la declaracion de un evento

//Ejemplo

//se necesita cargar un evento en document para poder hacer la delegacion
document.addEventListener("click",(evento)=>{
    console.log(`Se hizo click en ${evento.target}`);
    //Si el elemento es un p entonces
    if(evento.target.matches("p"))
    {
        window.alert("Soy un p");
    }
    //Si el elemento es un button entonces
    if(evento.target.matches("button"))
    {
        window.alert("Soy un button")
    }
    //Si el elemento tiene la clase ancla1 entonces
    if(evento.target.matches(".ancla1")){
        window.alert("Es un ancla");
        evento.preventDefault();
    }
    //Y asi se podrian añadir clases infinitamente y lo mejor es que sin crearlas directamente dentro de las etiquetas , esto quiere decir que ahorra muchisimos recursos por eso es muy recomendable usar la delegacion mediante document
})

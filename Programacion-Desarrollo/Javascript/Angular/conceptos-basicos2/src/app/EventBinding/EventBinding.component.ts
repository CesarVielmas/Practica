import { Component } from "@angular/core";

@Component({
    templateUrl:"./EventBinding.component.html",
    styleUrls:['./EventBinding.component.css'],
    selector:"EventBinding-Component"
})

export class EventBindingComponent{
    public valor = "Esperando respuesta";

    setValor(evento:Event){
        //Para poder obtener el value de un evento hecho por un objeto del html es necesario convertir el target del evento en un tipo del elemento del html que origino el evento , en este caso fue un input y asi mismo despues de haberlo convertido obtener su valor con value , para obtener ya su valor
       if((<HTMLInputElement>evento.target).value === "Activado"){
            this.valor = "Se a activado";
       }
       else{
            this.valor = "Se desactivo";
       }
    }
}
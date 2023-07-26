import { Component } from "@angular/core";


@Component({
    selector:"Binding-Component",
    styleUrls:['./Binding.component.css'],
    templateUrl:"./Binding.component.html"
})

export class BindingComponent{
    //El valor el cual obteniendo el binding, por conveniencia o por temas de buenas practicas es bueno poner el binding de la propiedad empezara por property
public propertyChecked = false;

    setChecked(valor=false){

        this.propertyChecked = valor;
    }
}
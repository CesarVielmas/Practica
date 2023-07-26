import {Component} from '@angular/core'

@Component({
    styleUrls:['./Directivas1.component.css'],
    templateUrl:"./Directivas1.component.html",
    selector:"Directivas1-Component"
})

export class Directivas1Component{
public valorBooleano = false;
public numeros = [0,1,2,3,4,5,6,7,8,9,10];
    setBooleano(valor:boolean){

        this.valorBooleano = valor;
    }

}
import {Component} from '@angular/core'

@Component({
    styleUrls:['./Padre.component.css'],
    templateUrl:'./Padre.component.html',
    selector:'Padre-Component'
})

export class PadreComponent{
    public array = [""];
    enviar(array:string[]){
        this.array = array;
    }
    
}
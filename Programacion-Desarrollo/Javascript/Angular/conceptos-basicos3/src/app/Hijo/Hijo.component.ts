import { Component,Input } from "@angular/core";

@Component({
    styleUrls:['./Hijo.component.css'],
    templateUrl:'./Hijo.component.html',
    selector:'Hijo-Component'
})

export class HijoComponent{
    @Input() informacion:string[]; 
}
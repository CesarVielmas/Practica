import {Component, EventEmitter, OnInit, Output} from '@angular/core'
import { ServicioEjemploService } from '../servicios/servicio-ejemplo.service';

@Component({
    styleUrls:['./HijoPadre.component.css'],
    templateUrl:'./HijoPadre.component.html',
    selector:'HijoPadre-Component'
})

export class HijoPadreComponent implements OnInit{
    public dato = "";
    //Inyeccion del servicio , para poder obtener dicho servicio se necesita inicializar en el constructor y ya despues poder usarse 
    constructor(public servicioEjemlo:ServicioEjemploService){

    }
    //Tambien se pueden inyectar con el metodo onInit el cual es un metodo que se ejecuta al iniciar el programa
    ngOnInit(){
        this.dato = this.servicioEjemlo.dato;
    }
    public input = "";
    public array = [""];
    @Output() arrayEnviar = new EventEmitter<string[]>();
    enviar(dato:string){
        this.array.push(dato);
        this.servicioEjemlo.verInformacion(`dato pasado:${dato}`);
        this.arrayEnviar.emit(this.array);
    }
}
import { Component } from "@angular/core";
import { ServicioEjemploService } from "../servicios/servicio-ejemplo.service";


@Component({
    styleUrls:['./PadreHijo.component.css'],
    templateUrl:'./PadreHijo.component.html',
    selector:'PadreHijo-Component'
})

export class PadreHijoComponent{
    public datoServicio = "";
    //Inyeccion del servicio de ejemplo para visualizar la informacion
    constructor(private servicioEjemplo:ServicioEjemploService)
    {
        this.datoServicio = servicioEjemplo.dato;
    }
    public input ="";
    public array = ["papa","natas","Elias"];
    enviar(dato:string){
        console.log(this.array);
        this.servicioEjemplo.verInformacion(`Informacion pasada:${dato}`);
        this.array.push(dato);
    }
}
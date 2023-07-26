import { Component } from "@angular/core";

@Component({
    templateUrl:"./Interpolacion.component.html",
    styleUrls:['./Interpolacion.component.css'],
    selector:"Interpolacion-Component"
})

export class InterpolacionComponent{
    //Valor publico de edad el cual es 20 
    public edad = 20;
    //Recorrer array publico para recorrer en el programa
    public recorrer=[1,2,3,4,5];
    //Nombre propiedad privada
    private nombre = "Cesar";
    //Getter para nombre , para asi mismo obtener la edad que es privada y no se puede modificar
    getNombre(){
        
        return this.nombre;
    }
}
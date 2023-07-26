import { Component } from '@angular/core';
import { DatosServicio } from '../servicios/datos.services';

@Component({
  selector: 'informacion-componente',
  templateUrl: './informacion.component.html',
  styleUrls: ['./informacion.component.css']
})
export class InformacionComponent {
  //Aqui es donde se obtendra la informacion para poder obtener la informacion desde la base de datos en este caso desde el constructor para no batallar
  public datas = [0];
  constructor(private clienteHttp:DatosServicio){
    //Aqui obtiene el get del servicio para hacer lo demas
   let dato =  this.clienteHttp.metodoGet();
   //Con Object.values lo que hace es que convierte un objeto a un array de valores
   dato.subscribe(datos=>this.datas= Object.values(datos));
  }
}

import { Component } from '@angular/core';
import { Router,ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-parametros',
  templateUrl: './parametros.component.html',
  styleUrls: ['./parametros.component.css']
})
export class ParametrosComponent {
  //Ahora para recibir los datos se necesita de otro servicio el cual es ActivatedRoute el cual contiene una propiedad que se llama snapshot y dentro de snapshot un array llamado params para buscar dicho parametro enviado
  public datos = "";
  public datosMediaQuery = "";
  constructor(private parametros:ActivatedRoute){
    //Asignandole el parametro enviado a datos
    this.datos = parametros.snapshot.params['datos'];
    this.datosMediaQuery = parametros.snapshot.queryParams['datos'];
  }
}

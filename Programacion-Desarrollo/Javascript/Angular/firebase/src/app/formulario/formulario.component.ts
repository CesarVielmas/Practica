import { Component } from '@angular/core';
import { DatosServicio } from '../servicios/datos.services';

@Component({
  selector: 'formulario-componente',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.css']
})
export class FormularioComponent {
  //Aqui se enviara la informacion de el componente a la base de datos
  public nombre = "";
  public correo = "";
  public contrasenia = "";
  //Constructor para mandar a llamar al servicio de la base de datos
  constructor(private clienteHttp:DatosServicio){}
  enviarDatos(nombre1:string,correo1:string,contrasenia1:string){
    let usuario = {
      nombre:nombre1,
      correo:correo1,
      password:contrasenia1
    }
    console.log("Datos Enviados");
    this.clienteHttp.metodoPut(usuario);
  }
}

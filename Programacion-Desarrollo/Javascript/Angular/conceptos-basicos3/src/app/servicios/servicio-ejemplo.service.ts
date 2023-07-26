import { Injectable } from '@angular/core';
//El injectable lo que hace es que el servicio se pueda poner o inyectar otro servicio dentro de esta
@Injectable({
  providedIn: 'root'
})
export class ServicioEjemploService {
  //Aqui ira todos los metodos o informacion de el servicio que hara respectivamente su funcionamiento
  constructor() { }
  //Metodo del servicio
  verInformacion(informacion:string){
    alert(`mandando informacion desde el servicio:\n${informacion}`);
  }
  //Propiedades de los servicios que tambien pueden obtenerlo los componentes
  public dato = "Soy un dato desde el servicio";
}

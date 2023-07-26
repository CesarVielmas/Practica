import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'Contacto-Component',
  templateUrl: './Contacto.component.html',
  styleUrls: ['./Contacto.component.css']
})
export class ContactoComponent {

  //Para poder hacer la reedireccion se necesita el servicio de router el cual se debe poner dentro de el constructor para llamarlo
  constructor(private route:Router){

  }
  redireccionar(){
    //Aqui se le indica que se desea navegar a el inicio y asi mismo ocurre la redireccion
    this.route.navigate(['']);
  }
}
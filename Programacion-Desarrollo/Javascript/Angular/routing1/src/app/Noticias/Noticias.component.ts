import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'Noticias-Component',
  templateUrl: './Noticias.component.html',
  styleUrls: ['./Noticias.component.css']
})
export class NoticiasComponent {
  public parametro = "";
  //Para mandar la informacion se necesita volver a usar navigate para redireccionar a la pagina hacia donde tomara dicho parametro
  constructor(private route:Router){}
  enviarInfo(data:string){
    //Navigate acepta otro parametro el cual son los datos que se le pasara a donde navegara siempre y cuando tenga la opcion habilitada en app module
    this.route.navigate(['/parametro',data]);
  }
}
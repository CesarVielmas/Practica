import { HttpClient} from "@angular/common/http";
import {Injectable} from '@angular/core'
@Injectable()
//Para empezar se debe crear un servicio para poder recopilar los datos que mande o obtenga la base de datos a la cual vamos a llamar

export class DatosServicio{
    //Despues de eso como es un servicio y se podra reutilizar en multiples componentes , inyectamos el httClient para poder hacer metodos donde hagan un post o un get etc a la base de datos
    constructor(private clienteHttp:HttpClient){}

    //Metodo para hacer post
    metodoPost(datos:object){
        //Aqui como se ve el clienteHttp tiene los metodos post , get , put etc y estos piden una url y los datos a enviar y por otro lado tiene su observador el cual es subscribe el cual
        this.clienteHttp.post("https://angular-e3913-default-rtdb.firebaseio.com/datos.json",datos).subscribe(
        Response => console.log(Response),
        error=> console.log(error)
         )
    }
    //metodo para hacer get
    metodoGet(){
      return this.clienteHttp.get("https://angular-e3913-default-rtdb.firebaseio.com/datos.json");
    }

    metodoPut(datos:object){
        //Aqui como se ve el clienteHttp tiene los metodos post , get , put etc y estos piden una url y los datos a enviar y por otro lado tiene su observador el cual es subscribe el cual
        this.clienteHttp.put("https://angular-e3913-default-rtdb.firebaseio.com/datos.json",datos).subscribe(
        Response => console.log(Response),
        error=> console.log(error)
         )
    }
}
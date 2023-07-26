//Los guardianes deben de estar en una estructura de clase para poder utilizar su dichoso funcionamiento en angular

import { CanActivateFn,CanActivate } from "@angular/router";

export class Ejemplo implements CanActivate{

    //Estos tienen un metodo que dependiendo de que deben retornar un valor booleano , para ver mas su utilizacion ver en chat gpt
    canActivate(){

        return true;
    }
}
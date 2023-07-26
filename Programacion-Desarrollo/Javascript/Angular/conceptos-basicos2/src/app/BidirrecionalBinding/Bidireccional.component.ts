import { Component } from "@angular/core";

@Component({
    styleUrls:['./BidireccionalBinding.component.css'],
    templateUrl:'./BidireccionalBinding.component.html',
    selector:"BidireccionalBinding-Component"
})

export class BidireccionalBindingComponent{

    public valor = "Oaxaca";
    public valor2 = "DF"
    setValor(event:Event){
        this.valor = (<HTMLInputElement>event.target).value;
    }
    
}
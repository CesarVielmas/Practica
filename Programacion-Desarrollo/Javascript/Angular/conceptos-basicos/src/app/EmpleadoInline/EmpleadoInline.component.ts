import { Component } from "@angular/core";
//Como se puede apreciar los componentes inLine es donde todo se pone en el mismo componente , no es recomendable usarlos , sin embargo para aplicaciones muy simples es ahi donde se puede utilizar
@Component({
    template:'<p>Empleado en componente Inline</p>',
    styles:['p{color:blue;}'],
    selector:"EmpleadoInline-Component"
})

export class EmpleadoInlineComponent{
    
}

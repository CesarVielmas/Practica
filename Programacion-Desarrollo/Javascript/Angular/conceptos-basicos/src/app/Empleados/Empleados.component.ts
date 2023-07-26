import { Component } from "@angular/core";

//Asignandole al componente los recursos que utilizara para su desarrollo 
@Component({
    //TemplateURL para pasarle la url del componente , osease el html que tendra
    templateUrl:"./Empleados.component.html",
    //Asignando los estilos , es importante aclarar que en los estilos sus comillas deben estar encerradas entre parentesis de array
    styleUrls:["./Empleados.component.css"],
    //Selector , el cual es el nombre que tendra para poder ser llamado en algun otro componente o html
    selector:"Empleados-component"
})
//Exportar la clase , el cual contendra el componente
export class EmpleadosComponent{

}
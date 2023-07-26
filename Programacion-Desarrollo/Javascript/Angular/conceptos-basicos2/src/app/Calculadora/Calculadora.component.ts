import {Component} from '@angular/core'

@Component({
    templateUrl:"./Calculadora.component.html",
    styleUrls:['./Calculadora.component.css'],
    selector:"Calculadora-Component"
})

export class CalculadoraComponent{
    public resultado=0;
    public numeros = 0;
    public operacionesNumeros = [0];
    public operacion = "";
    public operacionRealizar = "";
    setNumeros(numero=0){
        this.operacion = "";
        if (this.numeros === 0) {
            this.numeros = numero;
        }
        else{
            this.numeros =parseInt(this.numeros.toString() + numero);
        }
        
    }
    setOperaciones(operacionCalculadora:string){
        this.operacion = operacionCalculadora;
        this.operacionesNumeros.push(this.numeros);
        this.numeros = 0;
        if (this.operacionRealizar==="") {
            this.operacionRealizar = operacionCalculadora;
            
        }
        else{
            switch (this.operacionRealizar) {
                case "+":
                this.operacionesNumeros.map(numero =>{
                    this.resultado = this.resultado + numero;
                   
                });
                this.operacionesNumeros = [];
                    break;
                case "-":
                 this.operacionesNumeros.map(numero =>{
                    this.resultado = this.resultado - numero;
                   
                });
                this.operacionesNumeros = [];
                    break;
                case "*":
                 this.operacionesNumeros.map(numero =>{
                    this.resultado = this.resultado * numero;
                   
                });
                this.operacionesNumeros = [];  
                    break;
                case "/":
                 this.operacionesNumeros.map(numero =>{
                    this.resultado = this.resultado / numero;
                   
                });
                this.operacionesNumeros = [];
                    break;
            
                default:
                console.log("error");
                    break;
            }
            this.operacionRealizar = operacionCalculadora;
        }

    }
    setTodo(){
        this.resultado=0;
        this.numeros = 0;
        this.operacionesNumeros = [0];
        this.operacion = "";
        this.operacionRealizar = "";
    }
    
}
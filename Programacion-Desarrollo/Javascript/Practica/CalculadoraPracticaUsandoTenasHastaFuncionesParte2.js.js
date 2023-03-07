//Creacion de la calculadora mediante javascript usando lo aprendido
var cifra =" ";
var acumulado = 0;
var sumaxd = false;
var suma2xd = false;
var restaxd = false;
var resta2xd = false;
var dividirxd = false;
var dividir2xd = false;
var multiplicarxd = false;
var multiplicar2xd = false;
var contador = 0;
//Funcion para imprimir el numero cuando se le de al boton
function DarValor(valor)
{
    document.getElementById("Numeros").value=cifra + valor;
    cifra = document.getElementById("Numeros").value;
}
function BorrarTodo()
{
    cifra = " ";
    acumulado= " ";
    campoDeTexto = document.getElementById("Numeros");
    campoDeTexto.value = "";
}
function suma()
{
    if(sumaxd == true && suma2xd==true) 
    {
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    sumaxd = false;
    suma2xd = false;
     }
    else
    {
    acumulado =parseInt( acumulado) +parseInt( cifra);
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    sumaxd = true;
    }
    
}
function resta()
{
    if(restaxd == true && resta2xd==true) 
    {
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    restaxd = false;
    resta2xd = false;
     }
    else
    {
        if(contador == 0)
        {
            acumulado = parseInt(cifra)-parseInt(acumulado);
            cifra = " ";
            document.getElementById("Numeros").value = acumulado;
            restaxd = true;
            contador++;
         }
         else
         { 
    acumulado =parseInt( acumulado) - parseInt( cifra);
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    restaxd = true;
     }
    }
    
}
function dividir()
{
    if(dividirxd == true && dividir2xd==true) 
    {
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    dividirxd = false;
    dividir2xd = false;
     }
    else
    {
        if(contador == 0)
        {
            acumulado = parseInt(acumulado) + parseInt(cifra);
            cifra = " ";
            document.getElementById("Numeros").value = acumulado;
            dividirxd = true;
            contador++;
         }
         else
         {
    acumulado =parseFloat( acumulado) /parseFloat( cifra);
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    dividirxd = true;
     }
    }
    
}
function multiplicar()
{
    if(multiplicarxd == true && multiplicar2xd==true) 
    {
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    dividirxd = false;
    dividir2xd = false;
     }
    else
    {
        if(contador == 0)
        {
            acumulado = parseInt(acumulado) + parseInt(cifra);
            cifra = " ";
            document.getElementById("Numeros").value = acumulado;
            multiplicarxd = true;
            contador++;
         }
         else
         {
    acumulado =parseFloat( acumulado) *parseFloat( cifra);
    cifra = " ";
    document.getElementById("Numeros").value = acumulado;
    multiplicarxd = true;
     }
    }
    
}
function Resultado()
{
    if(sumaxd == true)
    {
    acumulado =parseInt( acumulado) +parseInt( cifra);
    document.getElementById("Numeros").value = acumulado;
    suma2xd = true;
    }
    if (restaxd == true)
     {
        acumulado =parseInt( acumulado) -parseInt( cifra);
        document.getElementById("Numeros").value = acumulado;
        resta2xd = true;
    }
    if(dividirxd == true)
    {
        acumulado =parseFloat( acumulado) /parseFloat( cifra);
        document.getElementById("Numeros").value = acumulado;
        dividir2xd = true;
    }
    if(multiplicarxd == true)
    {
        acumulado =parseFloat( acumulado) *parseFloat( cifra);
        document.getElementById("Numeros").value = acumulado;
        multiplicar2xd = true;
    }
}



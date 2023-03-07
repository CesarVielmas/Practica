export const funcionRueda = (PI,valorRueda,confirmacion)=>
{
    PI = PI || 3.1416;
    valorRueda = valorRueda || 0;
    confirmacion  = confirmacion || false;
    (confirmacion === true)?console.log(valorRueda * PI):console.log("Usted no confirmo para solucionar el problema");
    
}
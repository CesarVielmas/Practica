import React, { useMemo } from 'react'
//Como se puede apreciar el useMemo sirve para calculos que le exigen mucho al navegador en este ejemplo le exige mucho por el for , sin embargo con useMemo , solo se le exigiria 1 vez , osease , que al renderizar no volvera a hacer el calculo y esa es la utilidad de useMemo
function Calculo() {
/**
  let calculo = 0;
    for (let i = 0; i < 10000000000; i++) {
        calculo++;
        
    }

 */
//Como se puede ver useMemo recibe una funcion en su parametro y esta misma funcion para lo que sirve , es el calculo avanzado que realizara y con [] en su segundo parametro se le indica que solo lo hara 1 vez , aunque puede cambiar dependiendo de las necesidades de que cosa este observando para renderizarlo
   const calculo = useMemo(() =>{
    let calculo = 0;
   for (let i = 0; i < 1000000; i++) {
       calculo++;
       
   }
   return calculo;
   }  ,[]);

    console.log("Calculo");
  return (
    <div>
    <h2>Calculo</h2>
    <h3>{calculo}</h3>
    </div>
  )
}

export default Calculo
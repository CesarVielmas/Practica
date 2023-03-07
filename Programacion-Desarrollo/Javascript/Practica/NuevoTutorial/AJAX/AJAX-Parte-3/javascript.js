//Ahora lo que se vera sera una manera utilizar fetch un poquito mejor con funciones asincronas

//Primero se debe ejecutar una funcion asincrona

async function datos(){
    //Se ejecutara si no hay errores
    //Remplaza a todos los then
    try{
        //Primero se debe guardar una variable de lo que mande fetch al ser ejecutado importante usar await , pues esperara dicho contenido del ajax para ingresarlo a a la variable
       const ajax = await fetch("https://jsonplaceholder.typicode.com/users"),
       json = await ajax.json();

       console.log(json);
       //El siguiente paso es evaluar con un if , si la propiedad ok , es falsa o verdadera para que cuando sea falsa mandar un throw y asi mismo entrar al catch
       if (!ajax.ok) throw {status:ajax.status}//Mandara un objeto al catch donde obtendra el status y lo que quiera obtener, tambien se puede mandar un new Error() pero esto no es muy recomendable ya que solo manda texto

       //Ahora despues de hacer dicha comprobacion se pondra aqui todo el codigo que ejecutara fetch , o todo lo que se hara
       const $lista = document.querySelector(".lista"),
       $fragmento = document.createDocumentFragment();

       json.forEach((elementos)=>{
        const $li = document.createElement("li");

        $li.textContent = `${elementos.id} ${elementos.username} ${elementos.email}`
        $fragmento.appendChild($li);
       })
      $lista.appendChild($fragmento);
    }
    //Se ejecutara si hay errores con throw
    //Remplaza a el catch()
    catch(error){
        console.log(`error tipo ${error.status}`);
    }
    //Se ejecutara siempre 
    //Remplaza a su finally
    finally{

    }
}
datos();
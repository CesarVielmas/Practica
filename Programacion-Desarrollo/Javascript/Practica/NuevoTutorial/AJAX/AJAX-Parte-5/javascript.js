//Ahora lo que se vera sera como funciona el axios de manera asincronica , asi mismo como lo fue con fetch pero ahora con axios
//Para lograr esto lo unico que cambia es el ahorrar los pasos de asignar los datos a alguna otra variable y hacer un condicional extra para ejecutar un error

//Ejemplo

const $lista = document.querySelector(".axios"),
$fragmento = document.createDocumentFragment();

//Funcion asincrona para desarollar axios como fetch

async function datos(){
    try{
      const objetoAxios =  await axios.get("https://jsonplaceholder.typicode.com/users");
      //Se ahorra el crear un objeto con el metodo json , ya que lo tiene data

      //Tambien se ahorra el poner un condicional para mandar un error o un throw ya que lo hace por default axios

      objetoAxios.data.forEach((elementos)=>{
        const $li = document.createElement("li");
        $li.textContent = `${elementos.id}  ${elementos.username}   ${elementos.email}`;
        $fragmento.appendChild($li);
      })
      $lista.appendChild($fragmento);
    }
    catch(error){
        console.log("Error , el error ocurrio",error);
    }
    finally{
        console.log("Se ejecutara pase lo que pase");
    }
}

datos();
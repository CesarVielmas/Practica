//Ahora lo que se vera sera la libreria de axios la cual es recomendable saber usar , asi mismo como fetch usa promesas por lo cual tiene su propio metodo then , catch y finally 
const $lista = document.querySelector(".axios"),
$fragmento = document.createDocumentFragment();
//Primero instanciar el metodo dado por la libreria axios el cual es el metodo get aunque se puede usar tambien axios("url") pero no es muy recomendable , ya que de esa manera se usa cuando toma un objeto con sus parametros
axios.get("https://jsonplaceholder.typicode.com/users").
//A diferencia de fetch que se necesitaban 2 then para poder hacer la funcionalidad bien que recoja los datos , aqui solo se necesita 1 then y si hay un error ira directamente al catch
then(objeto=>{
    console.log(objeto);
    //Como se puede ver el objeto que ya viene con la libreria axios , ya incluye los datos en el apartado data de dicho objeto entonces ya no se necesita otro then y ya se podra programar desde ahi
    objeto.data.forEach((elementos)=>{
        const $li = document.createElement("li");
        $li.textContent = `${elementos.id}  ${elementos.username}   ${elementos.email}`;
        $fragmento.appendChild($li);
    })
    $lista.appendChild($fragmento);
}).
catch(error=>{
    console.log("error ",error);
}).
finally(objeto=>{
    console.log("Se ejecuta pase lo que pase",objeto);
})
//Como se puede ver es muy parecido a fetch pero omitiendo algunos pasos
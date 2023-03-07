let buttons = [],name,secondName,cuot;
const $tableBody = document.querySelector(".content"),
$fragment = document.createDocumentFragment(),
$buttonAdd = document.querySelector(".buttonAdd"),
$buttonRM = document.querySelector(".buttonRemove");
fetch("http://localhost:3000/clientes",{
    method:"GET"
}).
then((ajaxObject)=>{
    return (ajaxObject.ok)
    ?ajaxObject.json()
    :"";
}).
then((jsonObject)=>{
    let contador = 0;
    jsonObject.forEach((elements)=>{
        const $tr = document.createElement("tr"),
        $id  = document.createElement("td"),
        $name = document.createElement("td"),
        $cuot = document.createElement("td"),
        $secondName = document.createElement("td"),
        $edit = document.createElement("button");

        $edit.textContent = `Edit ${elements.nombre}`;
        $edit.classList.add(`${contador+1}`);
        $tr.classList.add("bodyTable");
        $id.textContent = elements.id;
        $tr.appendChild($id);
        $name.textContent = elements.nombre;
        $tr.appendChild($name);
        $cuot.textContent = elements.cuota;
        $tr.appendChild($cuot);
        $secondName.textContent = elements.apellido;
        $tr.appendChild($secondName);
        $tr.appendChild($edit);
        $fragment.appendChild($tr);
        buttons[contador] = $edit;
        contador++;
    })
    $tableBody.appendChild($fragment);

}).
catch((err)=> console.error(err)).
finally(()=>{
    console.log("Hi!");
})

document.addEventListener("click",(e)=>{
    //PUT
    buttons.forEach((elements)=>{
        if (e.target === elements) {
            let id = elements.classList.value;
            name = prompt("Send Me The New Name");
            cuot = prompt("Send Me The New Cuot");
            secondName = prompt("Send Me The New Second Name");
            
            let response ={
                nombre:`${name}`,
                apellido:`${secondName}`,
                cuota:`${cuot}`,
                id:`${id}`
            }
            fetch(`http://localhost:3000/clientes/${id}`,{
                method:"PUT",
                headers:{ 'Content-type': 'application/json; charset=UTF-8' },
                body: JSON.stringify(response)
            })
            
        }
    })
    if (e.target === $buttonAdd) {
        name = prompt("Send the name for new client");
        secondName = prompt("Send the second name for new client");
        cuot = prompt("Send the cuot for new client");

        let response = {
            nombre:`${name}`,
            apellido:`${secondName}`,
            cuota:`${cuot}`,
            id:`${buttons.length+1}`
        }
        fetch(`http://localhost:3000/clientes`,{
            method:"POST",
            headers:{ 'Content-type': 'application/json; charset=UTF-8' },
            body: JSON.stringify(response)
        })
    }
    if (e.target === $buttonRM) {
        fetch(`http://localhost:3000/clientes/${buttons.length}`,{
            method:"DELETE"
        })
    }
})
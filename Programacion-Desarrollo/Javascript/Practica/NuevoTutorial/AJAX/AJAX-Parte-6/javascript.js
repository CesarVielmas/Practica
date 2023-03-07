const ajax = new XMLHttpRequest(),
$fragment = document.createDocumentFragment();

let buttonsEdit = [];
let name,age,secondName;

ajax.addEventListener("readystatechange",(event)=>{
    if (ajax.readyState!==4) return""; 
    let counter = 0;
  
    const jsonObject = JSON.parse(ajax.response);
    jsonObject.forEach((element)=>{
        //Declaration of variables or constants for another elements in the json
        const $id = document.createElement("td"),
        $name = document.createElement("td"),
        $age = document.createElement("td"),
        $secondName = document.createElement("td"),
        $tr = document.createElement("tr"),
        $edit = document.createElement("button");
        
        $edit.classList.add(`buttonEdit${element.id}`);
        $tr.classList.add("spaceText");
        //Elements in TR
        $name.textContent= `${element.nombre}`;
        $id.textContent = `${element.id}`;
        $age.textContent = `${element.edad}`;
        $secondName.textContent = `${element.apellido}`;
        $edit.textContent = `✏`;
        $tr.appendChild($id);
        $tr.appendChild($name);
        $tr.appendChild($age);
        $tr.appendChild($secondName);
        $tr.appendChild($edit);
        $fragment.appendChild($tr);
        buttonsEdit [counter]= $edit;
        counter++;
    })
    document.querySelector(".content").appendChild($fragment);

})
document.addEventListener("click",(e)=>{
   buttonsEdit.forEach((elements)=>{
       if (e.target === elements) {
           let id = elements.classList.value.charAt(elements.classList.value.length -1)
        ajax.open("PUT",`http://localhost:3000/familiares/${id}`);
        ajax.setRequestHeader('Content-type', 'application/x-www-form-urlencoded')
        name = prompt("send the new name");
        age = prompt("send the new age");
        secondName = prompt("send the new second name");
        ajax.send(`id=${id}&nombre=${name}&edad=${age}&apellido=${secondName}`);
        
       }
   })
   if (e.target.classList.value === "buttonAdd") {
        let id = buttonsEdit.length+1;
        ajax.open("POST",`http://localhost:3000/familiares`);
        ajax.setRequestHeader('Content-type', 'application/x-www-form-urlencoded')
        name = prompt("send the new name for create");
        age = prompt("send the new age for create");
        secondName = prompt("send the new second name for create");
        ajax.send(`id=${id}&nombre=${name}&edad=${age}&apellido=${secondName}`);
   }
   if (e.target.classList.value === "buttonRemove") {
    let id = buttonsEdit.length;
    ajax.open("DELETE",`http://localhost:3000/familiares/${id}`);
    ajax.send();
    }
})
ajax.open("GET","http://localhost:3000/familiares");

ajax.send();
let contador = 0,buttonsEdit = [],buttonsRemove = [],
imagen,nombre,puesto,antiguedad,sueldo;
const $fragment = document.createDocumentFragment(),
$buttonAdd = document.querySelector(".add");
axios.get("http://localhost:3000/usuarios").
then(axiosObject=>{
    dataUsers = axiosObject.data;
    dataUsers.forEach((elements)=>{
        const $div = document.createElement("div"),
        $img = document.createElement("img"),
        $h1 = document.createElement("h1"),
        $ul = document.createElement("ul"),
        $li1 = document.createElement("li"),
        $li2 = document.createElement("li"),
        $li3 = document.createElement("li"),
        $buttonEdit = document.createElement("a"),
        $buttonRM = document.createElement("a");

        $img.src = elements.imagen;
        $img.alt = "People";
        $h1.textContent = elements.nombre;
        $li1.textContent = elements.puesto;
        $li2.textContent = `Antiguedad de ${elements.antiguedad}`;
        $li3.textContent = `Sueldo mensual de ${elements.sueldo}`;
        $ul.appendChild($li1);
        $ul.appendChild($li2);
        $ul.appendChild($li3);

        $buttonEdit.textContent = "🖍";
        $buttonRM.textContent = "✖";
        $buttonEdit.classList.add("edit");
        $buttonRM.classList.add("remove");
        $buttonRM.id = elements.id;
        $buttonEdit.id = elements.id;

        $div.appendChild($buttonEdit);
        $div.appendChild($buttonRM);
        $div.appendChild($h1);
        $div.appendChild($img);
        $div.appendChild($ul);
        $div.classList.add("tarjeta");
        $fragment.appendChild($div);
        buttonsEdit[contador+1] = $buttonEdit;
        buttonsRemove[contador+1]=$buttonRM;
        contador++;
    })
    document.body.appendChild($fragment);
})

document.addEventListener("click",(e)=>{
    
    if (e.target === $buttonAdd) {
        console.log("add user");
        imagen= prompt("Send me the image src");
            nombre = prompt("Send me the name of user");
            puesto= prompt("Send me the name of puest the user");
            antiguedad = prompt("Send me the oldest of busisness the user");
            sueldo = prompt("Send me the user sueld");

            axios({
                method:"post",
                url:`http://localhost:3000/usuarios`,
                data:{
                    imagen:`${imagen}`,
                    nombre:`${nombre}`,
                    puesto:`${puesto}`,
                    antiguedad:`${antiguedad}`,
                    sueldo:`${sueldo}`
                }
            })
    }

    buttonsEdit.forEach((elements)=>{

        if (e.target === elements) {
            let id = elements.id;
            imagen= prompt("Send me the new image src");
            nombre = prompt("Send me the new name of user");
            puesto= prompt("Send me the new name of puest the user");
            antiguedad = prompt("Send me the new oldest of busisness the user");
            sueldo = prompt("Send me the new user sueld");

            axios({
                method:"put",
                url:`http://localhost:3000/usuarios/${id}`,
                data:{
                    id:`${id}`,
                    imagen:`${imagen}`,
                    nombre:`${nombre}`,
                    puesto:`${puesto}`,
                    antiguedad:`${antiguedad}`,
                    sueldo:`${sueldo}`
                }
            })
        }

    })
    buttonsRemove.forEach((elements)=>{
        if (e.target === elements) {
            let id = elements.id;
            console.log(id);
            let confirm = window.confirm("¿You really required eliminate user?");
            if (confirm)axios({
                method:"delete",
                url:`http://localhost:3000/usuarios/${id}`
            });

        }

    })
    
})
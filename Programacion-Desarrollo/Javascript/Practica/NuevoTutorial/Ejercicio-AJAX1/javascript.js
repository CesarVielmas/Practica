fetch(`Paginas/Home.html`).
then(fetchObjeto=>{
    return (fetchObjeto.ok)
    ?fetchObjeto.text()
    :fetchObjeto;
}).
then(objetoCompleto=>{
    document.querySelector(".content").innerHTML = objetoCompleto;
}).
catch(err=>{
    alert(`error ${err.status} `);
}).
finally()

document.addEventListener("click",(e)=>{
    e.preventDefault();
    let value = e.target.href;
    fetch(`${value}`).
    then(fetchObjeto=>(fetchObjeto.ok)?fetchObjeto.text():fetchObjeto).
    then(objetoCompleto=>{
        document.querySelector(".content").innerHTML = objetoCompleto;
    }).
    catch(err=> alert(`error ${err.status}`));
})
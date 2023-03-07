fetch(`Paginas/header.html`).
then(objetoFetch=>(objetoFetch.ok)
?objetoFetch.text()
:objetoFetch).
then(objetoHeader=>{
    document.querySelector(".content").innerHTML = objetoHeader;
}).
catch(err=> alert(`error ${err.status}`));
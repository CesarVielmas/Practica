const $bloque = document.querySelector(".informacion"),
$userAgent = document.createElement("h3"),
$navegator = document.createElement("h3"),
$system = document.createElement("h3"),
$desktop = document.createElement("h3"),
$mobile = document.createElement("h3");

$userAgent.textContent = "User Agent: "+window.navigator.userAgent;
$system.textContent = "Sistema: "+window.navigator.platform;
$desktop.textContent = "Se esta dentro de una computadora";
$mobile.textContent = "Se esta dentro de un celular";
if ($userAgent.textContent.includes("Chrome")) {
    $navegator.textContent ="Navegador:"+$userAgent.textContent.slice($userAgent.textContent.indexOf("Chrome"));
}
$userAgent.classList.add("contenidoAgregado");
$navegator.classList.add("contenidoAgregado");
$system.classList.add("contenidoAgregado");
$desktop.classList.add("contenidoAgregado");
$mobile.classList.add("contenidoAgregado");

$bloque.appendChild($userAgent);
$bloque.appendChild($navegator);
$bloque.appendChild($system);
if ($userAgent.textContent.includes("Android")||$system.textContent.includes("Iphone")) {
    $bloque.appendChild($mobile);
}
else{
    
    $bloque.appendChild($desktop);
}
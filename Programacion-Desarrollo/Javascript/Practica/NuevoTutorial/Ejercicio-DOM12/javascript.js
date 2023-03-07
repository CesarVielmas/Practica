const $bloque = document.querySelector(".geolocalizacion"),
geo = window.navigator.geolocation,
$lattitude = document.createElement("h2"),
$longitude = document.createElement("h2"),
$accurracy = document.createElement("h2"),
$ancla = document.createElement("a");

geo.getCurrentPosition((element)=>{
        let latitude = element.coords.latitude,longitud = element.coords.longitude;
        $lattitude.textContent = `latitude = ${element.coords.latitude}`;
        $longitude.textContent = `longitud = ${element.coords.longitude}`;
        $accurracy.textContent = `precision = ${Math.floor(element.coords.accuracy)} metros a la redonda`;
        $bloque.appendChild($lattitude);
        $bloque.appendChild($longitude);
        $bloque.appendChild($accurracy);
        $ancla.href = `https://www.google.com/maps/search/${latitude}+${longitud}`;
        $ancla.target = "_blank";
        $ancla.textContent = "Ir a google maps";
        $bloque.appendChild($ancla)
})


    
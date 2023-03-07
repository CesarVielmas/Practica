const $bloque = document.querySelector(".webcam"),
$video = document.createElement("video");

window.navigator.mediaDevices.getUserMedia(
    {
        video:true,
        audio:true
    }
)
.then((video)=>{
    $video.srcObject = video;
    $video.play();
})
$bloque.appendChild($video);


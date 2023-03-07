const $video = document.getElementById("videoCesar"),
funcionObservador = (elemento)=>{
    elemento.forEach((elementos)=>{
        if (elementos.isIntersecting) {
            $video.play();
        }
        else $video.pause();
    })
};
let observador = new IntersectionObserver(funcionObservador,{
    threshold:.8
})
observador.observe($video);
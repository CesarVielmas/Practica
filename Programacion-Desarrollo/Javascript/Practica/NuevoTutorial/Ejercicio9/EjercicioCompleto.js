/*
27) Programa una clase llamada Pelicula.

La clase recibirá un objeto al momento de instanciarse con los siguentes datos: id de la película en IMDB, titulo, director, año de estreno, país o países de origen, géneros y calificación en IMBD.
  - Todos los datos del objeto son obligatorios.
  - Valida que el id IMDB tenga 9 caracteres, los primeros 2 sean letras y los 
     7 restantes números.
  - Valida que el título no rebase los 100 caracteres.
  - Valida que el director no rebase los 50 caracteres.
  - Valida que el año de estreno sea un número entero de 4 dígitos.
  - Valida que el país o paises sea introducidos en forma de arreglo.
  - Valida que los géneros sean introducidos en forma de arreglo.
  - Valida que los géneros introducidos esten dentro de los géneros 
     aceptados*.
  - Crea un método estático que devuelva los géneros aceptados*.
  - Valida que la calificación sea un número entre 0 y 10 pudiendo ser 
    decimal de una posición.
  - Crea un método que devuelva toda la ficha técnica de la película.
  - Apartir de un arreglo con la información de 3 películas genera 3 
    instancias de la clase de forma automatizada e imprime la ficha técnica 
    de cada película.

* Géneros Aceptados: Action, Adult, Adventure, Animation, Biography, Comedy, Crime, Documentary ,Drama, Family, Fantasy, Film Noir, Game-Show, History, Horror, Musical, Music, Mystery, News, Reality-TV, Romance, Sci-Fi, Short, Sport, Talk-Show, Thriller, War, Western.
                                                <  >
*/
class Pelicula
{
    
    constructor(objetoCompleto){
        let contador = 0;
        this.objetoCompleto = objetoCompleto;
        if (objetoCompleto instanceof Pelicula) {
            return console.error("No dio un objeto de tipo pelicula");
        }
        if (objetoCompleto.id.lenght === 8) {
            for (const elementos of objetoCompleto.id) {
                if (typeof(elementos)==="string"&& contador<3) {
                    
                }
                else if (typeof(elementos)==="number"&& contador<9) {
                    
                }
                else return console.error("El id debe contener 2 letras como inicio");
                contador++;
            }    
        }
        if (objetoCompleto.titulo.lenght >100) {
            return console.error("El titulo no puede rebasar 100 caracteres");
        }
        if (objetoCompleto.director.lenght >50) {
            return console.error("El nombre del director no puede rebasar 50 caracteres");
        }
        if (objetoCompleto.anio.toString().lenght<4 || objetoCompleto.anio.toString().lenght>5) {
            return console.error("El año debe contener 4 digitos");
        }
        if (objetoCompleto.paises instanceof Array === false) {
            return console.error("Los paises deben estar ordenados en un array");
        }
        if (objetoCompleto.generos instanceof Array === false) {
            return console.error("Los generos deben estar ordenados en un array");
        }
        if (objetoCompleto.generos instanceof Array === true) {
            objetoCompleto.generos.forEach(generos => (/Action|Adult|Adventure|Animation|Biography|Comedy|Crime|Documentary|Drama|Family|Fantasy|Film Noir|Game-Show|History|Horror|Musical|Music|Mystery|News|Reality-TV|Romance|Sci-Fi|Short|Sport|Talk-Show|Thriller|War|Western/i.test(generos)===false)
                                                    ?console.error("El genero ingresado no se encuentra en la lista")
                                                    :""
                                                    );
        }
        if (objetoCompleto.calificacion >10||objetoCompleto.calificacion<0) {
            return console.error("La calificacion debe ser del 0 al 10");
        }
        if (objetoCompleto.calificacion <10||objetoCompleto.calificacion>0) {
            if (objetoCompleto.calificacion.toString().lenght>3) {
                return console.error("La calificacion como maximo puede tener un decimal");
            }
        }
    }
    static generosAceptados() 
    {

        console.log(`Los generos aceptados son los siguientes\nGéneros Aceptados: Action, Adult, Adventure, Animation, Biography, Comedy, Crime, Documentary ,Drama, Family, Fantasy, Film Noir, Game-Show, History, Horror, Musical, Music, Mystery, News, Reality-TV, Romance, Sci-Fi, Short, Sport, Talk-Show, Thriller, War, Western.`);
    }
    get getfichaTecnica()
    { 
        console.info(` id:${this.objetoCompleto.id.join("")}\n titulo:${this.objetoCompleto.titulo}\n director:${this.objetoCompleto.director} \n año de estreno:${this.objetoCompleto.anio}\n paises de origen:${this.objetoCompleto.paises}\n generos de la pelicula:${this.objetoCompleto.generos}\n calificacion dada en IMBD:${this.objetoCompleto.calificacion}`);
    }
}
const arregloGenerar = [{
 id:["k","z",3,4,2,7,7,4,1],
 titulo:"La sombra de eliot",
 director:"Elon musk",
 anio:2020,
 paises:["Mexico","Peru","Australia"],
 generos:["Action","Adult","Adventure"],
 calificacion:8.3
},
{
    id:["A","j",3,4,2,7,7,4,1],
    titulo:"Mauricio y las alcachofas",
    director:"Benito Musolini",
    anio:1928,
    paises:["Australia"],
    generos:["Adult"],
    calificacion:6.2
},
{
    id:["P","s",3,4,2,7,7,4,1],
    titulo:"Longaniza con carne",
    director:"Cesar Vielmas",
    anio:2022,
    paises:["Mexico","Australia"],
    generos:["Action"],
    calificacion:5.5
}];
const peliculas1 = new Pelicula(arregloGenerar[0]),
peliculas2 = new Pelicula(arregloGenerar[1]),
peliculas3 = new Pelicula(arregloGenerar[2]);
peliculas1.getfichaTecnica;
peliculas2.getfichaTecnica;
peliculas3.getfichaTecnica;
Pelicula.generosAceptados();
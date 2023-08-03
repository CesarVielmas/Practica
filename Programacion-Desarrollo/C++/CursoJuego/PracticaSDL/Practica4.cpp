#include <SDL2/SDL.h>
#include <SDL2/SDL_mixer.h>
#include <iostream>
//Reproducir la musica con SDL_mixer.h , se utiliza la libreria la cual debe descargarse de manera interna en otra pagina
int main(int argc, char* argv[]) {
    // Inicializar SDL con el subsistema de audio
    if (SDL_Init(SDL_INIT_AUDIO) < 0)//Comprueba si se puede obtener el audio de manera correcta y si lo hace de manera correcta entonces procede con el codigo y si no manda un error
     {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return 1;
    }

    // Inicializar SDL_mixer
    if (Mix_OpenAudio(44100, MIX_DEFAULT_FORMAT, 2, 4096) == -1) //Aqui lo que sucede es que se inicializa Mix_OpenAudio para el cual requiere los parametros , primero la frecuencia de muestreo , como segundo el formato de dicho archivo, como tercero , si sera mono = 1 o si es estereo , el cual ocupa 2 en este caso fue estereo y la tasa de bytes de guardado que tomara en un principio , en este caso toma 4096 bytes para guardar el audio, si es igual a -1 entonces hubo un error
    {
        //Entonces si hay un error muestra un error y lo obtiene de Mix , tambien quita SDL y retorna 1
        std::cerr << "Error al inicializar SDL_mixer: " << Mix_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    // Cargar archivo de audio (por ejemplo, un archivo MP3)
    const char* rutaArchivoAudio = "Ejemplo3.wav";
    //Se crea un objeto de tipo puntero , llamado musica el cual obtiene un objeto de mix music y este mismo pide con mix_load la ruta del archivo 
    Mix_Music* musica = Mix_LoadMUS(rutaArchivoAudio);
    if (!musica)//Si musica esta vacio entonces hubo un error y se muestra un error
     {
        //Entonces cierra el audio de mix y quita SDL
        std::cerr << "No se pudo cargar el archivo de audio: " << Mix_GetError() << std::endl;
        Mix_CloseAudio();
        SDL_Quit();
        return 1;
    }

    // Reproducir el audio
    if (Mix_PlayMusic(musica, 1) == -1)//En este caso , se activa la musica mediante el archivo de musica , el cual fue tomado mediante la ruta , con Mix_PlayMusic, se pide el objeto de tipo Mix_Music y pide la cantidad de veces que se reproducira la musica , en este caso si da un -1 significa que hubo un error con el audio y entrara en el if 
    {
        //Si entra entonces manda un mensaje que hubo un error con el audio
        std::cerr << "Error al reproducir el audio: " << Mix_GetError() << std::endl;
        //Tambien con mix_freeMusic lo que hace es que libera la memoria de lo que hay en musica si es que se esta reproduciendo
        Mix_FreeMusic(musica);
        //y con esta linea lo que hace es que cierra el audio y por ultimo quita SDL y retorna un 1
        Mix_CloseAudio();
        SDL_Quit();
        return 1;
    }

    // Esperar unos segundos para que se reproduzca el audio (puedes reemplazar esto con el manejo de eventos)
    SDL_Delay(10000);//Cantidad de tiempo que se reproducira el audio anes de que entre a lo demas, para que se borre el audio

    // Detener la reproducción y liberar recursos
    Mix_FreeMusic(musica);
    Mix_CloseAudio();
    SDL_Quit();

    return 0;
}

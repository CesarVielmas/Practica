#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>
#include <SDL2/SDL_mixer.h>
#include <iostream>

//Un pequeño ejemplo utilizando todo lo que se vio

//Se inician las propiedades de la ventna
const int SCREEN_WIDTH = 800;
const int SCREEN_HEIGHT = 600;
//Creacion del objeto window
SDL_Window* window = nullptr;
//Creacion del render 
SDL_Renderer* renderer = nullptr;
//Una creacion de una textura
SDL_Texture* texture = nullptr;
Mix_Music* musica1; 
Mix_Music* musica2;
Mix_Music* musica3;

// Rectángulos para recortar y mostrar cada frame del sprite
SDL_Rect spriteRecortes[12];
int currentFrame = 0; 
int frameX = 68;
// Cargar archivo de audio (por ejemplo, un archivo MP3)
    const char* rutaArchivoAudio1 = "Ejemplo.wav";
    const char* rutaArchivoAudio2 = "Ejemplo2.wav";
    const char* rutaArchivoAudio3 = "Ejemplo3.wav";
bool reproduccionMusica1 = false;
bool reproduccionMusica2 = false;
bool iniciarSDL(){

     if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return false;
    }

    window = SDL_CreateWindow("Implementacion", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_SHOWN);
    if (!window) {
        std::cerr << "Error al crear la ventana: " << SDL_GetError() << std::endl;
        return false;
    }

    renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer) {
        std::cerr << "Error al crear el renderer: " << SDL_GetError() << std::endl;
        return false;
    }

    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 0);

    int imgFlags = IMG_INIT_PNG;// IMG_INIT_PNG. Este valor es una constante definida por la biblioteca SDL_image y representa el formato de imagen que se desea inicializar. En este caso, IMG_INIT_PNG indica que queremos inicializar el soporte para archivos PNG.
    if (!(IMG_Init(imgFlags) & imgFlags)) //aqui lo que se hace es que se inicializa IMG_Init el cual obtiene un flag de Init png , si este es falso y imgFlag es verdadero o falso o viceversa significa que fallo y entrara al if
    {
        //Entonces envia un mensaje y retorna false
        std::cerr << "Error al inicializar SDL_image: " << IMG_GetError() << std::endl;
        return false;
    }

    // Inicializar SDL con el subsistema de audio
    if (SDL_Init(SDL_INIT_AUDIO) < 0)//Comprueba si se puede obtener el audio de manera correcta y si lo hace de manera correcta entonces procede con el codigo y si no manda un error
     {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return false;
    }

    // Inicializar SDL_mixer
    if (Mix_OpenAudio(44100, MIX_DEFAULT_FORMAT, 2, 4096) == -1) //Aqui lo que sucede es que se inicializa Mix_OpenAudio para el cual requiere los parametros , primero la frecuencia de muestreo , como segundo el formato de dicho archivo, como tercero , si sera mono = 1 o si es estereo , el cual ocupa 2 en este caso fue estereo y la tasa de bytes de guardado que tomara en un principio , en este caso toma 4096 bytes para guardar el audio, si es igual a -1 entonces hubo un error
    {
        //Entonces si hay un error muestra un error y lo obtiene de Mix , tambien quita SDL y retorna 1
        std::cerr << "Error al inicializar SDL_mixer: " << Mix_GetError() << std::endl;
        return false;
    }
    return true;
}
bool cargarContenido(){

    //Aqui se hace un objeto de tipo surface que es un puntero , el cual carga la imagen mediante la ruta ,para asi mismo comprobar si hay errores en la carga de alguno 
    SDL_Surface* cargadorImagen = IMG_Load("Ejemplo2.png");
    //Si esta vacio loadedSurface entonces mandara un error
    if (!cargadorImagen) {
        std::cerr << "Error al cargar la imagen: " << IMG_GetError() << std::endl;
        return false;
    }

    // Convertir la superficie a textura
    texture = SDL_CreateTextureFromSurface(renderer, cargadorImagen);//Se crea una superficie para textura mediante el renderizado y la imagen que fue cargada de tipo png
    if (!texture) //Si esta vacio entonces paso un error
    {
        std::cerr << "Error al crear la textura: " << SDL_GetError() << std::endl;
        return false;
    }

    SDL_FreeSurface(cargadorImagen);//Esto libera y elimina la imagen cargada para ahorrar memoria , esto se debe porque ya se creo una textura el cual contiene la imagen y ya no tendria sentido tenerla en otro lado y mejor se usa la textura

    // Definir los rectángulos para cada frame del sprite en la textura
    for (int i = 0; i < 12; ++i) {//62,130,214,298,382,460
        if (i == 1){
              spriteRecortes[i].x = 62;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
        else if(i == 2){
            spriteRecortes[i].x = 130;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
        }
        else if (i == 3)
        {
              spriteRecortes[i].x = 214;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
        }
        else if (i == 4)
        {
             spriteRecortes[i].x = 298;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
        }
        else if(i == 5){
              spriteRecortes[i].x = 382;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
        }
        else{
              spriteRecortes[i].x = 460;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
        }
        spriteRecortes[i].y = 0;//y: Es la coordenada vertical (posición Y) del rectángulo de recorte en la imagen original.
        spriteRecortes[i].w = 70;//w: Es el ancho del rectángulo de recorte. Indica cuántos píxeles de ancho abarcará el clip en la imagen original.
        spriteRecortes[i].h = 112;//h: Es la altura del rectángulo de recorte. Indica cuántos píxeles de alto abarcará el clip en la imagen original.
       
        
    }
    //Cargador Sonidos
    //Se crea un objeto de tipo puntero , llamado musica el cual obtiene un objeto de mix music y este mismo pide con mix_load la ruta del archivo 
    musica1 = Mix_LoadMUS(rutaArchivoAudio1);
    musica2 = Mix_LoadMUS(rutaArchivoAudio2);
    musica3 = Mix_LoadMUS(rutaArchivoAudio3);
    if (!musica1 || !musica2 ||!musica3)//Si musica esta vacio entonces hubo un error y se muestra un error
     {
        //Entonces cierra el audio de mix y quita SDL
        std::cerr << "No se pudo cargar algun archivo de audio: " << Mix_GetError() << std::endl;
        Mix_CloseAudio();
        SDL_Quit();
        return false;
    }
    return true;
}
void cerrarSDL() {

    //Se destruye la textura
    SDL_DestroyTexture(texture);
    //Se destruye el render
    SDL_DestroyRenderer(renderer);
    //Se destruye la ventana
    SDL_DestroyWindow(window);
    //Quit para eliminar las imagenes y SDL
    IMG_Quit();
    Mix_CloseAudio();
    Mix_FreeMusic(musica1);
    Mix_FreeMusic(musica2);
    Mix_FreeMusic(musica3);
    SDL_Quit();
}
void eventoTeclado(){
    reproduccionMusica1 = false;
    reproduccionMusica2 = false;
    if (Mix_PlayMusic(musica1, 1) == -1)//En este caso , se activa la musica mediante el archivo de musica , el cual fue tomado mediante la ruta , con Mix_PlayMusic, se pide el objeto de tipo Mix_Music y pide la cantidad de veces que se reproducira la musica , en este caso si da un -1 significa que hubo un error con el audio y entrara en el if 
    {
        //Si entra entonces manda un mensaje que hubo un error con el audio
        std::cerr << "Error al reproducir el audio: " << Mix_GetError() << std::endl;
        //Tambien con mix_freeMusic lo que hace es que libera la memoria de lo que hay en musica si es que se esta reproduciendo
        Mix_FreeMusic(musica1);
    }
    reproduccionMusica1 = true;
}
void eventoMouse(){
    reproduccionMusica1 = false;
    reproduccionMusica2 = false;
    if (Mix_PlayMusic(musica2, 1) == -1)//En este caso , se activa la musica mediante el archivo de musica , el cual fue tomado mediante la ruta , con Mix_PlayMusic, se pide el objeto de tipo Mix_Music y pide la cantidad de veces que se reproducira la musica , en este caso si da un -1 significa que hubo un error con el audio y entrara en el if 
    {
        //Si entra entonces manda un mensaje que hubo un error con el audio
        std::cerr << "Error al reproducir el audio: " << Mix_GetError() << std::endl;
        //Tambien con mix_freeMusic lo que hace es que libera la memoria de lo que hay en musica si es que se esta reproduciendo
        Mix_FreeMusic(musica2);
    }
    reproduccionMusica2 = true;
}
int main(int argc, char* argv[]) {
     if (!iniciarSDL() || !cargarContenido()) {
        cerrarSDL();
        return 0;
    }

    bool cerrar = false;
    SDL_Event evento;
    while (!cerrar)
    {
         while(SDL_PollEvent(&evento)) {
             switch (evento.type)
            {
            case SDL_QUIT:
                cerrar = true;
                break;

            case SDL_KEYDOWN:
                eventoTeclado();
                break;

            case SDL_MOUSEBUTTONDOWN:
                eventoMouse();
                break;
            // Puedes agregar más casos para manejar otros eventos si es necesario

            default:
                break;
            }
        }
        if (reproduccionMusica1)
        {
            std::cout <<"Entro musica1";
             // Definir los rectángulos para cada frame del sprite en la textura
            for (int j = 0; j < 12; ++j) {
            
            if (j == 1){
              currentFrame = 0;
              spriteRecortes[j].x = 62;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else if(j == 2){
            spriteRecortes[j].x = 130;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else if (j == 3)
            {
              spriteRecortes[j].x = 204;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else{
                spriteRecortes[j].x = 204;
            }
            spriteRecortes[j].y = 110;//w: Es el ancho del rectángulo de recorte. Indica cuántos píxeles de ancho abarcará el clip en la imagen original.
            spriteRecortes[j].w = 70;//w: Es el ancho del rectángulo de recorte. Indica cuántos píxeles de ancho abarcará el clip en la imagen original.
            spriteRecortes[j].h = 112;//h: Es la altura del rectángulo de recorte. Indica cuántos píxeles de alto abarcará el clip en la imagen original.
                }
            reproduccionMusica1 = false;
        }
        else if (reproduccionMusica2)
        {
             std::cout <<"Entro musica2";
             // Definir los rectángulos para cada frame del sprite en la textura
            for (int i = 0; i < 12; ++i) {//60,152,240,332,417
           if (i == 1){
              spriteRecortes[i].x = 60;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else if(i == 2){
            spriteRecortes[i].x = 152;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else if (i == 3)
            {
              spriteRecortes[i].x = 240;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else if (i == 4)
            {
             spriteRecortes[i].x = 332;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else if(i ==5){
            spriteRecortes[i].x = 417;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            else{
            spriteRecortes[i].x = 60;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
            }
            spriteRecortes[i].y = 220;//y: Es la coordenada vertical (posición Y) del rectángulo de recorte en la imagen original.
            spriteRecortes[i].w = 85;//w: Es el ancho del rectángulo de recorte. Indica cuántos píxeles de ancho abarcará el clip en la imagen original.
            spriteRecortes[i].h = 112;//h: Es la altura del rectángulo de recorte. Indica cuántos píxeles de alto abarcará el clip en la imagen original.
            }
            reproduccionMusica2 = false;
        }
        
        // Limpiar la pantalla del renderizado
        SDL_RenderClear(renderer);
        // Dibujar el frame actual del sprite
        SDL_RenderCopy(renderer, texture, &spriteRecortes[currentFrame], nullptr);

        // Actualizar el frame actual
        currentFrame = (currentFrame + 1) % 12;

        // Mostrar el frame dibujado en pantalla
        SDL_RenderPresent(renderer);

        // Pequeña pausa para controlar la velocidad de la animación
        SDL_Delay(100);
    }
    cerrarSDL();
    return 0;
    
}
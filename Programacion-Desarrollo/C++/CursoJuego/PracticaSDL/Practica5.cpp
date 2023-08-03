#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>
#include <iostream>
//Se inician las propiedades de la ventna
const int SCREEN_WIDTH = 800; 
const int SCREEN_HEIGHT = 600;
//Creacion del objeto window
SDL_Window* gWindow = nullptr;
//Creacion del render 
SDL_Renderer* gRenderer = nullptr;
//Una creacion de una textura
SDL_Texture* gSpriteSheet = nullptr;

// Rectángulos para recortar y mostrar cada frame del sprite
SDL_Rect gSpriteClips[12];
int currentFrame = 0;

//Metodo para ver si SDL inicia correctamente
bool initSDL() {
    if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return false;
    }

    gWindow = SDL_CreateWindow("Animación con Sprites", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_SHOWN);
    if (!gWindow) {
        std::cerr << "Error al crear la ventana: " << SDL_GetError() << std::endl;
        return false;
    }

    gRenderer = SDL_CreateRenderer(gWindow, -1, SDL_RENDERER_ACCELERATED);
    if (!gRenderer) {
        std::cerr << "Error al crear el renderer: " << SDL_GetError() << std::endl;
        return false;
    }

    SDL_SetRenderDrawColor(gRenderer, 0xFF, 0xFF, 0xFF, 0xFF);

    int imgFlags = IMG_INIT_PNG;// IMG_INIT_PNG. Este valor es una constante definida por la biblioteca SDL_image y representa el formato de imagen que se desea inicializar. En este caso, IMG_INIT_PNG indica que queremos inicializar el soporte para archivos PNG.
    if (!(IMG_Init(imgFlags) & imgFlags)) //aqui lo que se hace es que se inicializa IMG_Init el cual obtiene un flag de Init png , si este es falso y imgFlag es verdadero o falso o viceversa significa que fallo y entrara al if
    {
        //Entonces envia un mensaje y retorna false
        std::cerr << "Error al inicializar SDL_image: " << IMG_GetError() << std::endl;
        return false;
    }
    
    return true;
}

//Metodo para comprobar si el cargado de imagenes se hizo de manera correcta o cualquier Asset necesario
bool loadMedia() {
    //Aqui se hace un objeto de tipo surface que es un puntero , el cual carga la imagen mediante la ruta ,para asi mismo comprobar si hay errores en la carga de alguno 
    SDL_Surface* loadedSurface = IMG_Load("Ejemplo.png");
    //Si esta vacio loadedSurface entonces mandara un error
    if (!loadedSurface) {
        std::cerr << "Error al cargar la imagen: " << IMG_GetError() << std::endl;
        return false;
    }

    // Convertir la superficie a textura
    gSpriteSheet = SDL_CreateTextureFromSurface(gRenderer, loadedSurface);//Se crea una superficie para textura mediante el renderizado y la imagen que fue cargada de tipo png
    if (!gSpriteSheet) //Si esta vacio entonces paso un error
    {
        std::cerr << "Error al crear la textura: " << SDL_GetError() << std::endl;
        return false;
    }

    SDL_FreeSurface(loadedSurface);//Esto libera y elimina la imagen cargada para ahorrar memoria , esto se debe porque ya se creo una textura el cual contiene la imagen y ya no tendria sentido tenerla en otro lado y mejor se usa la textura

    // Definir los rectángulos para cada frame del sprite en la textura
    for (int i = 0; i < 12; ++i) {
        gSpriteClips[i].x = (SCREEN_WIDTH-(SCREEN_WIDTH-130))+i*44;//x: Es la coordenada horizontal (posición X) del rectángulo de recorte en la imagen original.
        gSpriteClips[i].y = 5;//y: Es la coordenada vertical (posición Y) del rectángulo de recorte en la imagen original.
        gSpriteClips[i].w = 46.5;//w: Es el ancho del rectángulo de recorte. Indica cuántos píxeles de ancho abarcará el clip en la imagen original.
        gSpriteClips[i].h = 98;//h: Es la altura del rectángulo de recorte. Indica cuántos píxeles de alto abarcará el clip en la imagen original.
    }

    return true;
}

//Metodo para cerrar SDL, el cual elimina todo lo que utilizo SDL para no seguir gastando memoria
void closeSDL() {
    //Se destruye la textura
    SDL_DestroyTexture(gSpriteSheet);
    //Se destruye el render
    SDL_DestroyRenderer(gRenderer);
    //Se destruye la ventana
    SDL_DestroyWindow(gWindow);
    //Quit para eliminar las imagenes y SDL
    IMG_Quit();
    SDL_Quit();
}

int main(int argc, char* argv[]) {
    //Si la carga de datos o el inicio de SDL es falso entonces hubo un error y quita SDL lo cierra
    if (!initSDL() || !loadMedia()) {
        closeSDL();
        return 1;
    }
    //quit un tipo boleano para salir del bucle de juego
    bool quit = false;
    SDL_Event e;//Variable para tomar los eventos
    //Bucle del juego
    while (!quit) {
        while (SDL_PollEvent(&e)) {
            if (e.type == SDL_QUIT) {
                quit = true;
            }
        }

        // Limpiar la pantalla del renderizado
        SDL_RenderClear(gRenderer);

        // Dibujar el frame actual del sprite
        SDL_RenderCopy(gRenderer, gSpriteSheet, &gSpriteClips[currentFrame], nullptr);

        // Actualizar el frame actual
        currentFrame = (currentFrame + 1) % 12;

        // Mostrar el frame dibujado en pantalla
        SDL_RenderPresent(gRenderer);

        // Pequeña pausa para controlar la velocidad de la animación
        SDL_Delay(125);
    }

    closeSDL();
    return 0;
}

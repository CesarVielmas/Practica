#include <iostream>
#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>

const int SCREEN_WIDTH = 800;
const int SCREEN_HEIGHT = 600;
const int SPRITE_WIDTH = 200;
const int SPRITE_HEIGHT = 300;

SDL_Window* window = nullptr;
SDL_Renderer* renderer = nullptr;
SDL_Texture* texture = nullptr;
SDL_Rect spriteRecortes[5];
int cuadroRecorte = 0;
bool inicioSprite = false;
bool correrSaltar = false;
int delay = 0;
Uint32 tiempoInicial;
bool initSDL()
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return false;
    }

    window = SDL_CreateWindow("Animaciones Sprite", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_SHOWN);
    if (!window)
    {
        std::cerr << "Error al crear la ventana: " << SDL_GetError() << std::endl;
        return false;
    }

    renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cerr << "Error al crear el renderer: " << SDL_GetError() << std::endl;
        return false;
    }

    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 0);

    int imgFlags = IMG_INIT_PNG;
    if (!(IMG_Init(imgFlags) & imgFlags))
    {
        std::cerr << "Error al inicializar SDL_image: " << IMG_GetError() << std::endl;
        return false;
    }

    return true;
}

bool loadContent()
{
    SDL_Surface* loadedSurface = IMG_Load("Ejemplo2.png");
    if (!loadedSurface)
    {
        std::cerr << "Error al cargar la imagen: " << IMG_GetError() << std::endl;
        return false;
    }

    texture = SDL_CreateTextureFromSurface(renderer, loadedSurface);
    SDL_FreeSurface(loadedSurface);
    
    if (!texture)
    {
        std::cerr << "Error al crear la textura: " << SDL_GetError() << std::endl;
        return false;
    }
    //animacion inicio: 55,135,215,295,375,455 en y = 0
    //animacion inmovil: 375,455, en y = 0
    //animacion moviendose: 60,130,200,270,60 y = 120
    //animacion saltar:375 y = 120, 455 y = 0

    for (int i = 0; i < 5; i++)
    {

        spriteRecortes[i].x = 55 + (80*(i));
        spriteRecortes[i].y = 0;
        spriteRecortes[i].w = 80;
        spriteRecortes[i].h = 100;

    }
    delay = 300;
    return true;
}

void closeSDL()
{
    SDL_DestroyTexture(texture);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    IMG_Quit();
    SDL_Quit();
}

void eventoTeclaDerecha(){
    correrSaltar = true;   

    for (int i = 0; i < 5; i++)//animacion moviendose: 60,130,200,270,60 y = 120
    {
        spriteRecortes[i].x = 60 + (70*(i));
         if (i ==4)
        {
        spriteRecortes[i].x = 200;
        }
        spriteRecortes[i].y = 113;
        spriteRecortes[i].w = 80;
        spriteRecortes[i].h = 91;

    }
    delay = 140;
    tiempoInicial = SDL_GetTicks();
}
void eventoTeclaArriba(){
    correrSaltar = true;
    for (int i = 0; i < 5; i++)//animacion saltar:375 y = 120, 455 y = 0
    {
        spriteRecortes[i].x = 375;
        spriteRecortes[i].y = 120;
        spriteRecortes[i].w = 80;
        spriteRecortes[i].h = 100;
    }
    delay = 300;
    tiempoInicial = SDL_GetTicks();
}
int main(int argc, char* argv[])
{
    if (!initSDL() || !loadContent())
    {
        closeSDL();
        return 1;
    }

    bool quit = false;
    SDL_Event event;
    int contadorInicio = 0;
    while (!quit)
    {
        while (SDL_PollEvent(&event))
        {
              switch (event.type)
            {
            case SDL_QUIT:
                quit = true;
                break;

            case SDL_KEYDOWN:
                if (event.key.keysym.sym == SDLK_LEFT)
                    eventoTeclaDerecha();
                else if (event.key.keysym.sym == SDLK_UP)
                    eventoTeclaArriba();
                break;
            default:
                break;
            }
        }
        if (inicioSprite && !correrSaltar)

        {
            for (int i = 0; i < 5; i++)
            {
                if (i>0 && i<2)
                spriteRecortes[i].x = 375;
                else
                spriteRecortes[i].x = 455;
                spriteRecortes[i].y = 0;
                spriteRecortes[i].w = 80;
                spriteRecortes[i].h = 100;
            }
            delay = 600;
            inicioSprite = false;
        }
        Uint32 tiempoActual = SDL_GetTicks();//Para obtener el tiempo actual
        Uint32 tiempoTranscurrido = tiempoActual - tiempoInicial;
        if (correrSaltar && inicioSprite&&tiempoTranscurrido>= 400)
        {
            correrSaltar = false;
        }
        SDL_RenderClear(renderer);
        SDL_Rect destinationRect = { 600, 240, SPRITE_WIDTH, SPRITE_HEIGHT };
        SDL_RenderCopy(renderer, texture,&spriteRecortes[cuadroRecorte] , &destinationRect);
        cuadroRecorte = (cuadroRecorte + 1) % 5;
        SDL_RenderPresent(renderer);
        SDL_Delay(delay);
        if (contadorInicio ==1)
        inicioSprite = true;
        contadorInicio = 1;
    }

    closeSDL();
    return 0;
}

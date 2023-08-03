#include <SDL2/SDL.h>
#include <iostream>

    //Creacion del objeto window
    SDL_Window* window;
    //Creacion del render 
    SDL_Renderer* renderer;

    const int ANCHO_VENTANA = 700;
    const int ALTO_VENTANA = 600;
    //Metodo para ver si hay errores en SDL
//Metodo para ver si hay errores en SDL
bool iniciarSDL(){

    if (SDL_Init(SDL_INIT_VIDEO)<0)
    {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return false;
    }
     window = SDL_CreateWindow("Eventos SDL", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_UNDEFINED, ANCHO_VENTANA,ALTO_VENTANA, SDL_WINDOW_SHOWN);
    if (!window)
    {
        std::cerr << "Error al inicializar las ventanas: " << SDL_GetError() << std::endl;
        return false;
    }
    renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cerr << "Error al inicializar el renderizado: " << SDL_GetError() << std::endl;
        return false;
    }
    SDL_SetRenderDrawColor(renderer, 250, 156, 0, 120);

    return true;
}

void cerrarSDL(){
     //Se destruye el render
    SDL_DestroyRenderer(renderer);
    //Se destruye la ventana
    SDL_DestroyWindow(window);
    //Quit para eliminar las imagenes y SDL
    SDL_Quit();
}
void eventoTecla(){
    SDL_SetRenderDrawColor(renderer,0,200,157,210);
    SDL_RenderDrawLine(renderer,0,0,ANCHO_VENTANA,ALTO_VENTANA);
    SDL_RenderPresent(renderer);
}
void eventoMouse(){
    SDL_SetRenderDrawColor(renderer,0,255,0,255);
    SDL_Rect rectangulo;
    rectangulo = { 400,250, 300, 400 };
    SDL_RenderFillRect(renderer,&rectangulo);
    SDL_RenderPresent(renderer);
}
void eventoVentana(){
    SDL_SetRenderDrawColor(renderer,0,0,0,255);
    SDL_RenderDrawLine(renderer,0,0,ANCHO_VENTANA,ALTO_VENTANA);
    SDL_RenderPresent(renderer);
}
int main(int argc, char* argv[]) {
    if (!iniciarSDL())
    {
        cerrarSDL();
        return 0;
    }

    bool quitarBucle = false;
    SDL_Event evento;
    while (!quitarBucle)
    {
        while (SDL_PollEvent(&evento)) {
            SDL_RenderClear(renderer);
            switch (evento.type)
            {
            case SDL_QUIT:
                quitarBucle = true;
                break;

            case SDL_KEYDOWN:
                eventoTecla();
                break;

            case SDL_MOUSEBUTTONDOWN:
                eventoMouse();
                break;

            case SDL_WINDOWEVENT:
                eventoVentana();
                break;

            // Puedes agregar más casos para manejar otros eventos si es necesario

            default:
                break;
            }
        }
        
    }
    cerrarSDL();
    return 0;
    
}
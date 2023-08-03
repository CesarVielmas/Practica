#include <SDL2/SDL.h>
#include <iostream>
using namespace std;
int main(int argc, char* argv[]) {
    const int SCREEN_WIDTH = 800;
    const int SCREEN_HEIGHT = 600;

    // Inicializar SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        SDL_LogError(SDL_LOG_CATEGORY_APPLICATION, "SDL_Init failed: %s", SDL_GetError());
        return 1;
    }

    // Crear la ventana
    SDL_Window* window = SDL_CreateWindow("SDL2 Prueba 1", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_SHOWN);
    if (!window) {
        SDL_LogError(SDL_LOG_CATEGORY_APPLICATION, "SDL_CreateWindow failed: %s", SDL_GetError());
        SDL_Quit();
        return 1;
    }

    // Bucle principal
    SDL_Event event;
    bool quit = false;
    while (!quit) {
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT) {
                quit = true;
            }
        }

        // Limpiar la pantalla con un color (en este caso, rojo)
        SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, 0);
        SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);
        SDL_RenderClear(renderer);
        SDL_RenderPresent(renderer);

        // Pequeña pausa para reducir el uso de la CPU
        SDL_Delay(10);
    }

    // Liberar recursos y cerrar SDL
    SDL_DestroyWindow(window);
    SDL_Quit();
    cout<<"Salio";
    return 0;
}

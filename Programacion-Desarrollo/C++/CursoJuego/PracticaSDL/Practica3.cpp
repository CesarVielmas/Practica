#include <SDL2/SDL.h>
#include <iostream>
#include <cmath>
using namespace std;
//Dibujando un circulo con el algoritmo de Bresenham
const int ANCHO_PANTALLA = 800;
const int ALTURA_PANTALLA = 600;

void drawCircle(SDL_Renderer* renderer, int centerX, int centerY, int radius) {
    int x = 0;
    int y = radius;
    int d = 3 - 2 * radius;

    while (x <= y) {
        SDL_RenderDrawPoint(renderer, centerX + x, centerY + y);
        SDL_RenderDrawPoint(renderer, centerX - x, centerY + y);
        SDL_RenderDrawPoint(renderer, centerX + x, centerY - y);
        SDL_RenderDrawPoint(renderer, centerX - x, centerY - y);
        SDL_RenderDrawPoint(renderer, centerX + y, centerY + x);
        SDL_RenderDrawPoint(renderer, centerX - y, centerY + x);
        SDL_RenderDrawPoint(renderer, centerX + y, centerY - x);
        SDL_RenderDrawPoint(renderer, centerX - y, centerY - x);

        if (d < 0) {
            d = d + 4 * x + 6;
        } else {
            d = d + 4 * (x - y) + 10;
            y--;
        }
        x++;
    }
}
int main(int argc , char* argv[]){
    if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        std::cerr << "Error al inicializar SDL: " << SDL_GetError() << std::endl;
        return 1;
    }

    SDL_Window* ventana = SDL_CreateWindow("Dibujo de Círculo", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, ANCHO_PANTALLA, ALTURA_PANTALLA, SDL_WINDOW_SHOWN);
    if (!ventana) {
        std::cerr << "Fallo SDL al obtener la ventana: " << SDL_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    SDL_Renderer* renderizado = SDL_CreateRenderer(ventana, -1, SDL_RENDERER_ACCELERATED);
    if (!renderizado) {
        std::cerr << "Fallo SDL al crear el renderizado: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(ventana);
        SDL_Quit();
        return 1;
    }

    bool salir = false;
    while (!salir) {
        SDL_Event evento;
        while (SDL_PollEvent(&evento)) {
            if (evento.type == SDL_QUIT) {
                salir = true;
            }
        }

        // Limpiar la pantalla
        SDL_SetRenderDrawColor(renderizado, 0, 0, 0, 255);
        SDL_RenderClear(renderizado);

        // Dibujar un círculo en el centro de la pantalla
        int radio = 30;
        int centroX = ANCHO_PANTALLA / 2;
        int centroY = ALTURA_PANTALLA / 2;
        SDL_SetRenderDrawColor(renderizado, 255, 255, 255, 255);
        drawCircle(renderizado, centroX, centroY, radio);

        // Actualizar la pantalla
        SDL_RenderPresent(renderizado);
    }

    SDL_DestroyRenderer(renderizado);
    SDL_DestroyWindow(ventana);
    SDL_Quit();
    return 0;
}
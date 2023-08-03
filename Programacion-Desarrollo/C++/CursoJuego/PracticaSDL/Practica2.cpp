#include <SDL2/SDL.h>
#include <iostream>
using namespace std;

int main(int argc , char* argv[]){
    const int ANCHO_PANTALLA = 1200;
    const int ALTURA_PANTALLA = 500;
    //Checar que todo funcione en SDL
    if (SDL_Init(SDL_INIT_VIDEO)<0||SDL_Init(SDL_INIT_AUDIO)<0)//Si el inicio de sdl da -1 en audio o video entones esta fallando
    {
        SDL_LogError(SDL_LOG_CATEGORY_APPLICATION, "Fallo SDL en audio o video: %s", SDL_GetError());//Si es asi manda un error y lo recoge y lo manda en consola
        SDL_Quit();
        return 1;
    }
    //Si no falla se crea la ventana
    SDL_Window* ventana = SDL_CreateWindow("SDL Prueba 2",SDL_WINDOWPOS_CENTERED,SDL_WINDOWPOS_UNDEFINED,ANCHO_PANTALLA,ALTURA_PANTALLA,SDL_WINDOW_SHOWN);

    //Si la ventana esta vacia o es nula entonces manda un error
    if (!ventana)
    {
        SDL_LogError(SDL_LOG_CATEGORY_APPLICATION, "Fallo SDL al obtener la ventana: %s", SDL_GetError());//Si es asi manda un error y lo recoge y lo manda en consola
        SDL_Quit();
        return 1;
    }
    //Si no tuvo errores y se creo el objeto ventana correctamente entonces pasamos a los eventos , los cuales haran todo lo que se mostrara en la ventana
    SDL_Event evento;
    //Ahora render o renderizado lo que hace es que toma la ventana principal , en este caso llamado ventana y puede actuar directamente sobre este pudiendo renderizar imagenes , audio , etc
    SDL_Renderer* renderizado = SDL_CreateRenderer(ventana, -1, 0);
    bool salir = false;
    while (!salir)
    {
        //En este ciclo lo que hace , es que si hay eventos o se hace un evento , justo dentro de el ciclo de juego entonces pasa los eventos a la variable "evento" la cual debe de ser de tipo SDL_Event , esta misma servira para poder obtener todos los eventos y iterarlos, si el evento es de tal tipo entonces hara tal cosa en el while y si no hay eventos , entonces sale del while
          while (SDL_PollEvent(&evento)) {
            if (evento.type == SDL_QUIT)//Si se intenta salir de SDL con la tacha el cual es "SDL_QUIT" entonces sale del bucle de juego
             {
                salir = true;
            }
        }

        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 50, 1000, 500);//Para dibujar una linea y se le indica las coordenadas en este orden {x1,y1,x2,y2} para que se dibuje
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 51, 1000, 501);//Para dibujar una linea y se le indica las coordenadas en
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 52, 1000, 502);//Para dibujar una linea y se le indica las coordenadas en  
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 53, 1000, 503);//Para dibujar una linea y se le indica las coordenadas en 
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 54, 1000, 504);//Para dibujar una linea y se le indica las coordenadas en 
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 55, 1000, 505);//Para dibujar una linea y se le indica las coordenadas en 
         SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 56, 1000, 506);//Para dibujar una linea y se le indica las coordenadas en
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 57, 1000, 507);//Para dibujar una linea y se le indica las coordenadas en  
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 58, 1000, 508);//Para dibujar una linea y se le indica las coordenadas en 
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 59, 1000, 509);//Para dibujar una linea y se le indica las coordenadas en 
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 60, 1000, 510);//Para dibujar una linea y se le indica las coordenadas en
         SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 61, 1000, 511);//Para dibujar una linea y se le indica las coordenadas en
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 62, 1000, 512);//Para dibujar una linea y se le indica las coordenadas en  
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 63, 1000, 513);//Para dibujar una linea y se le indica las coordenadas en 
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 64, 1000, 514);//Para dibujar una linea y se le indica las coordenadas en 
        SDL_SetRenderDrawColor(renderizado, 255, 0, 0, 255); // Color: Rojo (RGB: 255, 0, 0)
        SDL_RenderDrawLine(renderizado, 200, 65, 1000, 515);//Para dibujar una linea y se le indica las coordenadas en  
        SDL_RenderPresent(renderizado);//Para mostrar lo que hay en el renderizado en la ventana
        SDL_RenderClear(renderizado);//Para limpiar lo que habia en renderizado
        SDL_Delay(500);
        SDL_SetRenderDrawColor(renderizado,0,255,0,255);//Color Verder
        SDL_Rect rectangulo; // Rectángulo que representa el rectángulo a dibujar
        rectangulo = { 400,250, 300, 400 };//Coordenada y tamaño del rectangulo , importante añadir{x,y,ancho,alto}
        SDL_RenderFillRect(renderizado,&rectangulo);//Ahora se mostrara dicha figura en la pantalla del color del render
        SDL_SetRenderDrawColor(renderizado,0,0,0,255);//Color Verder
        SDL_Rect rectangulo2; // Rectángulo que representa el rectángulo a dibujar
        rectangulo2 = { 700,150, 200, 200 };//Coordenada y tamaño del rectangulo , importante añadir{x,y,ancho,alto}
        SDL_RenderFillRect(renderizado,&rectangulo2);//Ahora se mostrara dicha figura en la pantalla del color del render
        SDL_RenderPresent(renderizado);//Para mostrar lo que hay en el renderizado en la ventana
        SDL_RenderClear(renderizado);//Para limpiar lo que habia en renderizado
        SDL_Delay(500);
        SDL_SetRenderDrawColor(renderizado,0,0,0,0);
        SDL_RenderPresent(renderizado);//Para mostrar lo que hay en el renderizado en la ventana
        SDL_RenderClear(renderizado);//Para limpiar lo que habia en renderizado
        // Pequeña pausa para reducir el uso de la CPU
        SDL_Delay(500);//Con SDL_Delay , lo que hace es que pause un poco lo que se esta haciendo para disminuir el CPU
    }
    //Cuando sale de el juego o de la ventana entonces
    SDL_DestroyWindow(ventana);//Para destruir la ventana que se estaba utilizando
    SDL_Quit();//Para eliminar todo lo que contenia SDL
    cout<<"Salio";
    return 0;
}
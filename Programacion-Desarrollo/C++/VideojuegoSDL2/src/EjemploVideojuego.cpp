/*****************************************************************
 Ejemplo3_1
 (C) 2003 by Alberto García Serrano
 Programación de videojuegos con SDL
 ******************************************************************/
#include <stdio.h>
#include <stdlib.h>
#include <SDL2/SDL.h>
int main(int argc, char *argv[]) {
    //Creacion de las variables 
    //Para la pantalla y una imagen
 SDL_Surface *imagen, *Pantalla;
 //Para un destino
 SDL_Rect destino;
 //Para un evento
 SDL_Event evento;
 int salir = 0;
 //Cerrando cualquier indicio de SDL abierto
 atexit(SDL_Quit);
 // Iniciar SDL
 if (SDL_Init(SDL_INIT_VIDEO) < 0) {
 printf("No se pudo iniciar SDL: %s\n",SDL_GetError());
 exit(1);
 }
 else
 {
     printf("Se inicializo correctamente");
 }
 // Activamos modo de video
 Pantalla = SDL_SetVideoMode(150,100,16,SDL_HWSURFACE);
 if (screen == NULL) {
 printf("No se puede inicializar el modo gráfico: \n",SDL_GetError());
 exit(1);
 }
else
{
 printf("Se inicializo de manera correcta el video");
}

 // Cargamos gráfico
 //SDL_LoadBMP carga una imagen o grafico de tipo bmp
 imagen = SDL_LoadBMP("nave.bmp");
 if ( image == NULL ) {
 printf("No pude cargar gráfico: %s\n", SDL_GetError());
 exit(1);
 }
 else
 {
 printf("Se cargo de manera correcta el grafico");
 }
 // Definimos donde dibujaremos el gráfico
 // y lo copiamos a la pantalla.
 destino.x = 100;
 destino.y = 100;
 destino.w = imagen->w;
 destino.h = imagen->h;
 SDL_BlitSurface(imagen, NULL, Pantalla, &destino);
 // Mostramos la pantalla
 SDL_Flip(Pantalla);
 // liberar superficie
 SDL_FreeSurface(imagen);
 // Esperamos la pulsación de una tecla para salir
 while(done == 0) {
 while ( SDL_PollEvent(&evento) ) 
 {
 if ( event.type == SDL_KEYDOWN )
 {
 done = 1;
 
 }
 }
 return 0;
}
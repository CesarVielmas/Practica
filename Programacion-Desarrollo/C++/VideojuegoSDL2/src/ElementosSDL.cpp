// Example program:
// Using SDL2 to create an application window

#include <SDL2/SDL.h>
#include <stdio.h>
int main(int argc, char* argv[]) {
   int done = 0;
   int altura = 150;
   int anchura = 100;
   //Inicializando el sistema de SDL en este caso el video y audio
if (SDL_Init(SDL_INIT_AUDIO|SDL_INIT_VIDEO)< 0) {
 printf("No se puede iniciar SDL: %s\n",SDL_GetError()); 
 exit(1);
 }
 else
 {
    //Primero asignamos una variable de tipo puntero y objeto que obtiene sus propiedades de SDL_Window
SDL_Window *Pantalla; 
//Despues desplegamos la la ventana con SDL_CreateWindow el cualtoma como parametros , el nombre de la ventana , la posicion de la ventana en pantalla en el lado X ,
//La posicion de la pantalla en el lado Y, la altura de la ventana , la anchura de la pantalla y como ultimo parametro la tabla de setVideoMode el cual esta en messenger
//En este caso ponerla de tamaño completa o usar la ventana de opengl predeterminada
Pantalla = SDL_CreateWindow("Titulo De La Ventana",SDL_WINDOWPOS_UNDEFINED,SDL_WINDOWPOS_UNDEFINED,altura, anchura, SDL_SWSURFACE | SDL_WINDOW_OPENGL);
//Se hace un if si no sale la ventana en pantalla y avisara por terminal , cuando pantalla sea nulo lo cual no pudo realizar o establecer el modo de video que le proporcionamos
//En este caso un tamaño de 150x100 
if ( Pantalla == NULL ){
 fprintf(stderr, "No se puede establecer el modo  de video 150x100: %s\n", SDL_GetError());
 exit(1);
} 
else
{ 
   
 }

//atexit  lo que hace es usar la ultima funcion que ejecuto SDL , sin embargo se le pueden pasar parametros para que haga como ultima accion dicho parametro , en este caso
//SDL_Quit el cual hace que cierre cualquier accion de SDL
 atexit(SDL_Quit);
 
 printf("Se inicializo correctamente \n");
}

// Inicializar de manera por separado
if (SDL_InitSubSystem(SDL_INIT_JOYSTICK) == -1) {
 printf("No se puede iniciar el Joystick: %s\n",SDL_GetError());
 exit(1);
} 
else
{
//Funcion Para Guardar escenarios o escenas o mapas etc para despues si se requiere mostrarlos en pantalla
// SDL_Surface *SDL_CreateRGBSurface(Uint32 flags, int width, int height, int depth, Uint32 Rmask, Uint32 Gmask, Uint32 Bmask, Uint32 Amask); 
//Uint32 son las opciones de la tabla de RGB surface el cual esta en messenger,width y height es altura y anchura de lo que se mostrara en pantalla o la ventana , depth es la profundidad en cuestion de la paleta de colores
//Rmask es la cantidad de bits de color rojo que utilizara , Gmask es la cantidad de bits de color verde que usara , Bmask es la cantidad de bits de color azul que usara 
//Y Amaskes la cantidad de transparencia que obtendra la ventana
//Ejemplo
//Creacion de el color en hexadecimal
int rmask = 0xff000000;
int gmask = 0x00ff0000;
int bmask = 0x0000ff00;
int amask = 0x000000ff;
//Pasando parametros a ejemplo de surface para usar SDL_CreateRGBSurface
SDL_Surface *Ejemplo;
Ejemplo = SDL_CreateRGBSurface(SDL_SWSURFACE, 640, 480, 24,rmask, gmask,bmask, amask);
if(Ejemplo == NULL) {
 printf("Error al crear la superficie"); 
 exit(1);
}
else
{

}

// void SDL_SetClipRect(SDL_Surface *surface, SDL_Rect *rect); Esta funcion lo que hace es recortar una parte de la pantalla para indicar al programa que solo esa parte 
//Recortada de la pantalla sera la que cambie constantemente y mateniendo estatico lo otro que no este recortado o dandole otra serie de graficos separandolo de esa parte
//Recortada , los parametros que recibe como primero el SDL_Surface es la variable donde se encuentra la pantalla o el fragmento que se mostrara del video y el SDL_Rect 
//Lo que hace es darle indicacion de que parte es lo que recortara , se puede hacer mediante una variable que obtenga coordenadas

// void SDL_GetClipRect(SDL_Surface *surface, SDL_Rect *rect); con esta otra funcion lo que hace es obtener los datos de el clipping o del recorte que se haya hecho , guardandolo
//Dentro de la variable SDL_Rect la cual fue creada para poder modificar valores de las coordenadas y obtener diferentes resultados
//SDL_QuitSudSystem lo que hace es finalizar algun subsistema de sdl en este caso finalizamos el subsistema que inicializamos osease el joystick
 SDL_QuitSubSystem(SDL_INIT_JOYSTICK);
 printf("inicializo con exito el sistema de Joystick");

}

while (!done) {
// Leer entrada

// Procesar entrada (si se pulsó ESC, done = 1)
done = 1;
// Lógica de juego
// Otras tareas
// Mostrar frame
} 
}

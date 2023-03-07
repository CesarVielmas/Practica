/* Videojuego Creado para la clase metodos numericos Sabatinos V3,V5 
    Equipo 4
*/
#include <SDL2/SDL.h>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
//Variables globales para todas las funciones
SDL_Window *Pantalla;
SDL_Surface *Fondo1;
SDL_Surface *PantallaPrincipal;
SDL_Surface *MapaPrincipal;
SDL_Surface *Superficie;

bool Inicio()
{
    //Lo que retornara el bool si se completa todo bien
    bool Completado = true;
    //Iniciando SDL
    if( SDL_Init( SDL_INIT_VIDEO ) < 0 )
    {
        printf( "SDL no se pudo iniciar \n", SDL_GetError() );
        Completado = false;
    }
    else
    {
        //Creando la ventana
        Pantalla = SDL_CreateWindow( "Method Quest", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 600, 600, SDL_WINDOW_SHOWN );
        if( Pantalla == NULL )
        {
            printf( "La ventana no pudo ser creada", SDL_GetError() );
            Completado = false;
        }
        else
        {
            //Obteniendo en la superficie la pantalla 
            Superficie = SDL_GetWindowSurface( Pantalla );
        }
    }

    return Completado;
}
bool CargandoImagenes()
{
    //Se mostrara verdadero si se cumple el cargado de imagenes correctamente
 bool Completado = true;
    //Cargando las imagenes 
    //Imagen Fondo1
 Fondo1 = SDL_LoadBMP( "ArchivosParaPrograma/ConvertirImagen1.bmp" );
 if (Fondo1 == NULL)
 {
     printf("No se pudo cargar la imagen Fondo1",SDL_GetError());
     Completado = false;

 }
 else
 {

 }
 
 //Imagen Fondo2
PantallaPrincipal = SDL_LoadBMP("ArchivosParaPrograma/ConvertirImagen2.bmp");
if (PantallaPrincipal == NULL)
{
    printf("No se pudo cargar la imagen PantallaPrincipal",SDL_GetError());
    Completado = false;
}
else
{

}
 //Imagen Fondo3
MapaPrincipal = SDL_LoadBMP("ArchivosParaPrograma/ConvertirImagen3.bmp");
if (MapaPrincipal == NULL)
{
    printf("No se pudo cargar la imagen MapaPrincipal",SDL_GetError());
    Completado = false;
}
else
{

}

 return Completado;
}

bool CargandoAudios()
{
    bool completado = true;

    return completado;
}

void CerrandoTodo()
{
    //Eliminando las imagenes cargadas
    SDL_FreeSurface(Fondo1);
    Fondo1 = NULL;
     SDL_FreeSurface(PantallaPrincipal);
    PantallaPrincipal = NULL;
    //Destruyendo la ventana
    SDL_DestroyWindow(Pantalla);
    //Qitando todo
    SDL_Quit();

}
//Oprimiendo la tecla Space en el intro del juego
void OprimiendoLaTeclaSpace()
{
   //Applicando la imagen de fondo1
    SDL_BlitSurface( MapaPrincipal, NULL, Superficie, NULL );
    //Update the surface
    SDL_UpdateWindowSurface( Pantalla );
}
//metodo Principal
int main(int argc , char *argv[])
{
    Inicio();
    CargandoImagenes();
    CargandoAudios();
    bool Salir = false;
    if (Inicio()==false)
    {
        printf("no se pudo inicializar el programa");
    }
    else
    {
        if (CargandoImagenes()==false)
        {
            printf("No se pudo cargar las imagenes");
        }
        else
        {
            if (CargandoAudios()==false)
            {
                printf("No se pudo cargar los audios");
            }
            else
            {

            }
            
        }
    }
    //Iniciando los procesos
    //Applicando la imagen de fondo1
    SDL_BlitSurface( Fondo1, NULL, Superficie, NULL );
    //Update the surface
    SDL_UpdateWindowSurface( Pantalla );
    SDL_Delay(20000);
    SDL_BlitSurface(PantallaPrincipal,NULL,Superficie,NULL);
    SDL_UpdateWindowSurface(Pantalla);
    SDL_Delay(10000);
    int i;
    while (Salir == false)
    {
        if (i = 100)
        {
            Salir = true;
        }
        i++;
    }
     CerrandoTodo();
    
} 

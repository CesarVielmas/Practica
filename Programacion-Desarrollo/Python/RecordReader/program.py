import math
import random
with open('./pruebas/tsiligirides_problem_1_budget_75.txt', 'r') as archivo:
    lineas = archivo.readlines()

contenido_sin_espacios = []
for linea in lineas:
    contenido_sin_espacios.append(linea.strip())

obtenerTmax = contenido_sin_espacios[0];
valoresPrincipales = obtenerTmax.split();
tmax = int(valoresPrincipales[0])
numRutas =int(valoresPrincipales[1]);

print("Tmax =",tmax,"\nNumero de rutas =",numRutas);
x1 = 0;
x2 = 0;
y1 = 0;
y2 = 0;
score = 0;
distancia = [];
valorEntreScore = []
scores = [];
for i in range(1, len(contenido_sin_espacios)):
    distanciasGuardadas = [];
    scoreValor = [];
    elemento = contenido_sin_espacios[i];
    valores = elemento.split()
    x1 = float(valores[0])
    y1 = float(valores[1])
    scores.append(int(valores[2]))

    for i in range(1,len(contenido_sin_espacios)):
        elemento = contenido_sin_espacios[i];
        valores = elemento.split()
        x2 = float(valores[0])
        y2 = float(valores[1])
        scorePrueba = int(valores[2]);
        distanciaTotal = math.sqrt((x2 - x1)**2 + (y2 - y1)**2)
        distanciasGuardadas.append(distanciaTotal);
        if(scorePrueba>0 and distanciaTotal>0):
           scoreValor.append(scorePrueba/distanciaTotal)
        else:
            scoreValor.append(0);
    distancia.append(distanciasGuardadas);
    valorEntreScore.append(scoreValor);
        
i = 0;
for distanciasCompletas in distancia:
    i = i+1
    print("\nDistancias desde ",i,":",distanciasCompletas);
    print("-----------------------------------------------------------------");
#Algoritmo
sumTmax = 0;
sumScore = 0;
quitPosicion = 0;
cancelacion2 = False
positionResume = [];
for i in range(1,len(contenido_sin_espacios)):
    if(sumTmax>=tmax):
        break
    cancelarion = False;
    contador = 0
    while(cancelarion == False):
        maxValor = max(valorEntreScore[i-1]);
        posicion = 0
        for j in valorEntreScore[i-1]:
            posicion = posicion+1
            if(maxValor == j):
                quitPosicion = posicion;
                
                #eliminacion
                posicionDistancia = 0
                for distancias in distancia[i-1]:
                    posicionDistancia = posicionDistancia+1
                    if(posicionDistancia == quitPosicion):
                        if(sumTmax+distancias<=tmax):
                            cancelarion = True;
                        else:
                            for encontrarMax in valorEntreScore[i-1]:
                                contador = contador+1;
                                if(encontrarMax == maxValor ):
                                    encontrarMax = 0;
                                if(contador >len(distancia)):
                                    cancelarion = True;
                                    cancelacion2 = True;
                if(cancelarion == True):
                    for subArray in valorEntreScore:
                        subArray[quitPosicion-1] = 0;
    if(cancelacion2 == True):
        break
    print("Posicion:",quitPosicion);
    positionResume.append(quitPosicion);
    #sumarScore
    sumScore = sumScore + scores[quitPosicion-1];
    #sumarDistancia
    posicionDistancia = 0
    for distancias in distancia[i-1]:
        posicionDistancia = posicionDistancia+1
        if(posicionDistancia == quitPosicion):
            sumTmax = sumTmax+distancias;
    print("Suma distancias:",sumTmax,"\nSuma Score:",sumScore);

print("------------------------------------------------------------------------\nResultado");
print("Suma Distancias:",sumTmax);
print("Suma Score:",sumScore);
print(positionResume);
#Local Search
#distancia
#positionResume
iteraciones =int(input("Cuantas veces resolvera el local search\n"));
contador = 0;
contadorFirts = 0;
contador2 = 0;
sumTMaxLS = 0;
indexValue = 0;
positionsNews = [];
while(contador2<iteraciones):
    #intercambiando distancias
    valorEjemplo = positionResume[contador];
    valorEjemplo2 = positionResume[contador+1];
    positionResume[contador] = valorEjemplo2;
    positionResume[contador+1] = valorEjemplo;
    for positions in positionResume:
        if(contadorFirts == 0):
            for index,distance in enumerate(distancia[0]):
                if(index == positions):
                    sumTMaxLS = distance;
                    indexValue = index;
                    contadorFirts = contadorFirts +1;
                    
        else:
            for index,distance in enumerate(distancia[indexValue]):
                if(index == positions):
                    sumTMaxLS = sumTMaxLS + distance;
                    indexValue = index;
        
    print("iteracion",contador2+1,":",sumTMaxLS);
    if(sumTMaxLS<sumTmax):
        positionsNews = positionResume;
        sumTmax = sumTMaxLS;
        print("Se encontro una mejor distancia");
        print(positionResume);
        contador2 = iteraciones;
    elif(contador2 == iteraciones-1):
        print("No se encontro una mejor solucion en sus iteraciones");
    contador = random.randint(0,len(positionResume));
    contador2 = contador2+1;
    sumTMaxLS = 0;
    contadorFirts = 0;
    if(contador >= len(positionResume)-1):
        contador = random.randint(0,len(positionResume)-2);


        



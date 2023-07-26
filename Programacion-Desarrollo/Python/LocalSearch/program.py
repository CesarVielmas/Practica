import math
with open('./pruebas/set_66_1_005.txt', 'r') as archivo:
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

    
       





        



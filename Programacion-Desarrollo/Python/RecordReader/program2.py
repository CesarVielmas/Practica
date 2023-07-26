import math
import random

with open('./pruebas/tsiligirides_problem_1_budget_15.txt', 'r') as archivo:
    lineas = archivo.readlines()

contenido_sin_espacios = [linea.strip() for linea in lineas]

tmax, numRutas = map(int, contenido_sin_espacios[0].split())
print("Restriccion T Max =", tmax, "\nCantidad de rutas de el programa =", numRutas)

distancia = []
valorEntreScore = []
scores = []

for i in range(1, len(contenido_sin_espacios)):
    elemento = contenido_sin_espacios[i]
    valueX1, valueY1, score = map(float, elemento.split())
    scores.append(int(score))

    distanciasGuardadas = []
    scoreValor = []

    for j in range(1, len(contenido_sin_espacios)):
        elemento = contenido_sin_espacios[j]
        valueX2, valueY2, scorePrueba = map(float, elemento.split())
        distanciaTotal = math.sqrt((valueX2 - valueX1) ** 2 + (valueY2 - valueY1) ** 2)
        distanciasGuardadas.append(distanciaTotal)

        if scorePrueba > 0 and distanciaTotal > 0:
            scoreValor.append(scorePrueba / distanciaTotal)
        else:
            scoreValor.append(0)

    distancia.append(distanciasGuardadas)
    valorEntreScore.append(scoreValor)


alpha = float(input("Valor de alpha: "))

# Algoritmo con k-best
sumTmax = 0
sumScore = 0
positionResume = []
best_distance = 0

for i in range(1, len(contenido_sin_espacios)):
    if sumTmax >= tmax:
        break

    cancelarion = False
    contador = 0

    while not cancelarion:
        mnValor = min(valorEntreScore[i-1])
        mxValor = max(valorEntreScore[i-1])
        umbral = mnValor + (mxValor - mnValor) * alpha
        valores_cumplen = []

        for posicion, valor in enumerate(valorEntreScore[i - 1]):
            if valor >= umbral:
                valores_cumplen.append(valor)

        if not valores_cumplen:
            break

        valorAleatorio = random.randint(0, len(valores_cumplen) - 1)
        maxValor = valores_cumplen[valorAleatorio]
        posicion = 0

        for j in valorEntreScore[i - 1]:
            posicion += 1

            if maxValor == j:
                quitPosicion = posicion

                # Eliminacion
                posicionDistancia = 0

                for distancias in distancia[i - 1]:
                    posicionDistancia += 1

                    if posicionDistancia == quitPosicion:
                        if sumTmax + distancias <= tmax:
                            cancelarion = True
                        else:
                            for encontrarMax in valorEntreScore[i - 1]:
                                contador += 1

                                if encontrarMax == maxValor:
                                    encontrarMax = 0

                                if contador > len(distancia):
                                    cancelarion = True
                                    break

                            break

        if not cancelarion:
            valorEntreScore[i - 1][quitPosicion - 1] = 0

    if cancelarion:
        sumScore += scores[i - 1]
        positionResume.append(i)
        sumTmax += distancia[i - 1][quitPosicion - 1]
        best_distance += distancia[i - 1][quitPosicion - 1]

print("*******************\nDistancia Total:", best_distance)
print("*******************\nEl score total que arrojo:", sumScore)
print("*******************\nLa ruta que paso:", positionResume)

# Local Search
iteraciones = int(input("Desea usar local search\n1-ingresar numero(si es un 'si')\n2-Ingresar un cero(si es un 'no'): "))

# Inicializar la mejor distancia y posición
best_distance = sumTmax
best_position_resume = positionResume.copy()

# Variable para rastrear si se encontraron mejores posiciones
found_better_position = False
max_repeticiones = len(distancia) * 3

for _ in range(iteraciones):
    # Seleccionar dos posiciones aleatorias para intercambiar
    pos1 = random.randint(0, len(positionResume) - 1)
    pos2 = random.randint(0, len(positionResume) - 1)

    # Intercambiar las posiciones en la solución
    positionResume[pos1], positionResume[pos2] = positionResume[pos2], positionResume[pos1]

    # Calcular la nueva distancia sumando las distancias en las nuevas posiciones
    new_distance = 0

    for i in range(len(positionResume) - 1):
        pos_actual = positionResume[i]
        pos_siguiente = positionResume[i + 1]
        new_distance += distancia[pos_actual - 1][pos_siguiente - 1]  # Restar 1 para obtener el índice correcto

    # Verificar si la nueva distancia es mejor que la mejor distancia anterior
    if new_distance < best_distance:
        best_distance = new_distance
        best_position_resume = positionResume.copy()
        found_better_position = True

    if found_better_position:
        found_better_position = False
        print("Mejora encontrada:\n***************************\n", best_position_resume)
        valueLast = best_position_resume[-1]
        cancelarion = False
        cancelacion2 = False
        contador = 0
        contador2 = 0
        maxValor = max(valorEntreScore[valueLast - 1])
        posicion = 0
        node_added = False

        while not node_added and contador2 < max_repeticiones:
            contador2 += 1

            for j in valorEntreScore[valueLast - 1]:
                posicion += 1

                if maxValor == j:
                    quitPosicion = posicion

                    posicionDistancia = 0

                    for k, distancias in enumerate(distancia[valueLast - 1], start=1):
                        posicionDistancia += 1

                        if posicionDistancia == quitPosicion:
                            if best_distance + distancias <= tmax:
                                cancelarion = True
                            else:
                                for encontrarMax in valorEntreScore[valueLast - 1]:
                                    contador += 1
                                    if encontrarMax == maxValor:
                                        encontrarMax = 0
                                    if contador > len(distancia):
                                        cancelacion2 = True
                                        break
                                if cancelacion2:
                                    break
                                cancelarion = True

                    if cancelarion:
                        for subArray in valorEntreScore:
                            subArray[quitPosicion - 1] = 0

            if cancelacion2:
                break

            if best_distance >= tmax or not cancelarion:
                break

            if best_distance + distancia[valueLast - 1][quitPosicion - 1] <= tmax:
                best_position_resume.append(quitPosicion)

                posicionDistancia = 0

                for k, distancias in enumerate(distancia[valueLast - 1], start=1):
                    posicionDistancia += 1

                    if posicionDistancia == quitPosicion:
                        best_distance = best_distance + distancias

                node_added = True
                valueLast = quitPosicion

        if node_added:
            sumScore = sum(scores[position - 1] for position in best_position_resume)
            print("se puso otro elemento.")
           
        else:
            sumScore = sum(scores[position - 1] for position in best_position_resume)

        continuarRecorrido = int(input("¿quiere seguir?\n******************\n1-Si\n2-No\n"))

        if continuarRecorrido == 1:
            iteraciones = int(input("Desea usar local search\n1-ingresar numero(si es un 'si')\n2-Ingresar un cero(si es un 'no'): "))
        elif continuarRecorrido == 2:
            exit()

print("*******************************\nno hay un movimiento valido")
print("*******************************\nResultado distancia", best_distance)
print("*******************************\nResultado score", sumScore)
print("*******************************\nResultado de la ruta", best_position_resume)

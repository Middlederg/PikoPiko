# Especificaciones
---

Una tirada se compone de varios lanzamientos de 8 dados.

Cada dado contiene un n�mero, del 1 al 5. En lugar de un 6, hay un gusano, pero este tiene el valor 5 tambi�n

La parrilla contiene 16 raciones del 21 al 36. Las primeras 4 tienen un gusano, las segundas 4 dos, las terceras 4 3 y las �ltimas 4 4 gusanos.

Cada jugador apila sus raciones a medida que las consigue. Solo la �ltima raci�n conseguida est� visible.


## Turno

Un jugador lanza 8 dados a la vez. 

Una vez que se han lanzado los dados, 
- El jugador debe escoger un valor, y quedarse con todos los dados de ese valor.
- No puede escoger los dados de un valor que haya escogido anteriormente

Si no puede es un lanzamiento fallido. (0 puntos)

Ahora, el jugador puede elegir si 
- Lanzar los dados de nuevo, 
- O plantarse con la puntuaci�n obtenida hasta ahora

Si el jugador se planta, coge de la parrilla o de la zona visible de otro jugador la raci�n con el valor igual a la puntuaci�n que ha obtenido.
Si no hay ninguna raci�n disponible, puede coger la raci�n menor al resultado de mayor valor.
Si no hay, se considera un lanzamiento fallido.

Para que la tirada no sea fallida, debe haber conseguido al menos un gusano en los dados guardados.

Lanzamiento fallido:
- Cuando no pueda escoger ning�no de los valores de dados porque ese valor ya est� guardado
- La puntuaci�n de la tirada es menor que la raci�n minima disponible.

-> Devuelve a la parrilla la �ltima raci�n que consigui�.
Luego, si la raci�n devuelta no es la raci�n de mayor valor de la parrilla, �sta �ltima se elimina.
Si el jugador no tiene raci�n que devolver, no se elimina ninguna raci�n.


Finaliza el juego cuando no quedan raciones en la parrilla.

El ganador es el jugador con m�s gusanos en su parrilla.
En caso de empate, gana el jugador con la raci�n de mayor valor.

---

Para probar los elementos que dependen del azar, habr�a que esconder la generaci�n de aleatorios tras una interface

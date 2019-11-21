# Especificaciones
---

Una tirada se compone de varios lanzamientos de 8 dados.

Cada dado contiene un número, del 1 al 5. En lugar de un 6, hay un gusano, pero este tiene el valor 5 también

La parrilla contiene 16 raciones del 21 al 36. Las primeras 4 tienen un gusano, las segundas 4 dos, las terceras 4 3 y las últimas 4 4 gusanos.

Cada jugador apila sus raciones a medida que las consigue. Solo la última ració conseguida está visible.


## Turno

Un jugador lanza 8 dados a la vez. 

Una vez que se han lanzado los dados, 
- El jugador debe escoger un valor, y quedarse con todos los dados de ese valor.
- No puede escoger los dados de un valor que haya escogido anteriormente

Si no puede es un lanzamiento fallido. (0 puntos)

Ahora, el jugador puede elege una de estas dos opciones:
- Lanzar los dados de nuevo, 
- Plantarse con la puntuación obtenida hasta ahora

Si el jugador se planta, coge de la parrilla o de la zona visible de otro jugador la ración con el valor igual a la puntuación que ha obtenido.
Si no hay ninguna ración disponible, puede coger la ración menor al resultado de mayor valor.
Si no hay, se considera un lanzamiento fallido.

Para que la tirada no sea fallida, debe haber conseguido al menos un gusano en los dados guardados.

Lanzamiento fallido:
- Cuando no pueda escoger ninguno de los valores de dados porque ese valor ya está guardado
- La puntuación de la tirada es menor que la ración minima disponible.

-> Devuelve a la parrilla la última ración que consiguió.
Luego, si la ración devuelta no es la ración de mayor valor de la parrilla, ésta última se elimina.
Si el jugador no tiene ración que devolver, no se elimina ninguna ración.


Finaliza el juego cuando no quedan raciones en la parrilla.

El ganador es el jugador con más gusanos en su parrilla.
En caso de empate, gana el jugador con la ración de mayor valor.

---

Para probar los elementos que dependen del azar, habría que esconder la generación de aleatorios tras una interface

# PII_2021_2_Object_Lifecycle
Template ejercicio Object Life Cycle
Respuesta al punto 7:
Lo que puede estar sucediendo es que el crear un numero de objetos muy grande (10000000), el espacio de memoria en el heap o monticulo no llega a ser suficente para guardarlos, por lo que el numero de instancias de la clase depende de la memoria que el vscode asigna.
Respuesta al punto 9:
¿Que pasa con t1==t2? --> La igualdad devuelve false porque a pesar de que ambas instancias teienen los mismos valores en sus argumentos, estan alojadas en distintos puntos de la memoria.
¿Que pasa con t2==t3? --> Ocurre lo mismo que con t1==t2, con la diferencia de que aca las instancias si poseen distintos valores, pero eso no cambia el resultado.

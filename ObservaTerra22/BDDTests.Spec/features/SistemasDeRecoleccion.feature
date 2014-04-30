# language: es
Característica: Sistemas de recolección de datos externos

Escenario: Agregar nuevos sistemas de recolección
	Dado un nuevo sistema de recolección es agregado, no importa el lenguage de programación en el que esté programado
	Cuando se lanzan los sistemas de recolección de datos externos
	Entonces se lanzará también este nuevo sistema y se procesarán sus resultados
	Y el sistema principal no detendrá su ejecución en todo este proceso

Escenario: Se lanzan los sistemas de recolección de datos
	Dado una lista de fuentes externas a la que el sistema está suscrito
	Cuando se lanzan los sistemas de recolección de datos externos
	Entonces todas las fuentes a las que el sistema está suscrito serán analizadas, y sus resultados procesados
# language: es
Característica: Gestión de observaciones

Escenario: Calcular la media de observaciones de un área determinada, como Europa, para un indicador determinado
	Dado una lista de observaciones sobre un indicador dado:
	| País		| Valor	|
	| España	| 1,5	|
	| Francia	| 1,5	|
	| Italia	| 3		|
	| Chile		| 1		|
	Cuando se calcula la nota media de dicho indicador
	Entonces el resultado debe ser el valor 2

Escenario: Obtener las observaciones almacenadas en el sistema sobre un área o indicador determinado
	Dado una lista vacía de observaciones que el sistema posee sobre un área o indicador determinado
	Cuando se realiza una petición de dicha lista
	Entonces el sistema informará al usuario que no se poseen datos sobre las observaciones pedidas

Escenario: Se añade una nueva observación sobre un aspecto determinado en Europa
	Dado una lista de indicadores sobre un aspecto determinado:
	| País    | Número de observaciones |
	| España  | 15                      |
	| Francia | 25                      |
	| Italia  | 31                      |
	| Chile   | 13                      |
	Y se añade una nueva observación sobre ese aspecto en Chile
	Cuando se reciba una petición sobre dicho aspecto en Chile
	Entonces se devolverá un resultado formado por las 14 observaciones que contienen dicho aspecto en Chile
# language: es
Característica: Fuentes de datos externas

Escenario: Obtener publicaciones de fuentes de información externa
	Dado una lista de recursos almacenados en el sistema sobre un tema determinado en un área determinada
	Y una fuente de información a la que se ha suscrito el sistema ObservaTerra ha publicado un nuevo recurso sobre dicho tema en dicha área
	Cuando el sistema lance los sistemas recolectores la siguiente vez
	Entonces la lista de recursos sobre ese tema o ese área será una unidad mayor

Escenario: Agregar una nueva fuente de información externa a la lista de suscripciones
	Dado una lista de fuentes externas a las que el sistema está suscrito
	Cuando el administrador suscribe al sistema a una nueva fuente de información externa
	Entonces la lista de fuentes externas a las que se ha suscrito será una unidad mayor

Escenario: Recolectores de datos en una nueva fuente
	Dado una lista de fuentes externas a las que el sistema está suscrito
	Cuando el administrador suscribe al sistema a una nueva fuente de información externa
	Entonces la siguiente vez que se lancen los recolectores de datos externos, al menos uno deberá analizar la nueva fuente de información y procesar sus resultados

Escenario: Eliminar una fuente de información externa de la lista de suscripciones
	Dado una lista de fuentes externas a las que el sistema está suscrito
	Cuando el administrador elimina la suscripción a una de esas fuentes
	Entonces la lista de fuentes externas a las que se ha suscrito será una unidad menor

Escenario: Recolectores de datos tras eliminación de suscripción
	Dado una lista de fuentes externas a la que el sistema está suscrito
	Cuando el administrador eliminar la suscripción a una de esas fuentes de información
	Entonces la siguiente vez que se lancen los recolectores, ninguno analizará la fuente de información que se acaba de eliminar.
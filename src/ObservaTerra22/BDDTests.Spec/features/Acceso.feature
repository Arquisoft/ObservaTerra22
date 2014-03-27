# language: es
Característica: Acceso al sistema

Escenario: Un usuario registrado se loguea
	Dado un usario registrado en el sistema y con su cuenta habilitada
	Cuando dicho usuario se loguea en el sistema
	Entonces el sistema le asigna un token que representa el tipo de usuario que es, y le permite el acceso

Escenario: Un usuario no registrado se loguea
	Dado un usuario no registrado en el sistema
	Cuando dicho usuario se loguea en el sistema
	Entonces el sistema rechaza su petición de acceso

Escenario: Un usuario registrado pero sin habilitar se loguea
	Dado un usuario registrado en el sistema, pero cuya cuenta no ha sido habilitada todavía
	Cuando dicho usuario se loguea en el sistema
	Entonces el sistema rechaza su petición

Escenario: Un usuario accede al sistema sin loguearse
	Dado un usuario no logueado
	Cuando el usuario accede al sistema
	Entonces el sistema le asigna un token por defecto que lo identifica como un usuario no registrado

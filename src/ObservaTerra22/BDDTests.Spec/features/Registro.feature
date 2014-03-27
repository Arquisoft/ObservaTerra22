# language: es
Característica: Registro

Escenario: Un usuario se registra correctamente en el sistema
	Dado un usuario no logueado en el sistema
	Cuando el usuario lanza una petición de registro al sistema
	Y completa el formulario de registro
	Entonces se crea una cuenta a dicho usuario, pero dicha cuenta no estará habilitada hasta que el administrador cambie su estado

Escenario: Un usuario se registra incorrectamente en el sistema
	Dado un usuario no logueado en el sistema
	Cuando el usuario lanza una petición de registro al sistema
	Y el identificador de dicho usuario ya está siendo usado en el sistema
	Entonces se avisará al usuario para que elija otro identificador y no se creará la cuenta

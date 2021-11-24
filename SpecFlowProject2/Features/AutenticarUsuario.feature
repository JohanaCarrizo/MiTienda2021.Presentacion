Feature: Autenticar Usuario


@mytag
Scenario: Ingreso Exitoso
	Given Dado un usuario con legajo "legajo" 
	And Dado un usuario con contraseña "contraseña"
	When Cuando el usuario ingresa al sistema
	Then Se realiza correctamente el inicio de sesion
	
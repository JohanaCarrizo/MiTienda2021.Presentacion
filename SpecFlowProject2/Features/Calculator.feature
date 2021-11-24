Feature: Identicacion de un Cliente Anonimo


@mytag
Scenario: El cliente no supera los $10.000 y su condición tributaria es igual a “Consumidor Final”
	Given Dado que el Precio total de venta 9
	And Condición tributaria “Consumidor Final”
	When Se desea finalizar la venta
	Then Se obtiene el cliente "20-99.999.999-9"
	
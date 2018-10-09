# TestEdelap
la idea fue crear una clase "rental" abstracta que sirviera solo para poder heredar de ella las demas clases con la propiedad "price"
luego tres clases para los distintos tipos de alquileres, por hour, dia o semana con una logica muy similar pero cambiando consecuentemente el "price"
En la clase ActualRental, esta la logica de negocio, se aplica la promocion si hiciese falta y se calculan las sumas de los alquileres cualquiera fuese su tipo.
los calculos estan insertados en un try-catch solo a los fines didacticos, ya que no estan manejadas las excepciones.
En cuanto al coverage, yo estoy trabajando ahora desde mi casa con un VS community, por lo cual no tengo tests de cobertura pero intuyo que cumplo con el 85% requerido.
Laboralmente suelo usar test coverages, no en mi casa.
Se testean los 3 tipos de alquileres (dia, mes, hora) y aparte se prueban las promos.
Intento que los nombres de los test sean claros en lo que se espera testear.
Se testea el correcto funcionamiento de la promocion si esta entre 3 y 5 alquileres y tambien se testea que si son menos de 3, o mas de 5 no se aplique el descuento del 30%
Para correr los tests, desde el visual studio simplemente abrir el archivo de test y presionar Ctrl + R + T, o sencillamente run all test desde el explorador de tests de VS.
Asumo que el "Family Rental" debe ser solicitado explicitamente por el cliente, en caso que sea automatico, deberia meterse la logica del GetPromo dentro de GetTotal.
No creo conveniente sobrecargar la complejidad del ejercicio con Interfaces que signen los metodos, pero en un desarrollo de mayor complejidad si lo haria.
Evite comentarios innnecesarios, si bien acostumbro a usarlos para explicar brevemente que hace cada metodo o clase, de igual modo trato de evitarlos cuando es obvio, pero en problemas de mayor complejidad iria todo comentado brevemente.


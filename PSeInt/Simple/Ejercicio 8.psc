Proceso sin_titulo
		//8. Dada la duración en minutos de una llamada calcular el costo, considerando
		// - Hasta tres minutos el costo es 600
		// -  Por encima de tres minutos es 600 más 150 por cada minuto adicional a los tres primeros.
		
		Definir minutos como real;
		Definir costo, min_extra, total_pagar Como Real;
		
		Escribir "Digite el numero de minutos hablados";
		Leer minutos;
		
		Si (minutos > 3) Entonces
			costo <- (3 * 200);
			min_extra <- (minutos - 3);
			total_pagar <- (costo + (min_extra * 150));
			Escribir "El costo de los minutos hablados es de ", total_pagar, "$";
		FinSi
		Si (minutos <= 3) Entonces
			costo <- (minutos * 200);
			Escribir "El costo de los minutos hablados es de ", costo, "$.";
		FinSi
		
FinProceso

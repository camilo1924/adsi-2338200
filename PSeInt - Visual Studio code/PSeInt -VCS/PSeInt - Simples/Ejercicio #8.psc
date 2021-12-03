Proceso sin_titulo
	//8. Dada la duración en minutos de una llamada calcular el costo, considerando
	// Hasta tres minutos el costo es 600
	// Por encima de tres minutos es 600 más 150 por cada minuto adicional a los tres primeros.
	
	Definir valor1, minutos_extra, total_pagar, minutos Como Real;
	
	Escribir "Digite la cantidad de minutos hablados";
	Leer minutos;
	
	Si (minutos > 3) Entonces
		valor1 = (3 * 200);
		minutos_extra = (minutos - 3);
		total_pagar = (valor1 + (minutos_extra * 150));
		Escribir "El valor de los minutos hablados es de ", total_pagar, "$";
	FinSi
	Si (minutos <= 3) Entonces
		valor1 = (minutos * 200);
		Escribir "El valor de los minutos hablados es de ", valor1, "$.";
	FinSi
FinProceso

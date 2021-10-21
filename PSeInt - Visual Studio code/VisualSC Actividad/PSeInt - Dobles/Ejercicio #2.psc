Proceso sin_titulo
	//2. Un obrero necesita calcular su salario semanal, el cual se obtiene de la sig. manera:
	// - Si trabaja 40 horas o menos se le paga $16 por hora
	// - Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20 por cada hora
	//extra.
	
	Definir horas, horas_extra, total_pagar Como Real;
	
	Escribir "Digite la cantidad de horas que trabajó";
	Leer horas;
	
	SI (horas > 40) Entonces
		horas_extra = (horas - 40) * 20;
		total_pagar = horas_extra + (40 * 16);
		Escribir "El valor a pagar es de ", total_pagar, " Se incluyeron las horas extras.";
	SiNo
		total_pagar = horas * 16;
		Escribir "El valor a pagar es de ", total_pagar;
		
	FinSi
FinProceso

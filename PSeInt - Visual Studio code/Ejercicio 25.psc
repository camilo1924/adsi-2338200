Proceso sin_titulo
	//25. Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 - 2,9), Suficiente (3 - 4,5) y Bien (4,6 - 5)
	
	//Proceso 
	Definir A Como real;
	
	//Proceso 
	Escribir "Digite el numero de la nota entre 0 y 5";
	Leer A;
	
	//Proceso 
	si A == 0 y A <= 2.9 Entonces
		Escribir "Insuficiente";
	SiNo
		si A > 2.9 y A <= 4.5 Entonces
			Escribir "Suficiente";
		SiNo
			si A > 4.5 y A <= 5 Entonces
				Escribir "Bien";
			FinSi
		FinSi
	FinSi
	
FinProceso

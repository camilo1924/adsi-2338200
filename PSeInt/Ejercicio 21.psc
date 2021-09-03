Proceso  sin_titulo
	//21. Pedir dos números y decir cuál es el mayor o si son iguales.
	
	//Proceso 
	Definir A Como Real;
	Definir B Como Real;
	
	//Proceso 
	Escribir "Digite el primer numero";
	Leer A;
	Escribir "Digite el segundo numero";
	Leer B;
	
	//Proceso 
	si A == B Entonces
		Escribir "son iguales";
	SiNo
		si A > B Entonces
			Escribir "el numero ",A," es mayor a ",B;
		SiNo
			Escribir "el numero ",B," es mayor a ",A;
		FinSi
	FinSi
	
FinProceso


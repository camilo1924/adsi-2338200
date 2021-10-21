Proceso sin_titulo
	//Pedir dos números y mostrarlos ordenados de mayor a menor.
	// Proceso  
	Definir n1 Como Entero;
	Definir n2 Como Entero;
	Definir n3 Como Entero;
	//Proceso
	Escribir "Digite el primer numero";
	Leer n1;
	Escribir "Digite el segundo numero";
	Leer n2;
	Escribir "Digite el tercer numero";
	Leer n3;
	//Proceso 
	si n1 > n2 y n2 > n3 Entonces
		Escribir "",n1," > ",n2," > ",n3;
	SiNo 
		si n1 > n3 y n3 > n2 Entonces
			Escribir "",n1," > ",n3," > ",n2;
		SiNo
			si n2 > n1 y n1 > n3 Entonces
				Escribir "",n2," > ",n1," > ",n3;
			SiNo
				si n2 > n3 y n3 > n1 Entonces
					Escribir "",n2," > ",n3," > ",n1;
				SiNo
					si n3 > n1 y n1 > n2 Entonces
						Escribir "",n3," > ",n1," > ",n2;
					SiNo
						si n3 > n2 y n2 > n1 Entonces
							Escribir "",n3," > ",n2," > ",n1;
						FinSi
					FinSi
				FinSi
			FinSi
			
			
		FinSi
		
	FinSi
	
	
FinProceso

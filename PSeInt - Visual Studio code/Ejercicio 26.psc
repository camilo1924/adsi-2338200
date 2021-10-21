Proceso sin_titulo
	//Pedir una nota numérica entera entre 0 y 10, y mostrar dicha nota de la forma: cero, uno, dos, tres...
	//Proceso 
	Definir nota Como Real;
	//Proceso 
	Escribir " Digite una nota entre 0 y 10";
	Leer nota;
	//Proceso 
	si (nota ==0 ) Entonces 
		Escribir "cero";
	SiNo 
	FinSi
	si (nota ==1 ) Entonces 
		Escribir "uno";
	SiNo
		si (nota ==2 ) Entonces 
			Escribir "dos";
		SiNo
			si (nota ==3 ) Entonces 
				Escribir "tres";
			SiNo
				si (nota ==4 ) Entonces 
					Escribir "cuatro";
				SiNo
					si (nota ==5 ) Entonces 
						Escribir "cinco";
					SiNo
						si (nota ==6) Entonces 
							Escribir "seis";
						SiNo
							si (nota ==7) Entonces 
								Escribir "siete";
							SiNo
								si (nota ==8) Entonces 
									Escribir "ocho";
								SiNo
									si (nota ==9) Entonces 
										Escribir "nueve";
									SiNo
										si (nota ==10) Entonces 
											Escribir "Diez";
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
		
		
	FinSi
FinProceso

Proceso sin_titulo
	//24. Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene.
	
	//Proceso 
	Definir A Como Real;
	
	//Proceso 
	Escribir "Digite el numero";
	Leer A;
	
	//Proceso
	si A < 0 Entonces
		Escribir "el numero no es valido";
	SiNo
		si A < 9 Entonces
			Escribir " El numero ",A," tiene una cifra ";
		sino
			si A > 9 y A < 99 Entonces
				Escribir " El numero ",A," tiene dos cifras ";
			SiNo
				si A > 99 y A < 999 Entonces
					Escribir " El numero ",A," tiene tres cifras ";
				SiNo
					si A > 999 y A < 9999 Entonces
						Escribir " El numero ",A," tiene cuatro cifras ";
					SiNo
						Escribir "el numero ",A," tiene 5 o mas cifras";
					FinSi
					
				FinSi
				
			FinSi
			
		FinSi
	FinSi
	
	
FinProceso

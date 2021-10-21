Proceso sin_titulo
	//Leer dos números y calcular su división, teniendo en cuenta que el denominador no debe ser 0 (cero)
	//Proceso 
	Definir n1,n2,total Como Real;
	//Proceso 
	Escribir "Digite el primer numero";
	Leer n1;
	Escribir "Digite el segundo numero";
	Leer n2;
	//Proceso 
	si (n2==0) Entonces
		Escribir "La operacion es incorrecta: ";
	SiNo
		total=n1/n2;
		Escribir "El total de la divisiones: ",total;
	FinSi
FinProceso

Proceso sin_titulo
	//28. Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000 
	//(diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas trabajadas y valor de la hora.
	
	//Proceso 
	Definir sueldo,horas,exedente,pago Como Real;
	
	//Proceso 
	Escribir "Digite numero de horas trabajadas";
	Leer horas;
	Escribir "Digite el valor de la hora trabajada";
	Leer pago;
	
	//Proceso 
	Si horas > 40 Entonces
		exedente = horas - 40;
		sueldo = (40 * pago) + (exedente * pago * 2);
	SiNo
		sueldo = horas * pago;
	FinSi
	Escribir " horas trabajadas es: ",horas," Y el pago es: ",sueldo;
FinProceso

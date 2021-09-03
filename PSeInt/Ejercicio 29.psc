Proceso sin_titulo
	//29. Dado un monto, calcular el descuento considerando que por encima de 100 el descuento es del 10%
	//y por debajo de 100, el descuento es del 2%.
	
	//Proceso 
	Definir monto,descuento Como Real;
	
	Escribir "Digite el monto";
	
	Leer monto;
	
	si (monto>100000) Entonces
		descuento = monto*0.10;
	SiNo
		descuento = monto*0.02;
	FinSi
	Escribir "su descuento es: ",descuento;
FinProceso

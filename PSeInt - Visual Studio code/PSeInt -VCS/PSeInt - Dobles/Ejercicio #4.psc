Proceso sin_titulo
	//4. Una empresa de bienes raíces ofrece casas de interés social, bajo las siguientes condiciones: Si los ingresos del
	//comprador son mayores o iguales a $800000 la cuota inicial será del 15% del costo de la casa y el resto se
	//distribuirá en pagos mensuales, a pagar en diez años. Si los ingresos del comprador son inferiores a de $800000
	//la cuota inicial será del 30% del costo de la casa y el resto se distribuirá en pagos mensuales a pagar en 7 años.
	//La empresa quiere saber cuanto debe pagar un comprador por concepto de cuota inicial y cuanto por cada
	//pago mensual ingresando el valor de la casa
	
	Definir ingreso_mes, Costo_inicial, Costo_mensual, Precio Como Real;
	Escribir "Digite el monto total de sus ingresos mensuales ";
	Leer ingreso_mes;
	Escribir "Digite el valor total de la vivienda que desea adquerir";
	Leer Precio;
	
	//Proceso 
	Si (ingreso_mes >= 800000) Entonces
		Costo_inicial = precio * 0.15;
		Costo_mensual = ((Precio - Costo_inicial) / 120);
		Escribir "La cuota inicial de la vivienda es de ", Costo_inicial;
		Escribir "Las cuotas mensuales seran de ", Costo_mensual;
	SiNo
		Costo_inicial = precio * 0.3;
		Costo_mensual = ((precio - Costo_inicial) / 84);
		Escribir "La cuota inicial de la vivienda es de ", Costo_inicial;
		Escribir "Las cuotas mensuales seran de ", Costo_mensual;
	FinSi
FinProceso

Proceso sin_titulo
		//4. Una empresa de bienes raíces ofrece casas de interés social, bajo las siguientes condiciones: Si los ingresos del
		//comprador son mayores o iguales a $800000 la cuota inicial será del 15% del costo de la casa y el resto se
		//distribuirá en pagos mensuales, a pagar en diez años. Si los ingresos del comprador son inferiores a de $800000
		//la cuota inicial será del 30% del costo de la casa y el resto se distribuirá en pagos mensuales a pagar en 7 años.
		//La empresa quiere saber cuanto debe pagar un comprador por concepto de cuota inicial y cuanto por cada
		//pago mensual ingresando el valor de la casa
		
		Definir ingreso_mes, C_inicial, C_mensual, Precio Como Real;
		Escribir "Digite el monto total de sus ingresos mensuales (En pesos $)";
		Leer ingreso_mes;
		Escribir "Digite el valor total de la vivienda que desea adquerir";
		Leer Precio;
		
		//Proceso 
		Si (ingreso_mes >= 800000) Entonces
			C_inicial <- ((Precio * 15) / 100); 
			C_mensual <- ((Precio - C_inicial) / 120);
			Escribir "La cuota inicial de la vivienda es de ", C_inicial, "$.";
			Escribir "Las cuotas mensuales seran de ", C_mensual, "$.";
		SiNo
			C_inicial <- ((precio * 30) / 100);
			C_mensual <- ((precio - C_inicial) / 84);
			Escribir "La cuota inicial de la vivienda es de $", C_inicial;
			Escribir "Las cuotas mensuales seran de $", C_mensual;
		FinSi


FinProceso

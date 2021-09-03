Proceso sin_titulo
	//Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
	//Proceso 
	Definir nombre_persona como cadena;
	Definir valor_hora Como real;
	Definir numero_horas Como real;
	Definir pago_persona Como real;
	//Proceso 
	Escribir "ingrese su nombre" ;
	Leer nombre_persona;
	Escribir "ingrese el valor por hora de trabajo" ;
	Leer valor_hora;
	Escribir "ingrese el numero de horas de trabajo" ;
	Leer numero_horas;
	//Proceso 
	pago_persona = numero_horas*valor_hora;
	//salida
	Escribir  "su nombre es:", nombre_persona, " y su pago final es:", pago_persona;
FinProceso

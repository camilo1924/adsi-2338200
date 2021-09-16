Proceso sin_titulo
		//2. La compañía de seguros de vida atlas se va a cambiar de domicilio y por lo tanto pone en venta su
		//terreno pero no tiene una idea del valor del terreno, entonces solicita al departamento de sistemas
		//que le desarrolle un algoritmo con la finalidad de que calcule e imprima el precio del terreno del cual
		//se tiene los siguientes datos: largo, ancho y precio por metro cuadrado, si el terreno tiene más de
		//400 metros cuadrados se hace un descuento del 10%.
		
		//Declaración de variables
		Definir largo, ancho, valor_metro2, area, Con_descuento, Sin_decuento Como Real;
		
		//Salida
		Escribir "Digite el largo del terreno";
		Leer largo;
		Escribir "Digite el ancho del terreno";
		Leer ancho;
		Escribir "Digite el precio por metro cuadrado del terreno";
		Leer valor_metro2;
		
		//Proceso 
		area <- (largo * ancho);
		Sin_decuento <- (area * valor_metro2);
		Escribir "Su total a pagar es de ", Sin_decuento;
		
		Si (area > 400) Entonces
			Con_descuento <- Sin_decuento - (Sin_decuento * 10 / 100);
			Escribir "Y menos el 10% de descuento, su total a pagar es de ", Con_descuento;
		FinSi
		
		
FinProceso

Proceso sin_titulo
	//2. La compañía de seguros de vida atlas se va a cambiar de domicilio y por lo tanto pone en venta su
	//terreno pero no tiene una idea del valor del terreno, entonces solicita al departamento de sistemas
	//que le desarrolle un algoritmo con la finalidad de que calcule e imprima el precio del terreno del cual
	//se tiene los siguientes datos: largo, ancho y precio por metro cuadrado, si el terreno tiene más de
	//400 metros cuadrados se hace un descuento del 10%.
	
	Definir L Como Real;
	Definir A Como Real;
	Definir P Como Real;
	Definir Terreno Como Real;
	Definir PrecioTerreno Como Real;
	Definir Descuento Como Real;
	Definir Preciofinal Como Real;
	
	Escribir "Digite el largo del terreno en metros";
	Leer L;
	Escribir "Digite el ancho del terreno en metros";
	Leer A;
	Escribir "Digite el precio por metro cuadrado";
	Leer P;
	
	Terreno = A * L;
	PrecioTerreno = terreno * P;
	Escribir " El valor de su terreno sin descuento es: ", PrecioTerreno;
	
	si terreno > 400 Entonces
		Descuento = PrecioTerreno * 0.10;
		Preciofinal = PrecioTerreno - Descuento;
		Escribir " El valor de su terreno con descuento es: ", Preciofinal;
	FinSi
FinProceso

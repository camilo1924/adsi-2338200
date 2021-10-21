Proceso sin_titulo
	//4. Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original y su precio con
	//descuento. El descuento lo hace en base a la clave, si la clave es 1 el descuento es del 10% y si la
	//clave es 2 el descuento en del 20% (solo existen dos claves).
	
	Definir nombrearticulo como cadena;
	Definir clave Como Entero;
	Definir preciooriginal Como Real;
	Definir descuento Como Real;
	Definir preciodescuento1 Como Real;
	Definir preciodescuento2 Como Real;
	
	Escribir "Digite el nombre del articulo";
	Leer nombrearticulo;
	Escribir "Digite la clave del articulo entre 1 y 2";
	Leer clave;
	Escribir "Digite el precio del articulo";
	Leer preciooriginal;
	
	si clave == 1 Entonces
		Descuento = preciooriginal * 0.10;
		preciodescuento1 = preciooriginal - Descuento;
		Escribir "El precio de su articulo con descuento es: ",preciodescuento1;
		si clave == 2 Entonces
			Descuento = preciooriginal * 0.20;
			preciodescuento2 = preciooriginal - Descuento;
			Escribir "El precio de su articulo con descuento es: ",preciodescuento2;
			si clave <> 1 o clave <> 2 Entonces
				Escribir "El articulo no tiene descuento y su precio es: ",preciooriginal;
			FinSi
		FinSi
	FinSi
FinProceso

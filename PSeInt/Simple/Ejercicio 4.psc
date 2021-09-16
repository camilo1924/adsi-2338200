Proceso sin_titulo
		//identificar nombre del articulo clave, precio original, precio con descuento 
		// clave 1.2 si es 1-10% si es 2-20%
		definir  clav , precio, descuento, pdescuento como enteros; 
		definir nombre Como Caracter;
		escribir " BIENVENIDO AL SISTEMA";
		escribir " digite el articulo que desea comprar ";
		leer nombre ;
		escribir " digite la clave que le fue asignada (1,2)";
		leer clav;
		escribir "digite el precio correspondiente a su articulo ", nombre; 
		leer precio ;
		Si (clav <> 1) y (clav <> 2) Entonces
			escribir " Usted no tiene clave valida de descuento su  ", nombre, " conserva su precio de ", precio;
		FinSi
		Si (clav=1) Entonces;
			descuento <- precio*(10/100);
			pdescuento <- precio-descuento;
			escribir" su clave ", clav, " tiene un descuento del 10%, el articulo; ", nombre ," para usted tiene un valor de ", pdescuento;
		FinSI
		Si (clav == 2) Entonces
			descuento <- precio*(20/100);
			pdescuento <- precio-descuento;
			escribir" su clave ", clav, " tiene un descuento del 20%, el articulo: ", nombre ," para usted tiene un valor de ", pdescuento;
		FinSi
FinProceso

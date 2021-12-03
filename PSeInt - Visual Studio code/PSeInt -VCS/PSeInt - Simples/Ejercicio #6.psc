Proceso sin_titulo
	//6. En un supermercado se hace una promoción, mediante la cual el cliente obtiene un descuento
	//dependiendo de un número que se escoge al azar. Si el numero escogido es menor que 74 el
	//descuento es del 15% sobre el total de la compra, si es mayor o igual a 74 el descuento es del 20%.
	//Obtener cuánto dinero se le descuenta.
	
	Definir Numazar, valorcompra, descuento, totalpagar Como Real;
	
	Escribir "Digite el valor total de su compra";
	Leer valorcompra;
	
	Numazar = azar(100);
	
	Escribir "El numero al azar asignado es ", Numazar;
	
	descuento = valorcompra * 0.15;
	Si Numazar >= 74 Entonces
		descuento = valorcompra * 0.20;
	FinSi
	totalpagar = valorcompra - descuento;
	
	Escribir "Su descuento es de ", descuento, " y su total a pagar es ", totalpagar;
FinProceso

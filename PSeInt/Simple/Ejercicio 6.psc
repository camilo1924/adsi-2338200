Proceso sin_titulo
		//6. En un supermercado se hace una promoción, mediante la cual el cliente obtiene un descuento
		//dependiendo de un número que se escoge al azar. Si el numero escogido es menor que 74 el
		//descuento es del 15% sobre el total de la compra, si es mayor o igual a 74 el descuento es del 20%.
		//Obtener cuánto dinero se le descuenta.
		
		//Defición de variables 
		Definir Num_azar, valor_compra, descuento, total_pagar Como Real;
		
		//Salida 
		Escribir "Digite el valor total de su compra";
		//Entrada
		Leer valor_compra;
		//Salida
		Escribir "Digite un numero al azar";
		//Entrada 
		Leer Num_azar;
		
		Si (Num_azar < 74) Entonces
			descuento <- ((valor_compra * 15) / 100);
			total_pagar <- (valor_compra - descuento);
			Escribir "SU descuento es de ", descuento, " Por ende, su total a pagar es ", total_pagar;
			
		FinSi
		Si (Num_azar >= 74) Entonces
			descuento <- ((valor_compra * 20 )/ 100);
			total_pagar <- (valor_compra - descuento);
			Escribir "SU descuento es de ", descuento, " por ende, su total a pagar es ", total_pagar;
		FinSi
		
FinProceso
